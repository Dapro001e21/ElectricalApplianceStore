using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalApplianceStore.Services
{
    public class UserService
    {
        public static async Task<User> GetUserAsync(int id = 0, string email = "")
        {
            SqlDataReader reader = await new SqlCommand($"select * from Users where Id = {id} or Email = '{email}'", SqlDataBase.Instance()).ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                int id_ = reader.GetInt32(0);
                string name = reader.GetString(1);
                string email_ = reader.GetString(2);
                string password = reader.GetString(3);
                UserType type = (UserType)Enum.Parse(typeof(UserType), reader.GetString(4));
                reader.Close();
                return new User(id_, name, email_, password, type);
            }

            reader.Close();
            return null;
        }

        public static async Task<bool> UpdateUserInfo(string name, string email, string password, User user)
        {
            bool isUpdate = false;
            if (name != user.Name && !string.IsNullOrWhiteSpace(name))
            {
                await new SqlCommand($"update Users set Name = '{name}' where Id = {user.Id}", SqlDataBase.Instance()).ExecuteNonQueryAsync();
                isUpdate = true;
            }

            if (email != user.Email && !string.IsNullOrWhiteSpace(email))
            {
                if (!await IsEmailExistsAsync(email) && Email.IsValidEmail(email))
                {
                    await new SqlCommand($"update Users set Email = '{email}' where Id = {user.Id}", SqlDataBase.Instance()).ExecuteNonQueryAsync();
                    await Email.SendEmailAsync(email, "Success", "Почта успешна изменена!!!");
                    isUpdate = true;
                }
                else if(await IsEmailExistsAsync(email))
                {
                    MessageBox.Show("Пользователь с таким email уже существует!!!");
                }
                else
                {
                    MessageBox.Show("Введите корректную почту!!!");
                }
            }

            if (Cryptography.HashPassword(password) != user.Password && password.Length >= Authorization.MINLENGHT && !string.IsNullOrWhiteSpace(password))
            {
                await new SqlCommand($"update Users set Password = '{Cryptography.HashPassword(password)}' where Id = {user.Id}", SqlDataBase.Instance()).ExecuteNonQueryAsync();
                await Email.SendEmailAsync(email, "Success", "Пароль успешно изменён!!!");
                isUpdate = true;
            }
            else if (Cryptography.HashPassword(password) == user.Password)
            {
                MessageBox.Show("Пароль не должен совпадать с предыдущим!!!");
            }
            else if (password.Length < Authorization.MINLENGHT && !string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show($"Длина пароля должна быть больше {Authorization.MINLENGHT} символов!!!");
            }

            return isUpdate;
        }

        public static async Task<bool> IsEmailExistsAsync(string email)
        {
            SqlDataReader checkEmailReader = await new SqlCommand($"select * from Users where Email = '{email}'", SqlDataBase.Instance()).ExecuteReaderAsync();
            if (await checkEmailReader.ReadAsync())
                return true;
            return false;
        }
    }
}

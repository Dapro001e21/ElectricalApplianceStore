using ElectricalApplianceStore.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalApplianceStore
{
    public class Authorization
    {
        public const int MINLENGHT = 5;
        public static async Task<User> Sign_InAsync(string email, string password)
        {
            SqlDataReader reader = await new SqlCommand($"select * from Users where Users.Email='{email}' and Users.Password='{Cryptography.HashPassword(password)}'", SqlDataBase.Instance()).ExecuteReaderAsync();
            if(await reader.ReadAsync())
            {
                int Id = reader.GetInt32(0);
                string Name = reader.GetString(1);
                string Email = reader.GetString(2);
                string Password = reader.GetString(3);
                UserType Type = (UserType)Enum.Parse(typeof(UserType), reader.GetString(4));
                reader.Close();
                return new User(Id, Name, Email, Password, Type);
            }

            reader.Close();
            MessageBox.Show("Ошибка в логине или пароле!!!");
            return null;
        }

        public static async Task<User> Sign_UpAsync(string name, string email, string password)
        {
            if (!await UserService.IsEmailExistsAsync(email) && Email.IsValidEmail(email) && password.Length >= MINLENGHT)
            {
                await new SqlCommand($"insert into Users values ('{name}', '{email}', '{Cryptography.HashPassword(password)}', '{UserType.User}')", SqlDataBase.Instance()).ExecuteNonQueryAsync();
            }else if (password.Length < MINLENGHT)
            {
                MessageBox.Show($"Длина пароля должна быть больше {MINLENGHT} символов!!!");
                return null;
            }
            else if(!Email.IsValidEmail(email))
            {
                MessageBox.Show("Введите корректную почту!!!");
                return null;
            }
            else
            {
                MessageBox.Show("Пользователь с таким email уже существует!!!");
                return null;
            }

            MessageBox.Show("Вы успешно зарегестрировались!!!");
            await Email.SendEmailAsync(email, "Success", "Вы успешно зарегестрировались!!!");
            return await Sign_InAsync(email, password);
        }

        public static void SwitchingForm(User user, Form parentForm)
        {
            parentForm.Visible = false;
            Form form = new Form();
            switch (user.Type)
            {
                case UserType.User:
                    form = new UserForm(user);
                    break;
                case UserType.Admin:
                    form = new SelectiveForm(user);
                    break;
                default:
                    break;
            }

            if(form.ShowDialog() == DialogResult.Cancel)
            {
                parentForm.Visible = true;
            }
        }
    }
}

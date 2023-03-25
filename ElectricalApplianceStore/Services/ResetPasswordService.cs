using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalApplianceStore.Services
{
    public class ResetPasswordService
    {
        private int code;
        private User user;
        public async Task<bool> ResetPasswordAsync(string email)
        {
            if (await UserService.IsEmailExistsAsync(email))
            {
                code = new Random().Next(10000, 99999);
                await Email.SendEmailAsync(email, "Сброс пароля", $"Код для сброса пароля: {code}");
                user = await UserService.GetUserAsync(email: email);
                return true;
            }
            else
            {
                MessageBox.Show("Пользователя с такой почтой не существует!!!");
            }
            return false;
        }

        public bool ConfirmCode(int code)
        {
            if (this.code == code)
                return true;
            return false;
        }

        public async Task<bool> ConfirmPasswordAsync(string password)
        {
            if(password.Length >= Authorization.MINLENGHT && Cryptography.HashPassword(password) != user.Password)
            {
                await new SqlCommand($@"update Users set Password = '{Cryptography.HashPassword(password)}' where Id = '{user.Id}'", SqlDataBase.Instance()).ExecuteNonQueryAsync();
                return true;
            }
            else if (password.Length < Authorization.MINLENGHT)
            {
                MessageBox.Show($"Длина пароля должна быть больше {Authorization.MINLENGHT} символов!!!");
            }
            else
            {
                MessageBox.Show("Пароль не должен совпадать с предыдущим!!!");
            }
            return false;
        }
    }
}

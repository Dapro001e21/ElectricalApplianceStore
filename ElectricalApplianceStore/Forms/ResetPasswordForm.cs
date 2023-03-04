using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalApplianceStore
{
    public partial class ResetPasswordForm : Form
    {
        SqlConnection connection;
        int code;
        User user;
        public ResetPasswordForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private async void resetPassword_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_TextBox.Text))
                return;
            if(await ResetPasswordAsync(connection, email_TextBox.Text))
            {
                SqlDataReader reader = new SqlCommand($"select * from Users where Email='{email_TextBox.Text}'", connection).ExecuteReader();
                if (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Name = reader.GetString(1);
                    string Email = reader.GetString(2);
                    string Password = reader.GetString(3);
                    UserType Type = (UserType)Enum.Parse(typeof(UserType), reader.GetString(4));
                    user = new User(Id, Name, Email, Password, Type);
                }
                reader.Close();
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            int enterCode;
            int.TryParse(code_TextBox.Text, out enterCode);
            if(enterCode == code)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private async void save_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newPassword_TextBox.Text) || string.IsNullOrWhiteSpace(twoNewPassword_TextBox.Text))
                return;
            if(newPassword_TextBox.Text.Length >= Authorization.MINLENGHT && newPassword_TextBox.Text == twoNewPassword_TextBox.Text && Cryptography.HashPassword(newPassword_TextBox.Text) != user.Password)
            {
                await new SqlCommand($@"update Users set Password = '{Cryptography.HashPassword(newPassword_TextBox.Text)}' where Email = '{email_TextBox.Text}'", connection).ExecuteNonQueryAsync();
            }else if(newPassword_TextBox.Text.Length < Authorization.MINLENGHT)
            {
                MessageBox.Show($"Длина пароля должна быть больше {Authorization.MINLENGHT} символов!!!");
                return;
            }else if(Cryptography.HashPassword(newPassword_TextBox.Text) == user.Password)
            {
                MessageBox.Show("Пароль не должен совпадать с предыдущим!!!");
                return;
            }
            else
            {
                MessageBox.Show("Пароли должны совпадать!!!");
                return;
            }
            MessageBox.Show("Вы успешно сменили пароль!!!");
            await Email.SendEmailAsync(email_TextBox.Text, "Success", "Пароль успешно изменён!!!");
            Close();
        }

        private async Task<bool> ResetPasswordAsync(SqlConnection connection, string email)
        {
            if (await Email.IsEmailExistsAsync(connection, email))
            {
                code = new Random().Next(10000, 99999);
                await Email.SendEmailAsync(email, "Сброс пароля", $"Код для сброса пароля: {code}");
                return true;
            }
            else
            {
                MessageBox.Show("Пользователя с такой почтой не существует!!!");
            }
            return false;
        }

        private void newPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (newPassword_CheckBox.Checked == true)
                newPassword_TextBox.PasswordChar = '\0';
            else
                newPassword_TextBox.PasswordChar = '●';
        }

        private void twoNewPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (twoNewPassword_CheckBox.Checked == true)
                twoNewPassword_TextBox.PasswordChar = '\0';
            else
                twoNewPassword_TextBox.PasswordChar = '●';
        }
    }
}

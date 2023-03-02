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
    public partial class ProfileForm : Form
    {
        SqlConnection connection;
        User user;
        public ProfileForm(SqlConnection connection, User user)
        {
            InitializeComponent();
            this.connection = connection;
            this.user = user;
            name_TextBox.Text = user.Name;
            email_textBox.Text = user.Email;
        }

        private async void save_Button_Click(object sender, EventArgs e)
        {
            bool isUpdate = false;
            if(name_TextBox.Text != user.Name && !string.IsNullOrWhiteSpace(email_textBox.Text))
            {
                new SqlCommand($"update Users set Name = '{name_TextBox.Text}' where Id = {user.Id}", connection).ExecuteNonQuery();
                isUpdate = true;
            }

            if(email_textBox.Text != user.Email && !string.IsNullOrWhiteSpace(email_textBox.Text))
            {
                SqlDataReader checkEmailReader = new SqlCommand($"select * from Users where Email = '{email_textBox.Text}'", connection).ExecuteReader();
                if (!checkEmailReader.Read())
                {
                    new SqlCommand($"update Users set Email = '{email_textBox.Text}' where Id = {user.Id}", connection).ExecuteNonQuery();
                    await Email.SendEmailAsync(email_textBox.Text, "Success", "Почта успешна изменена!!!");
                }
                else
                {
                    MessageBox.Show("Пользователь с таким email уже существует!!!");
                    return;
                }
                isUpdate = true;
            }

            if(Cryptography.HashPassword(newPassword_TextBox.Text) != user.Password && newPassword_TextBox.Text.Length >= Authorization.MINLENGHT && !string.IsNullOrWhiteSpace(newPassword_TextBox.Text))
            {
                new SqlCommand($"update Users set Password = '{Cryptography.HashPassword(newPassword_TextBox.Text)}' where Id = {user.Id}", connection).ExecuteNonQuery();
                await Email.SendEmailAsync(email_textBox.Text, "Success", "Пароль успешно изменён!!!");
                label5.Enabled = false;
                newPassword_TextBox.Enabled = false;
                newPassword_CheckBox.Enabled = false;
                newPassword_TextBox.Text = "";
                newPassword_CheckBox.Checked = false;
                password_TextBox.Text = "";
                password_CheckBox.Checked = false;
                isUpdate = true;
            }
            else if(Cryptography.HashPassword(newPassword_TextBox.Text) == user.Password)
            {
                MessageBox.Show("Пароль не должен совпадать с предыдущим!!!");
            }else if(newPassword_TextBox.Enabled && newPassword_TextBox.Text.Length < Authorization.MINLENGHT && !string.IsNullOrWhiteSpace(newPassword_TextBox.Text))
            {
                MessageBox.Show($"Длина пароля должна быть больше {Authorization.MINLENGHT} символов!!!");
            }

            if (isUpdate)
            {
                MessageBox.Show("Данные успешно сохранены!!!");
                UpdateUser(user.Id);
            }
        }

        private void UpdateUser(int id)
        {
            SqlDataReader reader = new SqlCommand($"select * from Users where Id = {id}", connection).ExecuteReader();
            if (reader.Read())
            {
                user.Id = reader.GetInt32(0);
                user.Name = reader.GetString(1);
                user.Email = reader.GetString(2);
                user.Password = reader.GetString(3);
                user.Type = (UserType)Enum.Parse(typeof(UserType), reader.GetString(4));
            }

            reader.Close();
        }

        private void password_TextBox_TextChanged(object sender, EventArgs e)
        {
            if(Cryptography.HashPassword(password_TextBox.Text) == user.Password)
            {
                label5.Enabled = true;
                newPassword_TextBox.Enabled = true;
                newPassword_CheckBox.Enabled = true;
            }
        }

        private void password_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_CheckBox.Checked == true)
                password_TextBox.PasswordChar = '\0';
            else
                password_TextBox.PasswordChar = '●';
        }

        private void newPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (newPassword_CheckBox.Checked == true)
                newPassword_TextBox.PasswordChar = '\0';
            else
                newPassword_TextBox.PasswordChar = '●';
        }
    }
}

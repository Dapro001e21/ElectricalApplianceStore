using ElectricalApplianceStore.Services;
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
        public User user;
        public ProfileForm(User user)
        {
            InitializeComponent();
            this.user = user;
            name_TextBox.Text = user.Name;
            email_TextBox.Text = user.Email;
        }

        private async void save_Button_Click(object sender, EventArgs e)
        {
            if (await UserService.UpdateUserInfo(name_TextBox.Text, email_TextBox.Text, newPassword_TextBox.Text, user))
            {
                user = await UserService.GetUserAsync(user.Id);
                MessageBox.Show("Данные успешно сохранены!!!");
            }
            else
            {
                name_TextBox.Text = user.Name;
                email_TextBox.Text = user.Email;
            }

            if (Cryptography.HashPassword(password_TextBox.Text) != user.Password)
            {
                password_TextBox.Text = "";
                newPassword_TextBox.Text = "";
                label5.Enabled = false;
                newPassword_TextBox.Enabled = false;
                newPassword_CheckBox.Enabled = false;
                password_CheckBox.Checked = false;
                newPassword_CheckBox.Checked = false;
                password_TextBox.Enabled = true;
            }
        }

        private void password_TextBox_TextChanged(object sender, EventArgs e)
        {
            if(Cryptography.HashPassword(password_TextBox.Text) == user.Password)
            {
                label5.Enabled = true;
                newPassword_TextBox.Enabled = true;
                newPassword_CheckBox.Enabled = true;
                password_TextBox.Enabled = false;
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

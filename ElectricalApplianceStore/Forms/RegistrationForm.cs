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
    public partial class RegistrationForm : Form
    {
        public User user;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private async void registration_Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(name_TextBox.Text) || string.IsNullOrWhiteSpace(email_TextBox.Text) || string.IsNullOrWhiteSpace(password_TextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if(password_TextBox.Text != twoPassword_TextBox.Text)
            {
                MessageBox.Show("Пароли должны совпадать!!!");
                return;
            }

            user = await Authorization.Sign_UpAsync(name_TextBox.Text, email_TextBox.Text, password_TextBox.Text);
            if(user != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void password_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_CheckBox.Checked == true)
                password_TextBox.PasswordChar = '\0';
            else
                password_TextBox.PasswordChar = '●';
        }

        private void twoPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (twoPassword_CheckBox.Checked == true)
                twoPassword_TextBox.PasswordChar = '\0';
            else
                twoPassword_TextBox.PasswordChar = '●';
        }
    }
}

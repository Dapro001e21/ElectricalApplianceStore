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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            SqlDataBase.connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElectricalApplianceStore;Integrated Security=true;MultipleActiveResultSets=True;";
        }

        private async void Sign_In_Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(email_TextBox.Text) && string.IsNullOrWhiteSpace(password_TextBox.Text))
            {
                MessageBox.Show("Заполните все поля!!!");
                return;
            }

            User user = await Authorization.Sign_InAsync(email_TextBox.Text, password_TextBox.Text);
            if(user != null)
            {
                Authorization.SwitchingForm(user, this);
            }
        }

        private void Sign_Up_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            RegistrationForm form = new RegistrationForm();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                Visible = true;
            }else if(dialogResult == DialogResult.OK)
            {
                Authorization.SwitchingForm(form.user, this);
            }
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckBox.Checked == true)
                password_TextBox.PasswordChar = '\0';
            else
                password_TextBox.PasswordChar = '●';
        }

        private void resetPassword_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible = false;
            if(new ResetPasswordForm().ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }
    }
}

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
    public partial class ResetPasswordForm : Form
    {
        ResetPasswordService resetPasswordService;
        public ResetPasswordForm()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            resetPasswordService = new ResetPasswordService();
        }

        private async void resetPassword_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_TextBox.Text))
                return;
            if(await resetPasswordService.ResetPasswordAsync(email_TextBox.Text))
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            int enterCode;
            int.TryParse(code_TextBox.Text, out enterCode);
            if(resetPasswordService.ConfirmCode(enterCode))
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private async void save_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newPassword_TextBox.Text) || string.IsNullOrWhiteSpace(twoNewPassword_TextBox.Text))
                return;

            if(newPassword_TextBox.Text != twoNewPassword_TextBox.Text)
            {
                MessageBox.Show("Пароли должны совпадать!!!");
                return;
            }

            if (await resetPasswordService.ConfirmPasswordAsync(newPassword_TextBox.Text))
            {
                MessageBox.Show("Вы успешно сменили пароль!!!");
                await Email.SendEmailAsync(email_TextBox.Text, "Success", "Пароль успешно изменён!!!");
                Close();
            }
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

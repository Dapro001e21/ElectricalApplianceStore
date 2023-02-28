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
        SqlConnection connection;
        public User user;
        public RegistrationForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void registration_Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(name_TextBox.Text) || string.IsNullOrWhiteSpace(email_TextBox.Text) || string.IsNullOrWhiteSpace(password_TextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if(password_TextBox.Text.Length < Authorization.MINLENGHT)
            {
                MessageBox.Show($"Длина пароля должна быть больше {Authorization.MINLENGHT} символов!!!");
                return;
            }

            user = Authorization.Sign_Up(connection, name_TextBox.Text, email_TextBox.Text, password_TextBox.Text);
            if(user != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

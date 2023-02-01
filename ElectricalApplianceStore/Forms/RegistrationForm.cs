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

            User user = Authorization.Sign_Up(connection, name_TextBox.Text, email_TextBox.Text, password_TextBox.Text);
            new Form1(connection, user).Show();
        }
    }
}

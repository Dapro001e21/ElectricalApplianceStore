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
        SqlConnection connection;
        public AuthorizationForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElectricalApplianceStore;Integrated Security=true;MultipleActiveResultSets=True;");
            connection.Open();
        }

        private void Sign_In_Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(email_TextBox.Text) && string.IsNullOrWhiteSpace(password_TextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            User user = Authorization.Sign_In(connection, email_TextBox.Text, password_TextBox.Text);
            email_TextBox.Text = "";
            password_TextBox.Text = "";

            if(user != null)
            {
                Authorization.SwitchingForm(connection, user, this);
            }
            else
            {
                MessageBox.Show("Ошибка в логине или пароле!");
            }
        }

        private void Sign_Up_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            RegistrationForm form = new RegistrationForm(connection);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                Visible = true;
            }else if(dialogResult == DialogResult.OK)
            {
                Authorization.SwitchingForm(connection, form.user, this);
            }
        }
    }
}

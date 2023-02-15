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
    public partial class SelectiveForm : Form
    {
        SqlConnection connection;
        User user;
        bool isExit = true;

        public SelectiveForm(SqlConnection connection, User user)
        {
            InitializeComponent();
            this.connection = connection;
            this.user = user;
        }

        private void SelectiveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isExit)
                Application.Exit();
        }

        private void userForm_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            if(new UserForm(connection, user).ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }

        private void adminForm_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (new AdminForm(connection, user).ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }

        private void exitAccount_Button_Click(object sender, EventArgs e)
        {
            isExit = false;
            Close();
        }
    }
}

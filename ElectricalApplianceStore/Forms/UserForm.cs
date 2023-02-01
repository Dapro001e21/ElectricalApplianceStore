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
    public partial class UserForm : Form
    {
        SqlConnection connection;
        User user;
        bool isExit = true;

        public UserForm(SqlConnection connection, User user)
        {
            InitializeComponent();
            this.connection = connection;
            this.user = user;

            if (user.Type == UserType.Admin)
                exitAccount_Button.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (user.Type == UserType.User && isExit)
                Application.Exit();
        }

        private void exitAccount_Button_Click(object sender, EventArgs e)
        {
            isExit = false;
            Close();
        }
    }
}

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
        User user;
        bool isExit = true;

        public SelectiveForm(User user)
        {
            InitializeComponent();
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
            if(new UserForm(user).ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }

        private void adminForm_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (new AdminForm(user).ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }

        private void exitAccount_Button_Click(object sender, EventArgs e)
        {
            isExit = false;
            Close();
        }

        private void profileForm_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            ProfileForm form = new ProfileForm(user);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
                user = form.user;
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        User user;
        public Form1(SqlConnection connection, User user)
        {
            InitializeComponent();
            this.connection = connection;
            this.user = user;
        }
    }
}

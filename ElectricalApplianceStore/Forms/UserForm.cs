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
        List<ElectricalAppliance> electricalAppliances;

        public UserForm(SqlConnection connection, User user)
        {
            InitializeComponent();
            this.connection = connection;
            this.user = user;

            if (user.Type == UserType.Admin)
                exitAccount_Button.Visible = false;
            List<ElectricalApplianceType> electricalApplianceTypes = Enum.GetValues(typeof(ElectricalApplianceType)).Cast<ElectricalApplianceType>().ToList();
            electricalApplianceTypes.ForEach(type => type_ComboBox.Items.Add(type));
            electricalAppliances = new List<ElectricalAppliance>();
            ShowElectricalAppliances();
        }

        public void ShowElectricalAppliances()
        {
            electricalAppliances_ListBox.Items.Clear();
            electricalAppliances.Clear();
            SqlDataReader reader = new SqlCommand("select * from ElectricalAppliances", connection).ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                DateTime dateOfRelease = reader.GetDateTime(2);
                string supplier = reader.GetString(3);
                double price = reader.GetDouble(4);
                double weight = reader.GetDouble(5);
                int amount = reader.GetInt32(6);
                ElectricalApplianceType type = (ElectricalApplianceType)Enum.Parse(typeof(ElectricalApplianceType), reader.GetString(7));
                electricalAppliances.Add(new ElectricalAppliance(id, name, dateOfRelease, supplier, price, weight, amount, type));
            }
            reader.Close();
            electricalAppliances.ForEach(appliance => electricalAppliances_ListBox.Items.Add(appliance));
        }

        private void sort_Button_Click(object sender, EventArgs e)
        {
            if (sort_ComboBox.SelectedIndex == -1 || order_ComboBox.SelectedIndex == -1)
                return;
            ElectricalApplianceType type = (ElectricalApplianceType)type_ComboBox.SelectedItem;
            List<ElectricalAppliance> list = electricalAppliances_ListBox.Items.Cast<ElectricalAppliance>().ToList();
            switch (sort_ComboBox.SelectedIndex)
            {
                case 0:
                    if (order_ComboBox.SelectedIndex == 0)
                        list.Sort(ElectricalAppliance.SortAscDateOfRelease);
                    else
                        list.Sort(ElectricalAppliance.SortDescDateOfRelease);
                    break;
                case 1:
                    if (order_ComboBox.SelectedIndex == 0)
                        list.Sort(ElectricalAppliance.SortAscSupplier);
                    else
                        list.Sort(ElectricalAppliance.SortDescSupplier);
                    break;
                case 2:
                    if (order_ComboBox.SelectedIndex == 0)
                        list.Sort(ElectricalAppliance.SortAscWeight);
                    else
                        list.Sort(ElectricalAppliance.SortDescWeight);
                    break;
                case 3:
                    if (order_ComboBox.SelectedIndex == 0)
                        list.Sort(ElectricalAppliance.SortAscPrice);
                    else
                        list.Sort(ElectricalAppliance.SortDescPrice);
                    break;
                default:
                    break;
            }
            electricalAppliances_ListBox.Items.Clear();
            list.ForEach(appliance => electricalAppliances_ListBox.Items.Add(appliance));
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

        private void updateElectricalAppliance_Button_Click(object sender, EventArgs e)
        {
            ShowElectricalAppliances();
            type_ComboBox.SelectedIndex = -1;
            sort_ComboBox.SelectedIndex = -1;
            order_ComboBox.SelectedIndex = -1;
        }

        private void show_Button_Click(object sender, EventArgs e)
        {
            if (type_ComboBox.SelectedIndex == -1)
                return;
            ElectricalApplianceType type = (ElectricalApplianceType)type_ComboBox.SelectedItem;
            List<ElectricalAppliance> list = electricalAppliances.Where(appliance => appliance.Type == type).ToList();
            electricalAppliances_ListBox.Items.Clear();
            list.ForEach(appliance => electricalAppliances_ListBox.Items.Add(appliance));
        }

        private void buy_Button_Click(object sender, EventArgs e)
        {
            if (electricalAppliances_ListBox.SelectedIndex == -1)
                return;
            ElectricalAppliance appliance = (ElectricalAppliance)electricalAppliances_ListBox.SelectedItem;
            if(appliance.Amount > 0)
            {
                appliance.Amount--;
                new SqlCommand($"update ElectricalAppliances set Amount = {appliance.Amount} where Id = {appliance.Id}", connection).ExecuteNonQuery();
                ShowElectricalAppliances();
            }
            else
            {
                MessageBox.Show("Товар отсутствует в магазине!!!");
            }
        }
    }
}

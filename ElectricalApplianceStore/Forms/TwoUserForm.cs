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
    public partial class TwoUserForm : Form
    {
        SqlConnection connection;
        User user;
        bool isExit = true;

        public TwoUserForm(SqlConnection connection, User user)
        {
            InitializeComponent();
            this.connection = connection;
            this.user = user;

            label1.Text = "";
            SqlDataReader maxReader = new SqlCommand("select Type from ElectricalAppliances where Price = (select max(Price) from ElectricalAppliances)", connection).ExecuteReader();
            if(maxReader.Read())
            {
                label1.Text += $"Самый дорогой вид: {maxReader.GetString(0)}\n";
            }

            SqlDataReader minReader = new SqlCommand("select Type from ElectricalAppliances where Price = (select min(Price) from ElectricalAppliances)", connection).ExecuteReader();
            if (minReader.Read())
            {
                label1.Text += $"Самый дешевый вид: {minReader.GetString(0)}\n";
            }

            label1.Text += "Средняя стоимость по каждому виду:\n";
            SqlDataReader averageReader = new SqlCommand("select Type, (sum(Price) / count(Type)) as Average from ElectricalAppliances group by Type", connection).ExecuteReader();
            while (averageReader.Read())
            {
                label1.Text += $"{averageReader.GetString(0)} - {averageReader.GetDouble(1)}\n";
            }

            SqlDataReader popularReader = new SqlCommand("select top 1 Type, sum(Amount) as Sum from SellElectricalAppliances group by Type order by Sum desc", connection).ExecuteReader();
            if(popularReader.Read())
            {
                label1.Text += $"Самый популярный вид: {popularReader.GetString(0)}\n";
            }
        }

        private void leaveToUserForm_Button_Click(object sender, EventArgs e)
        {
            isExit = false;
            Close();
        }

        private void TwoUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
                DialogResult = DialogResult.OK;
        }

        private void findPrice_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(initial_TextBox.Text) || string.IsNullOrWhiteSpace(final_TextBox.Text))
                return;

            SqlDataReader reader = null;
            listBox1.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    int initialPrice, finalPrice;
                    int.TryParse(initial_TextBox.Text, out initialPrice);
                    int.TryParse(final_TextBox.Text, out finalPrice);

                    if (initialPrice == 0 || finalPrice == 0)
                    {
                        MessageBox.Show("Поля должны быть заполнены цифрами!!!");
                        return;
                    }

                    reader = new SqlCommand($"select * from ElectricalAppliances where Price > {initialPrice} and Price < {finalPrice}", connection).ExecuteReader();
                    listBox1.Items.AddRange(GetElectricalAppliance(reader).ToArray());
                    break;
                case 1:
                    int initialWeight, finalWeight;
                    int.TryParse(initial_TextBox.Text, out initialWeight);
                    int.TryParse(final_TextBox.Text, out finalWeight);

                    if (initialWeight == 0 || finalWeight == 0)
                    {
                        MessageBox.Show("Поля должны быть заполнены цифрами!!!");
                        return;
                    }

                    reader = new SqlCommand($"select * from ElectricalAppliances where Weight > {initialWeight} and Weight < {finalWeight}", connection).ExecuteReader();
                    listBox1.Items.AddRange(GetElectricalAppliance(reader).ToArray());
                    break;
                case 2:
                    DateTime initialDate;
                    DateTime finalDate;
                    DateTime.TryParse(initial_TextBox.Text, out initialDate);
                    DateTime.TryParse(final_TextBox.Text, out finalDate);

                    if (initialDate.ToShortDateString() == "01.01.0001" || finalDate.ToShortDateString() == "01.01.0001")
                    {
                        MessageBox.Show("Поля должны быть заполнены в формате dd.mm.yyyy!!!");
                        return;
                    }

                    reader = new SqlCommand($"select * from ElectricalAppliances where DateOfRelease > '{initialDate.ToShortDateString()}' and DateOfRelease < '{finalDate.ToShortDateString()}'", connection).ExecuteReader();
                    listBox1.Items.AddRange(GetElectricalAppliance(reader).ToArray());
                    break;
                case 3:
                    int initialAmount, finalAmount;
                    int.TryParse(initial_TextBox.Text, out initialAmount);
                    int.TryParse(final_TextBox.Text, out finalAmount);

                    if (initialAmount == 0 || finalAmount == 0)
                    {
                        MessageBox.Show("Поля должны быть заполнены цифрами!!!");
                        return;
                    }

                    reader = new SqlCommand($"select * from ElectricalAppliances where Amount > {initialAmount} and Amount < {finalAmount}", connection).ExecuteReader();
                    listBox1.Items.AddRange(GetElectricalAppliance(reader).ToArray());
                    break;
                default:
                    break;
            }
        }

        private IEnumerable<ElectricalAppliance> GetElectricalAppliance(SqlDataReader reader)
        {
            List<ElectricalAppliance> result = new List<ElectricalAppliance>();
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
                result.Add(new ElectricalAppliance(id, name, dateOfRelease, supplier, price, weight, amount, type));
            }
            return result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initial_TextBox.Text = "";
            final_TextBox.Text = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    initial_Label.Text = "Начальная стоимость:";
                    final_Label.Text = "Конечная стоимость:";
                    break;
                case 1:
                    initial_Label.Text = "Начальный вес:";
                    final_Label.Text = "Конечный вес:";
                    break;
                case 2:
                    initial_Label.Text = "Начальная дата:";
                    final_Label.Text = "Конечная дата:";
                    break;
                case 3:
                    initial_Label.Text = "Начальное количество:";
                    final_Label.Text = "Конечное количество:";
                    break;
                default:
                    break;
            }
        }
    }
}

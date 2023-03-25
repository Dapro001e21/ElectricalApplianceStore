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
    public partial class TwoUserForm : Form
    {
        User user;
        bool isExit = true;

        public TwoUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            type_ComboBox.Items.Add("All");
            type_ComboBox.Items.AddRange(Enum.GetNames(typeof(ElectricalApplianceType)).Cast<string>().ToArray());
            type_ComboBox.SelectedIndex = 0;
            search_ComboBox.SelectedIndex = 0;
            label1.Text = ElectricalApplianceService.GetInfoElectricalAppliances();
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

        private async void find_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(initial_TextBox.Text) || string.IsNullOrWhiteSpace(final_TextBox.Text))
                return;

            IEnumerable<ElectricalAppliance> electricalAppliances = null;
            listBox1.Items.Clear();
            switch (search_ComboBox.SelectedIndex)
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

                    electricalAppliances = (await ElectricalApplianceService.GetElectricalAppliancesAsync()).Where(x => x.Price >= initialPrice && x.Price <= finalPrice);
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

                    electricalAppliances = (await ElectricalApplianceService.GetElectricalAppliancesAsync()).Where(x => x.Weight >= initialWeight && x.Weight <= finalWeight);
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

                    electricalAppliances = (await ElectricalApplianceService.GetElectricalAppliancesAsync()).Where(x => x.DateOfRelease >= initialDate && x.DateOfRelease<= finalDate);
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

                    electricalAppliances = (await ElectricalApplianceService.GetElectricalAppliancesAsync()).Where(x => x.Amount >= initialAmount && x.Amount <= finalAmount);
                    break;
                default:
                    break;
            }
            if(type_ComboBox.SelectedIndex == 0)
            {
                listBox1.Items.AddRange(electricalAppliances.ToArray());
            }
            else
            {
                listBox1.Items.AddRange(electricalAppliances.Where(appliance => appliance.Type.ToString() == type_ComboBox.SelectedItem.ToString()).ToArray());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initial_TextBox.Text = "";
            final_TextBox.Text = "";
            switch (search_ComboBox.SelectedIndex)
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

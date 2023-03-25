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
    public partial class AdminForm : Form
    {
        User user;
        SqlDataAdapter userAdapter, electricalAppliancesAdapter, sellElectricalAppliancesAdapter;
        DataTable userTable, electricalAppliancesTable, sellElectricalAppliancesTable;

        public AdminForm(User user)
        {
            InitializeComponent();
            this.user = user;
            userTable = new DataTable();
            electricalAppliancesTable = new DataTable();
            sellElectricalAppliancesTable = new DataTable();
            comboBox1.SelectedIndex = 0;
            ShowTables();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Некоректный формат данных в столбце: {dataGridView1.Columns[e.ColumnIndex].Name}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                type_Label.Text = "Type:\n";
                List<string> typeName = null;
                dataGridView1.DataSource = null;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        typeName = Enum.GetNames(typeof(UserType)).Cast<string>().ToList();
                        for (int i = 0; i < typeName.Count; i++)
                        {
                            type_Label.Text += $"{i + 1}) {typeName[i]}\n";
                        }
                        dataGridView1.DataSource = userTable;
                        break;
                    case 1:
                        typeName = Enum.GetNames(typeof(ElectricalApplianceType)).Cast<string>().ToList();
                        for (int i = 0; i < typeName.Count; i++)
                        {
                            type_Label.Text += $"{i + 1}) {typeName[i]}\n";
                        }
                        dataGridView1.DataSource = electricalAppliancesTable;
                        break;
                    case 2:
                        typeName = Enum.GetNames(typeof(ElectricalApplianceType)).Cast<string>().ToList();
                        for (int i = 0; i < typeName.Count; i++)
                        {
                            type_Label.Text += $"{i + 1}) {typeName[i]}\n";
                        }
                        dataGridView1.DataSource = sellElectricalAppliancesTable;
                        break;
                    default:
                        break;
                }
                dataGridView1.Columns.Remove("Type");
                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.DataSource = typeName;
                comboBoxColumn.HeaderText = "Type";
                comboBoxColumn.DataPropertyName = "Type";
                dataGridView1.Columns.Add(comboBoxColumn);
                dataGridView1.Columns["Id"].ReadOnly = true;
            }
            catch (Exception) { }
        }

        private void ShowTables()
        {
            userTable.Rows.Clear();
            electricalAppliancesTable.Rows.Clear();
            sellElectricalAppliancesTable.Rows.Clear();

            userAdapter = new SqlDataAdapter("select * from Users", SqlDataBase.Instance());
            userAdapter.Fill(userTable);
            electricalAppliancesAdapter = new SqlDataAdapter("select * from ElectricalAppliances", SqlDataBase.Instance());
            electricalAppliancesAdapter.Fill(electricalAppliancesTable);
            sellElectricalAppliancesAdapter = new SqlDataAdapter("select * from SellElectricalAppliances", SqlDataBase.Instance());
            sellElectricalAppliancesAdapter.Fill(sellElectricalAppliancesTable);

            comboBox1_SelectedIndexChanged(this, null);
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            InitCommands();
            userAdapter.Update(userTable);
            electricalAppliancesAdapter.Update(electricalAppliancesTable);
            sellElectricalAppliancesAdapter.Update(sellElectricalAppliancesTable);
            ShowTables();
        }

        public void InitCommands()
        {
            //Insert Users
            SqlCommand insertCommandU = new SqlCommand("insert into Users values (@Name, @Email, @Password, @Type)", SqlDataBase.Instance());
            insertCommandU.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50));
            insertCommandU.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50));
            insertCommandU.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50));
            insertCommandU.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 30));

            insertCommandU.Parameters["@Name"].SourceVersion = DataRowVersion.Current;
            insertCommandU.Parameters["@Email"].SourceVersion = DataRowVersion.Current;
            insertCommandU.Parameters["@Password"].SourceVersion = DataRowVersion.Current;
            insertCommandU.Parameters["@Type"].SourceVersion = DataRowVersion.Current;

            insertCommandU.Parameters["@Name"].SourceColumn = "Name";
            insertCommandU.Parameters["@Email"].SourceColumn = "Email";
            insertCommandU.Parameters["@Password"].SourceColumn = "Password";
            insertCommandU.Parameters["@Type"].SourceColumn = "Type";

            //Update Users
            SqlCommand updateCommandU = new SqlCommand("update Users set Name = @Name, Email = @Email, Password = @Password, Type = @Type where Id = @Id", SqlDataBase.Instance());
            updateCommandU.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            updateCommandU.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50));
            updateCommandU.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50));
            updateCommandU.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50));
            updateCommandU.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 30));

            updateCommandU.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            updateCommandU.Parameters["@Name"].SourceVersion = DataRowVersion.Current;
            updateCommandU.Parameters["@Email"].SourceVersion = DataRowVersion.Current;
            updateCommandU.Parameters["@Password"].SourceVersion = DataRowVersion.Current;
            updateCommandU.Parameters["@Type"].SourceVersion = DataRowVersion.Current;

            updateCommandU.Parameters["@Id"].SourceColumn = "Id";
            updateCommandU.Parameters["@Name"].SourceColumn = "Name";
            updateCommandU.Parameters["@Email"].SourceColumn = "Email";
            updateCommandU.Parameters["@Password"].SourceColumn = "Password";
            updateCommandU.Parameters["@Type"].SourceColumn = "Type";

            //Delete Users
            SqlCommand deleteCommandU = new SqlCommand("delete from Users where Id = @Id", SqlDataBase.Instance());
            deleteCommandU.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            deleteCommandU.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            deleteCommandU.Parameters["@Id"].SourceColumn = "Id";

            userAdapter.InsertCommand = insertCommandU;
            userAdapter.UpdateCommand = updateCommandU;
            userAdapter.DeleteCommand = deleteCommandU;

            //Insert ElectricalAppliances
            SqlCommand insertCommandE = new SqlCommand("insert into ElectricalAppliances values (@Name, @DateOfRelease, @Supplier, @Price, @Weight, @Amount, @Type)", SqlDataBase.Instance());
            insertCommandE.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50));
            insertCommandE.Parameters.Add(new SqlParameter("@DateOfRelease", SqlDbType.Date));
            insertCommandE.Parameters.Add(new SqlParameter("@Supplier", SqlDbType.NVarChar, 50));
            insertCommandE.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float));
            insertCommandE.Parameters.Add(new SqlParameter("@Weight", SqlDbType.Float));
            insertCommandE.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
            insertCommandE.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 30));

            insertCommandE.Parameters["@Name"].SourceVersion = DataRowVersion.Current;
            insertCommandE.Parameters["@DateOfRelease"].SourceVersion = DataRowVersion.Current;
            insertCommandE.Parameters["@Supplier"].SourceVersion = DataRowVersion.Current;
            insertCommandE.Parameters["@Price"].SourceVersion = DataRowVersion.Current;
            insertCommandE.Parameters["@Weight"].SourceVersion = DataRowVersion.Current;
            insertCommandE.Parameters["@Amount"].SourceVersion = DataRowVersion.Current;
            insertCommandE.Parameters["@Type"].SourceVersion = DataRowVersion.Current;

            insertCommandE.Parameters["@Name"].SourceColumn = "Name";
            insertCommandE.Parameters["@DateOfRelease"].SourceColumn = "DateOfRelease";
            insertCommandE.Parameters["@Supplier"].SourceColumn = "Supplier";
            insertCommandE.Parameters["@Price"].SourceColumn = "Price";
            insertCommandE.Parameters["@Weight"].SourceColumn = "Weight";
            insertCommandE.Parameters["@Amount"].SourceColumn = "Amount";
            insertCommandE.Parameters["@Type"].SourceColumn = "Type";

            //Update ElectricalAppliances
            SqlCommand updateCommandE = new SqlCommand("update ElectricalAppliances set Name = @Name, DateOfRelease = @DateOfRelease, " +
                "Supplier = @Supplier, Price = @Price, Weight = @Weight, Amount = @Amount, Type = @Type where Id = @Id", SqlDataBase.Instance());
            updateCommandE.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            updateCommandE.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50));
            updateCommandE.Parameters.Add(new SqlParameter("@DateOfRelease", SqlDbType.Date));
            updateCommandE.Parameters.Add(new SqlParameter("@Supplier", SqlDbType.NVarChar, 50));
            updateCommandE.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float));
            updateCommandE.Parameters.Add(new SqlParameter("@Weight", SqlDbType.Float));
            updateCommandE.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
            updateCommandE.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 30));

            updateCommandE.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            updateCommandE.Parameters["@Name"].SourceVersion = DataRowVersion.Current;
            updateCommandE.Parameters["@DateOfRelease"].SourceVersion = DataRowVersion.Current;
            updateCommandE.Parameters["@Supplier"].SourceVersion = DataRowVersion.Current;
            updateCommandE.Parameters["@Price"].SourceVersion = DataRowVersion.Current;
            updateCommandE.Parameters["@Weight"].SourceVersion = DataRowVersion.Current;
            updateCommandE.Parameters["@Amount"].SourceVersion = DataRowVersion.Current;
            updateCommandE.Parameters["@Type"].SourceVersion = DataRowVersion.Current;

            updateCommandE.Parameters["@Id"].SourceColumn = "Id";
            updateCommandE.Parameters["@Name"].SourceColumn = "Name";
            updateCommandE.Parameters["@DateOfRelease"].SourceColumn = "DateOfRelease";
            updateCommandE.Parameters["@Supplier"].SourceColumn = "Supplier";
            updateCommandE.Parameters["@Price"].SourceColumn = "Price";
            updateCommandE.Parameters["@Weight"].SourceColumn = "Weight";
            updateCommandE.Parameters["@Amount"].SourceColumn = "Amount";
            updateCommandE.Parameters["@Type"].SourceColumn = "Type";

            //Delete ElectricalAppliances
            SqlCommand deleteCommandE = new SqlCommand("delete from ElectricalAppliances where Id = @Id", SqlDataBase.Instance());
            deleteCommandE.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            deleteCommandE.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            deleteCommandE.Parameters["@Id"].SourceColumn = "Id";

            electricalAppliancesAdapter.InsertCommand = insertCommandE;
            electricalAppliancesAdapter.UpdateCommand = updateCommandE;
            electricalAppliancesAdapter.DeleteCommand = deleteCommandE;

            //Insert SellElectricalAppliances
            SqlCommand insertCommandS = new SqlCommand("insert into SellElectricalAppliances values (@Name, @DateOfSale, @Price, @Amount, @User_FK, @Type)", SqlDataBase.Instance());
            insertCommandS.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50));
            insertCommandS.Parameters.Add(new SqlParameter("@DateOfSale", SqlDbType.Date));
            insertCommandS.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float, 50));
            insertCommandS.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
            insertCommandS.Parameters.Add(new SqlParameter("@User_FK", SqlDbType.Int));
            insertCommandS.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 30));

            insertCommandS.Parameters["@Name"].SourceVersion = DataRowVersion.Current;
            insertCommandS.Parameters["@DateOfSale"].SourceVersion = DataRowVersion.Current;
            insertCommandS.Parameters["@Price"].SourceVersion = DataRowVersion.Current;
            insertCommandS.Parameters["@Amount"].SourceVersion = DataRowVersion.Current;
            insertCommandS.Parameters["@User_FK"].SourceVersion = DataRowVersion.Current;
            insertCommandS.Parameters["@Type"].SourceVersion = DataRowVersion.Current;

            insertCommandS.Parameters["@Name"].SourceColumn = "Name";
            insertCommandS.Parameters["@DateOfSale"].SourceColumn = "DateOfSale";
            insertCommandS.Parameters["@Price"].SourceColumn = "Price";
            insertCommandS.Parameters["@Amount"].SourceColumn = "Amount";
            insertCommandS.Parameters["@User_FK"].SourceColumn = "User_FK";
            insertCommandS.Parameters["@Type"].SourceColumn = "Type";

            //Update SellElectricalAppliances
            SqlCommand updateCommandS = new SqlCommand("update SellElectricalAppliances set Name = @Name, DateOfSale = @DateOfSale, " +
                "Price = @Price, Amount = @Amount, set User_FK = @User_FK, Type = @Type where Id = @Id", SqlDataBase.Instance());
            updateCommandS.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            updateCommandS.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50));
            updateCommandS.Parameters.Add(new SqlParameter("@DateOfSale", SqlDbType.Date));
            updateCommandS.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float));
            updateCommandS.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
            updateCommandS.Parameters.Add(new SqlParameter("@User_FK", SqlDbType.Int));
            updateCommandS.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 30));

            updateCommandS.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            updateCommandS.Parameters["@Name"].SourceVersion = DataRowVersion.Current;
            updateCommandS.Parameters["@DateOfSale"].SourceVersion = DataRowVersion.Current;
            updateCommandS.Parameters["@Price"].SourceVersion = DataRowVersion.Current;
            updateCommandS.Parameters["@Amount"].SourceVersion = DataRowVersion.Current;
            updateCommandS.Parameters["@User_FK"].SourceVersion = DataRowVersion.Current;
            updateCommandS.Parameters["@Type"].SourceVersion = DataRowVersion.Current;

            updateCommandS.Parameters["@Id"].SourceColumn = "Id";
            updateCommandS.Parameters["@Name"].SourceColumn = "Name";
            updateCommandS.Parameters["@DateOfSale"].SourceColumn = "DateOfSale";
            updateCommandS.Parameters["@Price"].SourceColumn = "Price";
            updateCommandS.Parameters["@Amount"].SourceColumn = "Amount";
            updateCommandS.Parameters["@User_FK"].SourceColumn = "User_FK";
            updateCommandS.Parameters["@Type"].SourceColumn = "Type";

            //Delete SellElectricalAppliances
            SqlCommand deleteCommandS = new SqlCommand("delete from SellElectricalAppliances where Id = @Id", SqlDataBase.Instance());
            deleteCommandS.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            deleteCommandS.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            deleteCommandS.Parameters["@Id"].SourceColumn = "Id";

            sellElectricalAppliancesAdapter.InsertCommand = insertCommandS;
            sellElectricalAppliancesAdapter.UpdateCommand = updateCommandS;
            sellElectricalAppliancesAdapter.DeleteCommand = deleteCommandS;
        }
    }
}

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
        SqlConnection connection;
        User user;
        SqlDataAdapter userAdapter, electricalAppliancesAdapter;
        DataTable userTable, electricalAppliancesTable;

        public AdminForm(SqlConnection connection, User user)
        {
            InitializeComponent();
            this.connection = connection;
            this.user = user;
            userTable = new DataTable();
            electricalAppliancesTable = new DataTable();
            comboBox1.SelectedIndex = 0;
            ShowTables();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type_Label.Text = "Type:\n";
            List<string> typeName = null;
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
                default:
                    break;
            }
        }

        private void ShowTables()
        {
            userTable.Rows.Clear();
            electricalAppliancesTable.Rows.Clear();

            userAdapter = new SqlDataAdapter("select Id, Name, Email, Password, Type from Users", connection);
            userAdapter.Fill(userTable);
            electricalAppliancesAdapter = new SqlDataAdapter("select Id, Name, DateOfRelease, Supplier, Price, Weight, Amount, Type from ElectricalAppliances", connection);
            electricalAppliancesAdapter.Fill(electricalAppliancesTable);

            comboBox1_SelectedIndexChanged(this, null);
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            InitCommands();
            userAdapter.Update(userTable);
            electricalAppliancesAdapter.Update(electricalAppliancesTable);
            ShowTables();
        }

        public void InitCommands()
        {
            //Insert Users
            SqlCommand insertCommandU = new SqlCommand("insert into Users values (@Name, @Email, @Password, @Type)", connection);
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
            SqlCommand updateCommandU = new SqlCommand("update Users set Name = @Name, Email = @Email, Password = @Password, Type = @Type where Id = @Id", connection);
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
            SqlCommand deleteCommandU = new SqlCommand("delete from Users where Id = @Id", connection);
            deleteCommandU.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            deleteCommandU.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            deleteCommandU.Parameters["@Id"].SourceColumn = "Id";

            userAdapter.InsertCommand = insertCommandU;
            userAdapter.UpdateCommand = updateCommandU;
            userAdapter.DeleteCommand = deleteCommandU;

            //Insert ElectricalAppliances
            SqlCommand insertCommandE = new SqlCommand("insert into ElectricalAppliances values (@Name, @DateOfRelease, @Supplier, @Price, @Weight, @Amount, @Type)", connection);
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
                "Supplier = @Supplier, Price = @Price, Weight = @Weight, Amount = @Amount, Type = @Type where Id = @Id", connection);
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
            SqlCommand deleteCommandE = new SqlCommand("delete from ElectricalAppliances where Id = @Id", connection);
            deleteCommandE.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            deleteCommandE.Parameters["@Id"].SourceVersion = DataRowVersion.Original;
            deleteCommandE.Parameters["@Id"].SourceColumn = "Id";

            electricalAppliancesAdapter.InsertCommand = insertCommandE;
            electricalAppliancesAdapter.UpdateCommand = updateCommandE;
            electricalAppliancesAdapter.DeleteCommand = deleteCommandE;
        }
    }
}

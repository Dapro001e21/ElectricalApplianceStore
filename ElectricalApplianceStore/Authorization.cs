using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalApplianceStore
{
    public class Authorization
    {
        public static User Sign_In(SqlConnection connection, string email, string password)
        {
            SqlCommand selectCommand = new SqlCommand($"select * from Users where Users.Email='{email}' and Users.Password='{password}'", connection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            if(reader.Read())
            {
                int Id = reader.GetInt32(0);
                string Name = reader.GetString(1);
                string Email = reader.GetString(2);
                string Password = reader.GetString(3);
                UserType Type = (UserType)Enum.Parse(typeof(UserType), reader.GetString(4));
                reader.Close();
                return new User(Id, Name, Email, Password, Type);
            }

            reader.Close();
            return null;
        }

        public static User Sign_Up(SqlConnection connection, string name, string email, string password)
        {
            SqlCommand insertCommand = new SqlCommand($"insert into Users values ('{name}', '{email}', '{password}', '{UserType.User}')", connection);
            insertCommand.ExecuteNonQuery();

            return Sign_In(connection, email, password);
        }

        public static void SwitchingForm(SqlConnection connection, User user, Form parentForm)
        {
            parentForm.Visible = false;
            Form form = new Form();
            switch (user.Type)
            {
                case UserType.User:
                    form = new UserForm(connection, user);
                    break;
                case UserType.Admin:
                    form = new SelectiveForm(connection, user);
                    break;
                default:
                    break;
            }

            if(form.ShowDialog() == DialogResult.Cancel)
            {
                parentForm.Visible = true;
            }
        }
    }
}

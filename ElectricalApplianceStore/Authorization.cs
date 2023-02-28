﻿using System;
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
        public const int MINLENGHT = 5;
        public static User Sign_In(SqlConnection connection, string email, string password)
        {
            SqlDataReader reader = new SqlCommand($"select * from Users where Users.Email='{email}' and Users.Password='{Cryptography.HashPassword(password)}'", connection).ExecuteReader();
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
            MessageBox.Show("Ошибка в логине или пароле!!!");
            return null;
        }

        public static User Sign_Up(SqlConnection connection, string name, string email, string password)
        {
            SqlDataReader checkEmailReader = new SqlCommand($"select * from Users where Email = '{email}'", connection).ExecuteReader();
            if (!checkEmailReader.Read())
            {
                new SqlCommand($"insert into Users values ('{name}', '{email}', '{Cryptography.HashPassword(password)}', '{UserType.User}')", connection).ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Пользователь с таким email уже существует!!!");
                return null;
            }

            MessageBox.Show("Вы успешно зарегестрировались!!!");
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

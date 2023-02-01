using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalApplianceStore
{
    public enum UserType
    {
        User,
        Admin
    }

    public class User
    {
        public int Id;
        public string Name;
        public string Email;
        public string Password;
        public UserType Type;

        public User(int id, string name, string email, string password, UserType type)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Type = type;
        }
    }
}

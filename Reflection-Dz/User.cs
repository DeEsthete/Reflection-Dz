using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Dz
{
    public class User
    {
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public User(string fullName, string login, string password)
        {
            FullName = fullName;
            Login = login;
            Password = password;
        }
        public User()
        {
            //
        }
    }
}

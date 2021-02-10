using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class User
    {
        public string name { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public User(string _UserName, string _UserPassword)
        {
            this.UserName = _UserName;
            this.UserPassword = _UserPassword;
        }
        public User()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class User
    {
        public string name { get; set; }
        public string UserName { get; set; }
        public User(string _UserName)
        {
            this.UserName = _UserName;
        }
        public User()
        {

        }
    }
}

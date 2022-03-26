using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class User
    {
        public int idUser { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string status { get; set; }

        public User(int idUser, string userName, string address, string password, string status)
        {
            this.idUser = idUser;
            this.name = userName;
            this.address = address;
            this.password = password;
            this.status = status;
        }

       
    }
}

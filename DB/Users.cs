using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.DB
{
    public class Users
    {
        public Users(string name, string password)
        {
            Name = name;
            this.password = password;
        }

        [Key]
        public int IDuser { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
        public string NameUser { get; set; }
        public string LastName { get; set; }
    }
}

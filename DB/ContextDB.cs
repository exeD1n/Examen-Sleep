using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.DB
{
    public class ContextDB : DbContext
    {
        public string path = "server = 192.168.10.134; database = Lutii228; user id = stud; password = stud;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(path);
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Users> users { get; set; }
    }
}

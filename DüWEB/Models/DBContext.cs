using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DüWEB.Models
{
    public class DBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\Gokhan;database=WebDb; integrated security=true;");
        }
    
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Staff> Staffs { get; set; }
       public DbSet<Senate> Senates { get; set; }
    }
}

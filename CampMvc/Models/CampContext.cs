using CampMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagerMVC.Models
{
    public class CampContext : DbContext
    {
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public CampContext(DbContextOptions<CampContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";

            string adminEmail = "admin@gmail.com";
            string adminPassword = "123456";

            Role adminRole = new Role { RoleId = 1, Name = adminRoleName };
            User adminUser = new User { UserId = 1, Email = adminEmail, Password = adminPassword, RoleId = adminRole.RoleId };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}

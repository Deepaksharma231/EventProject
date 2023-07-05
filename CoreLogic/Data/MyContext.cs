using CoreLogic.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Data
{
    public class MyContext:DbContext   
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BookEvent> BookEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var server = "(localdb)";
            var instance = "mssqllocaldb";
            var database = "BookEventDB";
            var authentication = "Integrated Security = true";

            var conString = $"Data Source={server}\\{instance}; Initial Catalog={database};{authentication}";

            options.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() 
                { 
                    Id = 1, FirstName = "saheb", LastName = "kumar",Email="saheb123@gmail.com"
                }, 
                new User()
                {
                    Id =2,
                    FirstName = "deepak",
                    LastName = "kumar",
                    Email="deepak123@gmail.com"
                }
             );


            modelBuilder.Entity<BookEvent>().HasData
                (
                new BookEvent() { Id = 1, UserId = 1, BookingDate = new DateTime(2023, 8, 4), EventType = "Birthday" },
                new BookEvent() { Id = 2, UserId = 1, BookingDate = new DateTime(2023, 8, 1), EventType = "Anniversary" }
                );
        }
    }
}

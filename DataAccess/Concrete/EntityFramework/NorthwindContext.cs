using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak
    internal class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); 
            //baştaki @'i  \'ı kullanmak için kullaanıyoruz
            //optionsBuilder.UseSqlServer(@"Server=175.45.2.12")

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categoies { get; set; }
        public DbSet<Customer> Customers { get; set; }



    }
}

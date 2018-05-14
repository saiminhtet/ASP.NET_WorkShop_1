using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FoodStall.DAL
{
    public class FoodStallDBContext : DbContext
    {
        public FoodStallDBContext() : base("FoodStall")
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
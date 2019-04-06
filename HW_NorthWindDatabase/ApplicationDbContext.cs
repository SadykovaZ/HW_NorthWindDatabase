using HW_NorthWindDatabase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class ApplicationDbContext: DbContext
    {
        static readonly string connection = ConfigurationManager.ConnectionStrings["NorthWindDatabase"].ConnectionString;
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<EmployeeTerritorie> EmpTer { get; set; }
        public DbSet<CustomerCustomerDemo> DemoC { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new CustomerCustomerDemoConfiguraton());
            modelBuilder.Configurations.Add(new CustomerDemographicConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new RegionConfiguration());
            modelBuilder.Configurations.Add(new ShipperConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new TerritoryConfiguration());
            modelBuilder.Configurations.Add(new EmployeeTerritoryConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext():base(connection)
        {
            
        }

    }
}

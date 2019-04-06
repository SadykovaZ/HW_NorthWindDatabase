using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
    }
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(p => p.CustomerID);
            HasMany(p => p.Orders).WithRequired().HasForeignKey(p=>p.CustomerId);
            HasMany(p => p.CustomerCustomerDemo).WithRequired().HasForeignKey(p => p.CustomerID);
           

        }
    }
}

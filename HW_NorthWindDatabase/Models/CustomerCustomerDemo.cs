using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class CustomerCustomerDemo
    {
        public string CustomerID { get; set; }
        public string CustomerTypeID { get; set; }
        //public Customer Cust { get; set; }
        //public CustomerDemographic Demo { get; set; }
    }

    public class CustomerCustomerDemoConfiguraton: EntityTypeConfiguration<CustomerCustomerDemo>
    {
        public CustomerCustomerDemoConfiguraton()
        {
            HasKey(p => new
            {
                p.CustomerID,
                p.CustomerTypeID
            });           
           
        }

    }
}

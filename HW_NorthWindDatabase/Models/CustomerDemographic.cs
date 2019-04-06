using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class CustomerDemographic
    {
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }

    }
    public class CustomerDemographicConfiguration:EntityTypeConfiguration<CustomerDemographic>
    {
        public CustomerDemographicConfiguration()
        {
            HasKey(p => p.CustomerTypeID);
            HasMany(p => p.CustomerCustomerDemo).WithRequired().HasForeignKey(p => p.CustomerTypeID);

        }

    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }

    public class ShipperConfiguration : EntityTypeConfiguration<Shipper>
    {
        public ShipperConfiguration()
        {
            HasKey(p => p.ShipperID);

            HasMany(p => p.Orders).WithRequired().HasForeignKey(p => p.ShipVia);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territory> Territories { get; set; }

    }

    public class RegionConfiguration: EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
        {
            HasKey(p => p.RegionID);
            HasMany(p => p.Territories).WithRequired().HasForeignKey(p => p.RegionID);
        }

    }
}

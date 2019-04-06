using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class Territory
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        //public Region Regions { get; set; }
        public virtual ICollection<EmployeeTerritorie> EmpTer { get; set; }

    }
    public class TerritoryConfiguration: EntityTypeConfiguration<Territory>
    {
        public TerritoryConfiguration()
        {
            HasKey(p => p.TerritoryID);
            HasMany(p => p.EmpTer).WithRequired().HasForeignKey(p => p.TerritoryID);
        }
    }
}

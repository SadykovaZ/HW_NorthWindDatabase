using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class EmployeeTerritorie
    {
        public int EmployeeID { get; set; }
        public string TerritoryID { get; set; }
        public Employee Emp { get; set; }
        //public Territory Terr { get; set; }
    }

    public class EmployeeTerritoryConfiguration: EntityTypeConfiguration<EmployeeTerritorie>
    {

        public EmployeeTerritoryConfiguration()
        {
            HasKey(p => new
            {
                p.EmployeeID,
                p.TerritoryID
            });
            //Property(p => p.EmployeeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //Property(p => p.TerritoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    public class Categorie
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }

    public class CategoryConfiguration : EntityTypeConfiguration<Categorie>
    {
        public CategoryConfiguration()
        {
            HasKey(p => p.CategoryId);
            HasMany(p => p.Products).WithRequired().HasForeignKey(p => p.CategoryId);
            Property(p => p.Picture).HasColumnType("image");
        }
    }
}

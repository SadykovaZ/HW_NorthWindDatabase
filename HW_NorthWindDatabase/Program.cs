using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NorthWindDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.CreateIfNotExists();
        }
    }
}

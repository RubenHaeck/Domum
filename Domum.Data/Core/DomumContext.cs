using System;
using System.Collections.Generic;using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domum.Data.Domain;

namespace Domum.Data.Core
{
    public class DomumContext : DbContext
    {
        public DomumContext()
            : base("name=Domum.LocalDatabase")
        {
            
        }
        public DbSet<Configuration> Configurations { get; set; }
    }
}

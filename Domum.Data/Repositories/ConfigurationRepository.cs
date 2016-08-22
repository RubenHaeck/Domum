using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domum.Data.Core;
using Domum.Data.Domain;

namespace Domum.Data.Repositories
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        public Configuration GetConfigurationById(int id)
        {
            // Nog ff wachten met Ioc container
            using (DomumContext context = new DomumContext())
            {
                return context.Configurations.SingleOrDefault(c => c.ConfigID == id);
            }
        }

        public void SaveOrUpdate(Configuration configuration)
        {
            using (DomumContext context = new DomumContext())
            {
                context.Configurations.Add(configuration);
                context.SaveChanges();
            }
        }
    }
}

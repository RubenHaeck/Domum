using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domum.Data.Core;
using Domum.Data.Domain;

namespace Domum.Data.Initializers
{
    public class DomumDBInitializer : DropCreateDatabaseAlways<DomumContext>
    {
        protected override void Seed(DomumContext context)
        {
            var defaultConfiguration = new Configuration();
            defaultConfiguration.ConfigID = 1;
            defaultConfiguration.ConfigKey = "HOSTNAME";
            defaultConfiguration.ConfigValue = Environment.MachineName;

            context.Configurations.Add(defaultConfiguration);

            base.Seed(context);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domum.Data.Domain;

namespace Domum.Data.Repositories
{
    public interface IConfigurationRepository
    {
        Configuration GetConfigurationById(int id);

        void SaveOrUpdate(Configuration configuration);
    }
}

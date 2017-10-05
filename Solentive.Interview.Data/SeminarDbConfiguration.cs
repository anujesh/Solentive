using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data
{
    public class SeminarDbConfiguration : DbConfiguration
    {
        public SeminarDbConfiguration()
        {
            // Set default provider
            SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }
    }
}

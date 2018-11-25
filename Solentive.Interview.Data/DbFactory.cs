using Solentive.Interview.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data
{
    public class DbFactory : Disposable, IDbFactory
    {
        SeminarDbContext dbContext;

        public SeminarDbContext Init()
        {
            return dbContext ?? (dbContext = new SeminarDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data.Interfaces
{
    public interface IDbFactory : IDisposable
    {
        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        SeminarDbContext Init();
    }
}

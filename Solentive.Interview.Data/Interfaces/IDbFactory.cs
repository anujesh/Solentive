using System;

namespace Solentive.Interview.Data.Interfaces
{
    public interface IDbFactory : IDisposable
    {
        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        SeminarDbContext Init();
    }
}

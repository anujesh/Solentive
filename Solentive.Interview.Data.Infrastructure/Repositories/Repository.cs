using Solentive.Interview.Data.Infrastructure.Repositories.Interfaces;
using Solentive.Interview.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private SeminarDbContext dataContext;       
       // protected readonly IDbContext _context;
        protected readonly IDbSet<TEntity> dbSet;
        protected IDbFactory DbFactory
        {
            get;
            private set;
        }
        protected SeminarDbContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        protected Repository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public virtual TEntity Get(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

    }
}

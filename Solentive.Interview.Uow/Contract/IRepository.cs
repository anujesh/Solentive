using Solentive.Interview.Model.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Uow.Contract
{
    public interface IRepository<T> where T : class, IEntity 
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Add(T entity);

        void Add(IEnumerable<T> entities);

        void Update(T entity);

        void Update(IEnumerable<T> entities);

        void Delete(IEnumerable<T> entities);

        void Delete(T entity);

        void Delete(int id);

        void EagerLoad(params Expression<Func<T, object>>[] eagerLoadList);

        void FullEagerLoad();
    }
}

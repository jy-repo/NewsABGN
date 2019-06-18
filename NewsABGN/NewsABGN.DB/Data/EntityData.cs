using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    public class EntityData<T> where T : Entity
    {
        public List<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                IQueryable<T> query = context.Set<T>();

                if (predicate != null)
                    query = query.Where(predicate);

                return query.ToList();
            }
        }

        public void Insert(T entity)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                context.Set<T>().Add(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                return context.Set<T>().Count(predicate);
            }
        }
    }
}

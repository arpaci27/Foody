using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly FoodyContext _foodyContext;

        public GenericRepository(FoodyContext foodyContext)
        {
            _foodyContext = foodyContext;
        }

        public void Delete(int id)
        {
            var value = _foodyContext.Set<T>().Find(id);
            _foodyContext.Remove(value);
            _foodyContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _foodyContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _foodyContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _foodyContext.Add(entity);
            _foodyContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _foodyContext.Update(entity);
            _foodyContext.SaveChanges();
        }

        
    }
}

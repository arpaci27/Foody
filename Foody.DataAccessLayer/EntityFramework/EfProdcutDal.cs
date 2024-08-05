using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfProdcutDal: GenericRepository<Product>, IProductDal
    {
       private readonly FoodyContext _context;

        public EfProdcutDal(FoodyContext foodyContext) : base(foodyContext)
        {
            _context = foodyContext;
        }

        public List<Product> ProductListWithCateory()
        {
            var values = _context.Products.Include(x=>x.Category).ToList();
            return values;
        }
    }
}

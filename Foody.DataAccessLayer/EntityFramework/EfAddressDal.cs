﻿using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfAddressDal : GenericRepository<Address>, IAddressDal
    {
        public EfAddressDal(FoodyContext foodyContext) : base(foodyContext)
        {
        }
    }
}

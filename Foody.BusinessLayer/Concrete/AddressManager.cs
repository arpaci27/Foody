using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public Address TGetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public void TDelete(int id)
        {_addressDal.Delete(id);
        }

        public List<Address> TGetAll()
        {
            return _addressDal.GetAll();
        }

        public void TInsert(Address entity)
        {
            _addressDal.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
           _addressDal.Update(entity);
        }
    }
}

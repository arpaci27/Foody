using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Address
    {
        public int AddressID { get; set; }
        public string AddresDetail { get; set; }
        public string PhoneNumber { get; set; }
         public string Email { get; set; }
        public string Description { get; set; }
    }
}

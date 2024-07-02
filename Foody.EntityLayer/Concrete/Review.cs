using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }
            
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}

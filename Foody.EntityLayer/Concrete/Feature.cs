using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string Title { get; set; }   
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}

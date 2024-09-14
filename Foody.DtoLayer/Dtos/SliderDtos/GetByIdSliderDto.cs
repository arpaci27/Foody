using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DtoLayer.Dtos.SliderDtos
{
    public class GetByIdSliderDto
    {
        public int SliderID { get; set; }
        public string SliderTitle { get; set; }
        public string SliderImageUrl { get; set; }
    }
}

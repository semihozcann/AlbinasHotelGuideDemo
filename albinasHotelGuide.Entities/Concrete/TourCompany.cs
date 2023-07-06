using albinasHotelGuide.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.Entities.Concrete
{
    public class TourCompany : BaseEntity
    {
        public string Name { get; set; }

        public List<Tour> Tours { get; set; }

    }
}

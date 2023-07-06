using albinasHotelGuide.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.Entities.Concrete
{
    public class TourPlaceContent : BaseEntity
    {
        public int TourId { get; set; }
        public int PlaceContentId { get; set; }


        public Tour Tour { get; set; }
        public PlaceContent PlaceContent { get; set; }

    }
}

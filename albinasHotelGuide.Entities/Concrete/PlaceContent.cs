using albinasHotelGuide.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.Entities.Concrete
{
    public class PlaceContent : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string SmallDescription { get; set; }

        public List<TourPlaceContent> TourPlaceContents { get; set; }



    }
}

using albinasHotelGuide.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.Entities.Concrete
{
    public class Tour : BaseEntity
    {
        public int TourCompanyId { get; set; }
        public string Name { get; set; }
        public int TourCode { get; set; }
        public string PickUpTime { get; set; }
        public string TourStartTime { get; set; }
        public string TotalTourTime { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string ImageUrl { get; set; }
        public bool Favorite { get; set; } = false;
        public bool IncludePickUpService { get; set; }
        public bool IncludeDropOffService { get; set; }
        public bool IncludeBreakfast { get; set; }
        public bool IncludeCoffeAndTea { get; set; }
        public bool IncludeFreeWifi { get; set; }


        public TourCompany TourCompany { get; set; }
        public List<TourPlaceContent> TourPlaceContents { get; set; }


    }
}

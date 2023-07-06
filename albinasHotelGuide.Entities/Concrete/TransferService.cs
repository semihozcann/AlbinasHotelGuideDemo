using albinasHotelGuide.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.Entities.Concrete
{
    public class TransferService : BaseEntity
    {
        public string TransferServiceCode { get; set; }
        public string PickUpPlace { get; set; }
        public string DropOffPlace { get; set; }
        public string MinimumPeople { get; set; }
        public string MaximumPeople { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string ImageUrlOne { get; set; }
        public string ImageUrlTwo { get; set; }
        public string ImageUrlThree { get; set;}
        public bool IncludeFreeWifi { get; set; }


    }
}

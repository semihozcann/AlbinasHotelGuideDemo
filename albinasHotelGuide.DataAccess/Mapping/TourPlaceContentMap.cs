using albinasHotelGuide.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.DataAccess.Mapping
{
    public class TourPlaceContentMap : IEntityTypeConfiguration<TourPlaceContent>
    {
        public void Configure(EntityTypeBuilder<TourPlaceContent> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.PlaceContentId);
            builder.Property(t => t.TourId);

            builder.ToTable("TourPlaceContents");
        }
    }
}

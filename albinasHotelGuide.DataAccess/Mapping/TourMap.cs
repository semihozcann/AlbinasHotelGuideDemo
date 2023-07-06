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
    public class TourMap : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.TourCompanyId);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(150);
            builder.Property(t => t.TourCode).IsRequired();
            builder.Property(t => t.TourCode).HasMaxLength(10);
            builder.Property(t => t.PickUpTime).HasMaxLength(10);
            builder.Property(t => t.TourStartTime).HasMaxLength(10);
            builder.Property(t => t.TotalTourTime).HasMaxLength(10);
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.Discount);
            builder.Property(t => t.ImageUrl);
            builder.Property(t => t.Favorite);
            builder.Property(t => t.IncludePickUpService);
            builder.Property(t => t.IncludeDropOffService);
            builder.Property(t => t.IncludeBreakfast);
            builder.Property(t => t.IncludeCoffeAndTea);
            builder.Property(t => t.IncludeFreeWifi);

            builder.ToTable("Tours");
        }
    }
}

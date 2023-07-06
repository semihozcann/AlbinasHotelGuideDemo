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
    public class PlaceContentMap : IEntityTypeConfiguration<PlaceContent>
    {
        public void Configure(EntityTypeBuilder<PlaceContent> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.SmallDescription).IsRequired();
            builder.Property(p => p.SmallDescription).HasMaxLength(150);
            builder.Property(p => p.ImageUrl);

            builder.ToTable("PlaceContents");
        }
    }
}

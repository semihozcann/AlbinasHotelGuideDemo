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
    public class TransferServiceMap : IEntityTypeConfiguration<TransferService>
    {
        public void Configure(EntityTypeBuilder<TransferService> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.TransferServiceCode).IsRequired();
            builder.Property(t => t.TransferServiceCode).HasMaxLength(10);
            builder.Property(t => t.PickUpPlace).IsRequired();
            builder.Property(t => t.PickUpPlace).HasMaxLength(100);
            builder.Property(t => t.DropOffPlace).IsRequired();
            builder.Property(t => t.DropOffPlace).HasMaxLength(100);
            builder.Property(t => t.MinimumPeople).IsRequired();
            builder.Property(t => t.MinimumPeople).HasMaxLength(2);
            builder.Property(t => t.MaximumPeople).IsRequired();
            builder.Property(t => t.MaximumPeople).HasMaxLength(2);
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.Discount);
            builder.Property(t => t.ImageUrlOne);
            builder.Property(t => t.ImageUrlTwo);
            builder.Property(t => t.ImageUrlThree);
            builder.Property(t => t.IncludeFreeWifi);

            builder.ToTable("TransferServices");
        }
    }
}

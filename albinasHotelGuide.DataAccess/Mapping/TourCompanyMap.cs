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
    public class TourCompanyMap : IEntityTypeConfiguration<TourCompany>
    {
        public void Configure(EntityTypeBuilder<TourCompany> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(150);

            builder.ToTable("TourCompanies");
        }
    }
}

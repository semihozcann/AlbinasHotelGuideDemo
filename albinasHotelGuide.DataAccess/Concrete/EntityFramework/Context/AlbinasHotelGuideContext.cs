using albinasHotelGuide.DataAccess.Mapping;
using albinasHotelGuide.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.DataAccess.Concrete.EntityFramework.Context
{
    public class AlbinasHotelGuideContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {


        public AlbinasHotelGuideContext()
        {

        }

        //configuration from settings
        public AlbinasHotelGuideContext(DbContextOptions<AlbinasHotelGuideContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=AlbinasHotelGuideDb;Trusted_Connection=true");

            }
            base.OnConfiguring(optionsBuilder);



        }

        //db kurallarını burada db olusturken veriyoruz. 
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new UserTokenMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserClaimMap());




        }

    }
}

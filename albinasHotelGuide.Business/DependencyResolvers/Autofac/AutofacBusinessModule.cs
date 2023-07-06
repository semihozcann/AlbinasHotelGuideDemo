using albinasHotelGuide.DataAccess.Concrete.EntityFramework.Context;
using Autofac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albinasHotelGuide.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<AlbinasHotelGuideContext>().As<DbContext>().SingleInstance();



        }
    }
}

using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* <assemblyIdentity name="Microsoft.VisualStudio.Shell.Design" publicKeyToken="b03f5f7f11d50a3a" culture="neutral"/>
                < bindingRedirect oldVersion = "2.0.0.0-17.0.0.0" newVersion = "17.0.0.0" />
*/

namespace DataLayer
{
    public class ResortDbContext : DbContext
    {
        public ResortDbContext() : base("ResortDb")
        {
        }


        public DbSet<Client> Clients { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<BarOrder> BarOrders { get; set; }
        public DbSet<SpaSession> SpaSessions { get; set; }
        public DbSet<RestaurantOrder> RestaurantOrders { get; set; }
    }
}

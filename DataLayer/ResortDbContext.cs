using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ResortDbContext : DbContext
    {
        public ResortDbContext() : base("localhost\\SQLEXPRESS")
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<BarOrder> BarOrders { get; set; }
        public DbSet<SpaSession> SpaSessions { get; set; }
        public DbSet<RestaurantOrder> RestaurantOrders { get; set; }
    }
}

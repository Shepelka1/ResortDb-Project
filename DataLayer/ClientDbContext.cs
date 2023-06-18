using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ClientDbContext : IDb<Client, int>
    {
        ResortDbContext dbContext = new ResortDbContext();
        public void Create(Client item)
        {
            try
            {
                for (int i = 0; i < item.Reservations.Count; i++)
                {
                    RoomReservation reservationFromDb = dbContext.RoomReservations.Find(item.Reservations[i].RoomReservationId);
                    if(reservationFromDb != null)
                    {
                        item.Reservations[i] = reservationFromDb;
                    }
                    else
                    {
                        dbContext.RoomReservations.Add(item.Reservations[i]);
                    }
                }

                for (int i = 0; i < item.RestaurantOrders.Count; i++)
                {
                    RestaurantOrder orderFromDb = dbContext.RestaurantOrders.Find(item.RestaurantOrders[i].RestaurantOrderId);
                    if (orderFromDb != null)
                    {
                        item.RestaurantOrders[i] = orderFromDb;
                    }
                    else
                    {
                        dbContext.RestaurantOrders.Add(item.RestaurantOrders[i]);
                    }
                }

                for (int i = 0; i < item.SpaSessions.Count; i++)
                {
                    SpaSession sessionFromDb = dbContext.SpaSessions.Find(item.SpaSessions[i].SpaSessionId);
                    if (sessionFromDb != null)
                    {
                        item.SpaSessions[i] = sessionFromDb;
                    }
                    else
                    {
                        dbContext.SpaSessions.Add(item.SpaSessions[i]);
                    }
                }

                for (int i = 0; i < item.BarOrders.Count; i++)
                {
                    BarOrder orderFromDb = dbContext.BarOrders.Find(item.BarOrders[i].BarOrderId);
                    if (orderFromDb != null)
                    {
                        item.BarOrders[i] = orderFromDb;
                    }
                    else
                    {
                        dbContext.BarOrders.Add(item.BarOrders[i]);
                    }
                }
                dbContext.Clients.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Client item)
        {
            try
            {
                Client clientFromDb = dbContext.Clients.Find(item.ClientId);
                if(clientFromDb != null)
                {
                    dbContext.Clients.Remove(clientFromDb);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Client Read(int key)
        {
            try
            {
                return dbContext.Clients.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<Client> ReadAll()
        {
            try
            {
                return dbContext.Clients.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Client item)
        {
            try
            {
                Client clientFromDb = dbContext.Clients.Find(item.ClientId);
                if(clientFromDb != null)
                {
                    clientFromDb.Name = item.Name;
                    clientFromDb.PhoneNumber = item.PhoneNumber;
                    clientFromDb.RestaurantOrders = item.RestaurantOrders;
                    clientFromDb.BarOrders = item.BarOrders;
                    clientFromDb.Reservations = item.Reservations;
                    clientFromDb.SpaSessions = item.SpaSessions;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

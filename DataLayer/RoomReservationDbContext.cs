using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RoomReservationDbContext : IDb<RoomReservation, int>
    {
        ResortDbContext dbContext = new ResortDbContext();
        public void Create(RoomReservation item)
        {
            try
            {
                for (int i = 0; i < item.Clients.Count; i++)
                {
                    Client clientFromDb = dbContext.Clients.Find(item.Clients[i].ClientId);
                    if (clientFromDb != null)
                    {
                        item.Clients[i] = clientFromDb;
                    }
                    else
                    {
                        dbContext.Clients.Add(item.Clients[i]);
                    }
                }
                dbContext.RoomReservations.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(RoomReservation item)
        {
            try
            {
                RoomReservation reservationFromDb = dbContext.RoomReservations.Find(item.RoomReservationId);
                if (reservationFromDb != null)
                {
                    dbContext.RoomReservations.Remove(reservationFromDb);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RoomReservation Read(int key)
        {
            try
            {
                return dbContext.RoomReservations.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<RoomReservation> ReadAll()
        {
            try
            {
                return dbContext.RoomReservations.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(RoomReservation item)
        {
            try
            {
                RoomReservation reservationFromDb = dbContext.RoomReservations.Find(item.RoomReservationId);
                if (reservationFromDb != null)
                {
                    reservationFromDb.ArrivalDate = item.ArrivalDate;
                    reservationFromDb.DepartureDate = item.DepartureDate;
                    reservationFromDb.TotalPrice = item.TotalPrice;
                    reservationFromDb.Clients = item.Clients;
                }
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

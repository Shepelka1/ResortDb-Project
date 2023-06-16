using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestaurantOrderDbContext : IDb<RestaurantOrder, int>
    {
        ResortDbContext dbContext = new ResortDbContext();
        public void Create(RestaurantOrder item)
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
                dbContext.RestaurantOrders.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(RestaurantOrder item)
        {
            try
            {
                RestaurantOrder orderFromDb = dbContext.RestaurantOrders.Find(item.RestaurantOrderId);
                if (orderFromDb != null)
                {
                    dbContext.RestaurantOrders.Remove(orderFromDb);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RestaurantOrder Read(int key)
        {
            try
            {
                return dbContext.RestaurantOrders.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<RestaurantOrder> ReadAll()
        {
            try
            {
                return dbContext.RestaurantOrders.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(RestaurantOrder item)
        {
            try
            {
                RestaurantOrder orderFromDb = dbContext.RestaurantOrders.Find(item.RestaurantOrderId);
                if(orderFromDb != null)
                {
                    orderFromDb.OrderDate = item.OrderDate;
                    orderFromDb.TotalPrice = item.TotalPrice;
                    orderFromDb.Clients = item.Clients;
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

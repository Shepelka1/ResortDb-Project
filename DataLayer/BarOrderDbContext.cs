using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BarOrderDbContext : IDb<BarOrder, int>
    {
        ResortDbContext dbContext = new ResortDbContext();
        public void Create(BarOrder item)
        {
            try
            {
                for (int i = 0; i < item.Clients.Count; i++)
                {
                    Client clientFromDb = dbContext.Clients.Find(item.Clients[i].ClientId);
                    if(clientFromDb != null)
                    {
                        item.Clients[i] = clientFromDb;
                    }
                    else
                    {
                        dbContext.Clients.Add(item.Clients[i]);
                    }
                }
                dbContext.BarOrders.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(BarOrder item)
        {
            try
            {
                BarOrder barOrderFromDb = dbContext.BarOrders.Find(item.BarOrderId);
                if(barOrderFromDb != null)
                {
                    dbContext.BarOrders.Remove(barOrderFromDb);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BarOrder Read(int key)
        {
            try
            {
                return dbContext.BarOrders.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<BarOrder> ReadAll()
        {
            try
            {
                return dbContext.BarOrders.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(BarOrder item)
        {
            try
            {
                BarOrder barOrderFromDb = dbContext.BarOrders.Find(item.BarOrderId);
                if(barOrderFromDb != null)
                {
                    barOrderFromDb.OrderDate = item.OrderDate;
                    barOrderFromDb.TotalPrice = item.TotalPrice;
                    barOrderFromDb.Clients = item.Clients;
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

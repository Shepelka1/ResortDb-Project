using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class SpaSessionDbContext : IDb<SpaSession, int>
    {
        ResortDbContext dbContext = new ResortDbContext();
        public void Create(SpaSession item)
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
                dbContext.SpaSessions.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(SpaSession item)
        {
            try
            {
                SpaSession sessionFromDb = dbContext.SpaSessions.Find(item.SpaSessionId);
                if (sessionFromDb != null)
                {
                    dbContext.SpaSessions.Remove(sessionFromDb);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SpaSession Read(int key)
        {
            try
            {
                return dbContext.SpaSessions.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<SpaSession> ReadAll()
        {
            try
            {
                return dbContext.SpaSessions.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(SpaSession item)
        {
            try
            {
                SpaSession sessionFromDb = dbContext.SpaSessions.Find(item.SpaSessionId);
                if (sessionFromDb != null)
                {
                    sessionFromDb.SessionDate = item.SessionDate;
                    sessionFromDb.TotalPrice = item.TotalPrice;
                    sessionFromDb.Clients = item.Clients;
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

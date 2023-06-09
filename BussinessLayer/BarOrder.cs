using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BarOrder
    {
        private BarOrder()
        {
            Clients = new List<Client>();
        }
        public BarOrder(int barOrderId, DateTime orderDate, decimal toatalPrice) : this()
        {
            BarOrderId = barOrderId;
            OrderDate = orderDate;
            ToatalPrice = toatalPrice;
        }
        public int BarOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal ToatalPrice { get; set; }
        public List<Client> Clients { get; set; }
    }
}

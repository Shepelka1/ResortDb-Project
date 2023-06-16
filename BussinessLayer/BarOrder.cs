using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BarOrder
    {
        [Key]
        public int BarOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Range(0, int.MaxValue)]
        public decimal TotalPrice { get; set; }
        public List<Client> Clients { get; set; }
        private BarOrder()
        {
            Clients = new List<Client>();
        }
        public BarOrder(int barOrderId, DateTime orderDate, decimal totalPrice) : this()
        {
            BarOrderId = barOrderId;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
    }
}

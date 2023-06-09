using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class RestaurantOrder
    {
        private RestaurantOrder()
        {
            Clients = new List<Client>();
        }
        public RestaurantOrder(int restaurantOrderId, DateTime orderDate, decimal tatalPrice) : this()
        {
            RestaurantOrderId = restaurantOrderId;
            OrderDate = orderDate;
            TatalPrice = tatalPrice;
        }
        public int RestaurantOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TatalPrice { get; set; }
        public List<Client> Clients { get; set; }
    }
}

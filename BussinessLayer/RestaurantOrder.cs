using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class RestaurantOrder
    {
        [Key]
        public int RestaurantOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Range(0, int.MaxValue)]
        public decimal TotalPrice { get; set; }
        public List<Client> Clients { get; set; }
        private RestaurantOrder()
        {
            Clients = new List<Client>();
        }
        public RestaurantOrder(int restaurantOrderId, DateTime orderDate, decimal totalPrice) : this()
        {
            RestaurantOrderId = restaurantOrderId;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
    }
}

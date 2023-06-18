using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<RoomReservation> Reservations { get; set; }
        public List<RestaurantOrder> RestaurantOrders { get; set; }
        public List<SpaSession> SpaSessions { get; set; }
        public List<BarOrder> BarOrders { get; set; }
        public Client()
        {
            Reservations = new List<RoomReservation>();
            RestaurantOrders = new List<RestaurantOrder>();
            SpaSessions = new List<SpaSession>();
            BarOrders = new List<BarOrder>();
        }
        public Client(int clientId, string phoneNumber) : this()
        {
            ClientId = clientId;
            PhoneNumber = phoneNumber;
        }

    }
}

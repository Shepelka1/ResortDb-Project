using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class RoomReservation
    {
        [Key]
        public int RoomReservationId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        [Range(0, int.MaxValue)]
        public decimal TotalPrice { get; set; }
        public List<Client> Clients { get; set; }
        private RoomReservation()
        {
            Clients = new List<Client>();
        }
        public RoomReservation(int roomReservationId, DateTime arrivalDate, DateTime departureDate, decimal totalPrice) : this()
        {
            RoomReservationId = roomReservationId;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            TotalPrice = totalPrice;
        }
    }
}

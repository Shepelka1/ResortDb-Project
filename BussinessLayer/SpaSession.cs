using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class SpaSession
    {
        [Key]
        public int SpaSessionId { get; set; }
        public DateTime SessionDate { get; set; }
        [Range(0,int.MaxValue)]
        public decimal TotalPrice { get; set; }
        public List<Client> Clients { get; set; }
        private SpaSession()
        {
            Clients = new List<Client>();
        }
        public SpaSession(int spaSessionId, DateTime sessionDate, decimal totalPrice) : this()
        {
            SpaSessionId = spaSessionId;
            SessionDate = sessionDate;
            TotalPrice = totalPrice;
        }
    }
}

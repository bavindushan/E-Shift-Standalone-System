using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShiftApp.Models
{
    public class TransportJob
    {
        public int JobId { get; set; }
        public int CustomerId { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public string Status { get; set; } // Pending, Approved, Declined
        public DateTime RequestDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? UnitId { get; set; }
    }
}

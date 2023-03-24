using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunAndBooksEntities.Entities
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string SipmentStatus { get; set; }

        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public virtual Orders Orders { get; set; }
    }
}

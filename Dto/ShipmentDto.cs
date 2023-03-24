using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ShipmentDto
    {
        public int ShipmentId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string SipmentStatus { get; set; }
        public  OrdersDto Orders { get; set; }
    }
}

using Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{

    public class OrdersDto
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int? ShipmentId { get; set; }

        public CustomerDto Customer { get; set; }
        public ProductsDto Products { get; set; }
        public ShipmentDto Shipment { get; set; }
    }
}

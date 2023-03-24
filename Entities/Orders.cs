using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Orders
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int? ShipmentId { get; set; }

        [ForeignKey("CustomerAccount")]
        public int CustomerId { get; set; }
        public virtual CustomerAccount CustomerAccount { get; set; }

        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public virtual Products Products { get; set; }

        [ForeignKey("Shipment")]
        public virtual Shipment Shipment { get; set; }
    }
}

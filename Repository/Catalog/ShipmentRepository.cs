using FunAndBooksEntities.Context;
using FunAndBooksEntities.Entities;
using FunAndBooksRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FunAndBooksRepository.Catalog
{
    public class ShipmentRepository : BaseRepository<Shipment>, IShipmentRepository
    {
        public ShipmentRepository(AppDbContext context) : base(context)
        {
        }

        public int AddShipment(Shipment shipment)
        {
            var result = _context.Shipments.Add(shipment);
            return result.Entity.ShipmentId;
        }

        public int UpdateShipment(Shipment shipment)
        {
            var result = _context.Shipments.Add(shipment);
            return result.Entity.ShipmentId;
        }
    }
}

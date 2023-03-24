using FunAndBooksEntities.Entities;
using FunAndBooksRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunAndBooksRepository.Contracts
{
    public interface IShipmentRepository:IBaseRepository<Shipment>
    {
        int AddShipment(Shipment shipment);
        int UpdateShipment(Shipment shipment);
    }
}

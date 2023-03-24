using FunAndBooksEntities.Entities;
using FunAndBooksRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunAndBooksRepository.Contracts
{
    public interface IOrderRepository:IBaseRepository<Orders>
    {
        int AddOrders(Orders orders);
        int UpdateOrders(Orders orders);
    }
}

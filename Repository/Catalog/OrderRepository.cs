using FunAndBooksEntities.Context;
using FunAndBooksEntities.Entities;
using FunAndBooksRepository.Contracts;

namespace FunAndBooksRepository.Catalog
{
    public class OrderRepository : BaseRepository<Orders>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public int AddOrders(Orders orders)
        {
           var result= _context.Orders.Add(orders);
            return result.Entity.OrderId;
        }

        public int UpdateOrders(Orders orders)
        {
            var result = _context.Orders.Update(orders);
            return result.Entity.OrderId;
        }
    }
}

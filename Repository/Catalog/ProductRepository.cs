using FunAndBooksEntities.Context;
using FunAndBooksEntities.Entities;
using FunAndBooksRepository.Contracts;

namespace FunAndBooksRepository.Catalog
{
    public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
        public int AddProducts(Products products)
        {
           var result= _context.Products.Add(products);
            return result.Entity.ProductID;
        }

        public int UpdateProducts(Products products)
        {
            var result = _context.Products.Update(products);
            return result.Entity.ProductID;
        }
    }
}

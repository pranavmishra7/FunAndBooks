using FunAndBooksEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunAndBooksEntities.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>
    options) : base(options)
        {

        }

        public DbSet<CustomerAccount> CustomersAccount { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Membership> Memberships { get; set; }
    }
}

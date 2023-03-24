using FunAndBooksEntities.Context;
using FunAndBooksEntities.Entities;
using FunAndBooksRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunAndBooksRepository.Catalog
{
    public class MembershipRepository : BaseRepository<Membership>, IMembershipRepository
    {
        public MembershipRepository(AppDbContext context) : base(context)
        {
        }

        public int AddMembership(Membership membership)
        {
            var result = _context.Memberships.Add(membership);
            return result.Entity.MembershipId;
        }

        public int UpdateMembership(Membership membership)
        {
            var result = _context.Memberships.Update(membership);
            return result.Entity.MembershipId;
        }
    }
}

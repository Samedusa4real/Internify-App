using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Data.Repositories
{
    public class ContactRepository : Repository<Contact> , IContactRepository
    {
        public ContactRepository(ForageAppDbContext context) : base(context)
        {
            
        }
    }
}

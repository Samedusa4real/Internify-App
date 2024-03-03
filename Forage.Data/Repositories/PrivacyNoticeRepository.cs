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
    public class PrivacyNoticeRepository : Repository<PrivacyNotice>, IPrivacyNoticeRepository
    {
        public PrivacyNoticeRepository(ForageAppDbContext context) : base(context)
        {
            
        }
    }
}

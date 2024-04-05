using Forage.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Core.Entities
{
    public class Contact:BaseEntitiy
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
    
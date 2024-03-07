using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Extensions
{
    public static class AppUserManager
    {
        private static int _nextNumericId = 1;

        public static int GetNextNumericId()
        {
            return _nextNumericId++;
        }
    }
}

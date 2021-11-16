using ShopWebApp.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Comparers
{
    public class CompareUsers:IEqualityComparer<UserModel>
    {
        public bool Equals (UserModel x, UserModel y)
        {
            if (y == null)
            {
                return false;
            }

            if (x.Id == y.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetHashCode([DisallowNull] UserModel obj)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01_Facebook.Logic
{
    public class AscendingUserNameComparer : IComparer<UserProxy>
    {
        public int Compare(UserProxy x, UserProxy y)
        {
            return x.FacebookUser.Name.CompareTo(y.FacebookUser.Name);
        }
    }
}

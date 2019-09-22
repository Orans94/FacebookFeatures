using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01_Facebook.Logic
{
    public class DescendingUserNameComparer : IComparer<UserProxy>
    {
        public int Compare(UserProxy x, UserProxy y)
        {
            return y.FacebookUser.Name.CompareTo(x.FacebookUser.Name);
        }
    }
}

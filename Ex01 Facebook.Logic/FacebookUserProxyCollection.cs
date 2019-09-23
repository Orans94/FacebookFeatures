using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01_Facebook.Logic
{
    public class FacebookUserProxyCollection : IEnumerable
    {
        private readonly ICollection<UserProxy> r_UserProxyCollection;

        public FacebookUserProxyCollection(ICollection<UserProxy> i_UserProxyCollection)
        {
            r_UserProxyCollection = i_UserProxyCollection;
        }

        public IEnumerator<UserProxy> GetEnumerator()
        {
            foreach (UserProxy user in r_UserProxyCollection)
            {
                yield return user;
            }
        }

        public int Count()
        {
            return r_UserProxyCollection.Count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)r_UserProxyCollection).GetEnumerator();
        }
    }
}

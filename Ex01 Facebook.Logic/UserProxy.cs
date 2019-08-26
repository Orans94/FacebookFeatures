using Ex01_Facebook.Logic.Properties;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ex01_Facebook.Logic
{
    public class UserProxy
    {
        public User FacebookUser { get; set; }
        public Image UserImage { get; set; }
        public UserProxy(User i_FacebookUser)
        {
            FacebookUser = i_FacebookUser;
            UserImage = IsMinor() ? Resources.under18 : FacebookUser.ImageNormal;
        }

        private bool IsMinor()
        {
            DateTime birthday;
            bool isParseSucceed, isMinor;
            DateTime currentDate = DateTime.Now;
            isParseSucceed = DateTime.TryParse(FacebookUser.Birthday, out birthday);
            if(isParseSucceed)
            {
                isMinor = (currentDate - birthday).TotalDays < 365 * 18;
            }
            else
            {
                isMinor = true;
            }

            return isMinor;
        }
    }
}

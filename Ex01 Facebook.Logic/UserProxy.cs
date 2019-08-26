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
        private User m_User;
        private bool v_IsMinor;
        public Image
        public UserProxy(User i_User)
        {
            m_User = i_User;
            v_IsMinor = IsMinor();
        }

        private bool IsMinor()
        {
            DateTime birthday;
            bool isParseSucceed, isMinor;
            DateTime currentDate = DateTime.Now;
            isParseSucceed = DateTime.TryParse(m_User.Birthday, birthday);
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

        public FacebookObjectCollection<User> GetUserFriends()
        {
            return m_User.Friends;
        }

        public string GetUserName()
        {
            return m_User.Name;
        }

        public City GetHomeTown()
        {
            return m_User.Hometown;
        }

        public User.eGender? GetGender()
        {
            return m_User.Gender;
        }

        public User.eGender[] GetInterestedIn()
        {
            return m_User.InterestedIn;
        }

        public Image GetImage()
        {
            Image userPicture = v_IsMinor ? Resources.under18 : m_User.ImageNormal;

            return Resources.under18;
        }
    }
}

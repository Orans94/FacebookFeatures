using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01_Facebook.Logic
{
    public class Engine
    {
        private User m_LoggedInUser;
        private readonly string[] r_Permissions =
        #region PERMISSIONS
            {
            "public_profile",
           "email",
           "publish_to_groups",
           "user_birthday",
           "user_age_range",
           "user_gender",
           "user_link",
           "user_tagged_places",
           "user_videos",
           "publish_to_groups",
           "groups_access_member_info",
           "user_friends",
           "user_events",
           "user_likes",
           "user_location",
           "user_photos",
           "user_posts",
           "user_hometown"
        };
    #endregion

        public LoginResult LoginToFacebook()
        {
            LoginResult result = FacebookService.Login("1450160541956417", r_Permissions);

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                //fetchUserInfo();
            }
            else
            {   // alert to UI error was occurred
               // MessageBox.Show(result.ErrorMessage);
            }

            return result;
        }

        public LinkedList<User> MatchMe(string i_HomeTownFilter, User.eGender i_GenderFilter)
        {
            LinkedList<User> 
        }

        private void fetchUserInfo()
        {
            //picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                //  textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }

        
    }
}

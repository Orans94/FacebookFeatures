using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01_Facebook.Logic
{
    public class Engine
    {
        private readonly string[] r_Permissions =
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

        private FacebookDatingFeature m_DatingFeature;
        private FacebookGuessMyNameFeature m_GuessMyNameFeature;
        private User m_LoggedInUser;
        private LoginResult m_LastLoginResult;

        public LoginResult LoginToFacebook()
        {
            LoginResult result;
            try
            {
                result = FacebookService.Login("337720197182315", r_Permissions);
            }
            catch (Exception)
            {
                // error has occurred while try to login to Facebook server.
                result = null;
            }

            if (result != null && !string.IsNullOrEmpty(result.AccessToken))
            {
                prepareFacebookApplication(result);
            }

            return result;
        }

        public Image GetUserImageNormalSize()
        {
            return m_LoggedInUser.ImageNormal;
        }

        public bool IsUserLoggedIn()
        {
            return m_LoggedInUser != null;
        }

        private void prepareFacebookApplication(LoginResult i_Result)
        {
            m_LastLoginResult = i_Result;
            m_LoggedInUser = i_Result.LoggedInUser;
            m_DatingFeature = new FacebookDatingFeature(m_LoggedInUser);
            m_GuessMyNameFeature = new FacebookGuessMyNameFeature(m_LoggedInUser) { Health = 6, Score = 0 };
        }

        public void ConnectToFacebookWithLastAccessToken(string i_LastAccessToken)
        {
            m_LastLoginResult = FacebookService.Connect(i_LastAccessToken);
            prepareFacebookApplication(m_LastLoginResult);
        }

        public LinkedList<UserProxy> MatchMe(string i_HomeTownFilter, User.eGender i_GenderFilter)
        {
            LinkedList<UserProxy> filteredFriendsList;

            filteredFriendsList = m_DatingFeature.GenerateFilteredFriendsList(i_HomeTownFilter, i_GenderFilter);

            return filteredFriendsList;
        }

        public User PickRandomFriend()
        {
            return m_GuessMyNameFeature.RollAFriend();
        }

        public string GetHint()
        {
            return m_GuessMyNameFeature.GetHintPartlyName();
        }

        public bool IsUserGuessCorrect(string i_UserGuess)
        {
            return m_GuessMyNameFeature.IsUserGuessCorrect(i_UserGuess);
        }

        public void UpdateUserDueToHisGuess(bool i_IsUserGuessedRight)
        {
            m_GuessMyNameFeature.UpdateUserDataDueToHisGuess(i_IsUserGuessedRight);
        }

        public int GetUserGuessingGameScore()
        {
            return m_GuessMyNameFeature.Score;
        }

        public int GetUserGuessingGameHealth()
        {
            return m_GuessMyNameFeature.Health;
        }

        public int GetHealthGuessingGame()
        {
            return m_GuessMyNameFeature.Health;
        }

        public void GiveUpGuessingGame()
        {
            m_GuessMyNameFeature.GiveUp();
        }

        public User GetFriendToGuess()
        {
            return m_GuessMyNameFeature.GetChosenFriend();
        }

        public bool IsUserWorthyExtraHealth(bool i_IsUserGuessedRight)
        {
            return m_GuessMyNameFeature.IsUserWorthyExtraHealth(i_IsUserGuessedRight);
        }

        public bool IsGuessingGameOver()
        {
            return m_GuessMyNameFeature.IsGameOver();
        }

        public void RestartGuessingGame()
        {
            m_GuessMyNameFeature.Restart();
        }

        public FacebookObjectCollection<User> GetUserFriends()
        {
            return m_LoggedInUser.Friends;
        }

        public string GetUserName()
        {
            return m_LoggedInUser.Name;
        }

        public FacebookObjectCollection<Checkin> GetUserCheckIns()
        {
            return m_LoggedInUser.Checkins;
        }

        public FacebookObjectCollection<Event> GetUserEvents()
        {
            return m_LoggedInUser.Events;
        }

        public FacebookObjectCollection<Post> GetUserPosts()
        {
            return m_LoggedInUser.Posts;
        }

        public FacebookObjectCollection<Page> GetUserLikedPages()
        {
            return m_LoggedInUser.LikedPages;
        }

        public string GetUserAccessToken()
        {
            return m_LastLoginResult.AccessToken;
        }
    }
}

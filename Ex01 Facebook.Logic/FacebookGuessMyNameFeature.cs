using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01_Facebook.Logic
{
    
    public class FacebookGuessMyNameFeature
    {
        public User LoggedInUser { get; set; }
        public FacebookObjectCollection<User> FriendsOfLoggedInUser { get; set; }
        private int m_ChosenFriendIndex;

        public FacebookGuessMyNameFeature(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            FriendsOfLoggedInUser = i_LoggedInUser.Friends;
        }

        public User RollAFriend()
        {
            Random rnd = new Random();
            int numberOfFriends;

            numberOfFriends = FriendsOfLoggedInUser.Count;
            m_ChosenFriendIndex = rnd.Next(0, numberOfFriends-1);

            return FriendsOfLoggedInUser[m_ChosenFriendIndex];
        }

        public bool IsUserGuessCorrect(string i_UserGuess)
        {
            bool isUserGuessRight;

            isUserGuessRight = FriendsOfLoggedInUser[m_ChosenFriendIndex].Name == i_UserGuess;

            return isUserGuessRight;
        }

        public string getHintFirstName()
        {
            string friendFirstName;

            friendFirstName = FriendsOfLoggedInUser[m_ChosenFriendIndex].Name;

            return friendFirstName;
        }
    }
}

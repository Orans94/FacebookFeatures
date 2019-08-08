using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01_Facebook.Logic
{
    
    public class FacebookGuessMyNameFeature
    {
        public readonly User LoggedInUser { get; set; }
        public readonly User[] FriendsOfLoggedInUser { get; set; }

        public User RollAFriend()
        {
            Random rnd = new Random();
            int numberOfFriends;

            numberOfFriends = FriendsOfLoggedInUser.Length;
            int randomIndex = rnd.Next(0, numberOfFriends-1);

            return FriendsOfLoggedInUser[randomIndex];
        }


    }
}

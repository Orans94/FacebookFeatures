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
        public RandomNumbersGenerator RandomNumbersGenerator { get; set; }
        public int Score { get; set; }
        public int Health { get; set; }
        private int m_WinsInARow = 0;
        private int m_ChosenFriendIndex;

        public FacebookGuessMyNameFeature(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            FriendsOfLoggedInUser = i_LoggedInUser.Friends;
            RandomNumbersGenerator = new RandomNumbersGenerator();
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

        public string GetHintPartlyName()
        {
            string friendPartlyName;

            friendPartlyName = generatePartlyName(FriendsOfLoggedInUser[m_ChosenFriendIndex].Name);

            return friendPartlyName;
        }

        private string generatePartlyName(string i_FriendName)
        {
            StringBuilder hintedName = new StringBuilder();
            for (int i = 0; i < i_FriendName.Length; i++)
            {
                if (i_FriendName[i] == ' ')
                {
                    hintedName.Append(" ");
                }
                else
                {
                    hintedName.Append("_");
                }
            }
            List<int> generatedIndices = RandomNumbersGenerator.GenerateRandom(i_FriendName.Length / 2, 0, i_FriendName.Length - 1);
            foreach (int index in generatedIndices)
            {
                hintedName[index] = i_FriendName[index];
            }

            return hintedName.ToString();
        }

        internal void UpdateUserDueToHisGuess(bool i_IsUserGuessedRight)
        {
            if (i_IsUserGuessedRight)
            {
                updateUserDataDueToCorrectGussing();
            }
            else
            {
                updateUserDataDueToWrongGuessing();
            }
        }

        private void updateUserDataDueToWrongGuessing()
        {
            m_WinsInARow = 0;
            Health -= 20;
        }

        private void updateUserDataDueToCorrectGussing()
        {
            Score += 10;
            m_WinsInARow++;
            if (m_WinsInARow == 3)
            {
                if (Health < 100)
                {
                    Health += 20;
                }
                m_WinsInARow = 0;
            }
        }
    }
}

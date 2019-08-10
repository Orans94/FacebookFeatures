using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01_Facebook.Logic
{
    public class FacebookGuessMyNameFeature
    {
        private int m_WinsInARow = 0;
        private int m_ChosenFriendIndex = -1; 

        public User LoggedInUser { get; set; }

        public FacebookObjectCollection<User> FriendsOfLoggedInUser { get; set; }

        public RandomNumbersGenerator RandomNumbersGenerator { get; set; }

        public int Score { get; set; }

        public int Health { get; set; }

        public User GetChosenFriend()
        {
            User chosenFriend = null;

            if (m_ChosenFriendIndex != -1)
            {
                chosenFriend = FriendsOfLoggedInUser[m_ChosenFriendIndex];
            }

            return chosenFriend;
        }

        public FacebookGuessMyNameFeature(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            FriendsOfLoggedInUser = i_LoggedInUser.Friends;
            RandomNumbersGenerator = new RandomNumbersGenerator();
        }

        public User RollAFriend()
        {
            // this method return a random friend's user
            Random rnd = new Random();
            int numberOfFriends;

            numberOfFriends = FriendsOfLoggedInUser.Count;
            m_ChosenFriendIndex = rnd.Next(0, numberOfFriends - 1);

            return FriendsOfLoggedInUser[m_ChosenFriendIndex];
        }

        public bool IsUserGuessCorrect(string i_UserGuess)
        {
            bool isUserGuessRight;

            isUserGuessRight = FriendsOfLoggedInUser[m_ChosenFriendIndex].Name.ToUpper() == i_UserGuess.ToUpper();

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
            // this method generate a clue about the friend's name to guess
            // it return a string that represent a part of his name
            // ex: if his name is Yossi Cohen, a clue could be Y_ss_ C__en represting in string
            StringBuilder hintedName = new StringBuilder();
            List<int> generatedIndices;

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

            try
            {
                // generate a list of indices to expose random letter from the friend name
                generatedIndices = RandomNumbersGenerator.GenerateRandom(i_FriendName.Length / 2, 0, i_FriendName.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            { 
                // a legal name on Facebook must include at least one character
                generatedIndices = new List<int>(0);
            }

            foreach (int index in generatedIndices)
            {
                hintedName[index] = i_FriendName[index];
            }

            return hintedName.ToString();
        }

        public void UpdateUserDataDueToHisGuess(bool i_IsUserGuessedRight)
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
            Health -= Health >= 2 ? 2 : 1; 
        }

        public bool IsGameOver()
        {
            return Health == 0;
        }

        public void Restart()
        {
            Health = 6;
            Score = 0;
            m_WinsInARow = 0;
        }

        public void GiveUp()
        {
            m_WinsInARow = 0;
            Health--;
        }

        public bool IsUserWorthyExtraHealth(bool i_IsUserGuessedRight)
        {
            // this method return true if the user it is the third time the user guesse right in a row
            // and it life it not over max
            return m_WinsInARow == 2 && i_IsUserGuessedRight && Health < 6;
        }

        private void updateUserDataDueToCorrectGussing()
        {
            Score += 10;
            m_WinsInARow++;
            if (m_WinsInARow == 3)
            {
                if (Health < 6)
                {
                    Health++;
                }

                m_WinsInARow = 0;
            }
        }
    }
}

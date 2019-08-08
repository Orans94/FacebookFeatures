using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01_Facebook.Logic
{
    public class FacebookDatingFeature
    {
        private readonly User m_LoggedInUser;

        public FacebookDatingFeature(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public LinkedList<User> GenerateFilteredFriendsList(City i_HomeTownFilter, User.eGender i_GenderFilter)
        {
            // show a dialog which the user can choose which gender he wants to date
            // and also the user will enter a city which he wants to find the date/all cities.
            LinkedList<User> filteredFriendsList = new LinkedList<User>();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (isFriendAMatch(friend, i_HomeTownFilter, i_GenderFilter))
                {
                    filteredFriendsList.AddLast(friend);
                }
            }
            //now show filteredUsers list in listBox -and when the user choose one of them -
            // their profile picture and email to contact will appear.
            return filteredFriendsList;
        }

        private bool isFriendAMatch(User i_Friend, City i_HomeTownFilter, User.eGender i_GenderFilter)
        {
            // this method recieve a friend and return true if he mathces the filters.

            bool isFriendMatchingFilter;

            isFriendMatchingFilter = isOpenToDating(i_Friend)
                && isCityMatch(i_HomeTownFilter, i_Friend.Hometown)
                && isGenderMatch(i_GenderFilter, i_Friend);

            return isFriendMatchingFilter;
        }

        private bool isCityMatch(City i_HomeTownFilter, City i_FriendHomeTown)
        {
            // this method recieves a HomeTownFilter and the friend hometown
            // and return true if the friend's hometown mathces the filter

            bool isCityAMatch;

            if (i_HomeTownFilter == null)
            {
                isCityAMatch = true;
            }
            else
            {
                isCityAMatch = i_FriendHomeTown == i_HomeTownFilter;
            }

            return isCityAMatch;
        }

        private bool isGenderMatch(User.eGender i_GenderFilter, User i_Friend)
        {
            // this method recieve gender filter and a friend
            // and return true if the friend is interested in the logged in user gender
            // and if the friend's gender matches the gender filter.

            bool isGenderAMatch;

            isGenderAMatch = i_Friend.InterestedIn.Equals(m_LoggedInUser.Gender) && i_GenderFilter.Equals(i_Friend.Gender);

            return isGenderAMatch;
        }

        private bool isOpenToDating(User i_UserToCheck)
        {
            // this method recieves a user and return true if his relationship status is open to dating.

            bool isUserOpenToDating;

            isUserOpenToDating = i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Divorced
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.InAnOpenRelationship
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Separated
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Single
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Widowed;

            return isUserOpenToDating;
        }
    }
}

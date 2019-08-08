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

        public List<User> GenerateFilteredFriendsList(City i_HomeTownFilter, User.eGender i_GenderFilter)
        {
            // show a dialog which the user can choose which gender he wants to date
            // and also the user will enter a city which he wants to find the date/all cities.
            List<User> filteredFriendsList = new List<User>();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (isFriendAMatch(friend, i_HomeTownFilter, i_GenderFilter))
                {
                    filteredFriendsList.Add(friend);
                }
            }
            //now show filteredUsers list in listBox -and when the user choose one of them -
            // their profile picture and email to contact will appear.
            return filteredFriendsList;
        }

        private bool isFriendAMatch(User i_Friend, City i_HomeTownFilter, User.eGender i_GenderFilter)
        {
            bool isFriendMatchingFilter;

            isFriendMatchingFilter = isCityMatch(i_HomeTownFilter, m_LoggedInUser.Hometown, i_Friend.Hometown)
                && isGenderMatch(i_GenderFilter, i_Friend, m_LoggedInUser.Gender)
                && isOpenToDating(i_Friend);

            return isFriendMatchingFilter;
        }

        private bool isCityMatch(City i_HomeTownFilter, City i_LoggedInUserHomeTown, City i_FriendHomeTown)
        {
            bool isCityAMatch;

            if (i_HomeTownFilter == null)
            {
                isCityAMatch = true;
            }
            else
            {
                isCityAMatch = i_LoggedInUserHomeTown == i_FriendHomeTown;
            }

            return isCityAMatch;
        }

        private bool isGenderMatch(User.eGender i_GenderFilter, User i_Friend, User.eGender? i_LoggedInUserGender)
        {
            bool isGenderAMatch;

            isGenderAMatch = i_Friend.InterestedIn.Equals(i_LoggedInUserGender) && i_GenderFilter.Equals(i_Friend.Gender);

            return isGenderAMatch;
        }

        private bool isOpenToDating(User i_UserToCheck)
        {
            return i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Divorced
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.InAnOpenRelationship
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Separated
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Single
                || i_UserToCheck.RelationshipStatus == User.eRelationshipStatus.Widowed;
        }
    }
}

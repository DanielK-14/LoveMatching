using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBook_Application_WForms
{

    static public class AvailableFriends
    {

        static public List<User> GetAvailabeFriends(User i_User)
        {
            List<User> availableFriends = new List<User>();
            foreach(User friend in i_User.Friends)
            {
                if (usersCanBeMatched(friend, i_User))
                {
                    availableFriends.Add(friend);
                }
            }

            return availableFriends;
        }

        static private bool usersCanBeMatched(User i_Friend, User i_MainUser)
        {
            bool isAvailable = false;
            if (i_MainUser.InterestedIn != null && i_MainUser.Gender != null && i_Friend.InterestedIn != null && i_Friend.Gender != null)
            {
                bool userMightBeInterested = userIsInterestedIn(i_Friend.Gender.Value, i_MainUser);
                bool friendMightNeInterested = userIsInterestedIn(i_MainUser.Gender.Value, i_Friend);
                bool friendIsSingle = i_Friend.RelationshipStatus != User.eRelationshipStatus.Married && i_Friend.RelationshipStatus != User.eRelationshipStatus.Enagaged && i_Friend.RelationshipStatus != User.eRelationshipStatus.InARelationship;

                isAvailable = userMightBeInterested && friendMightNeInterested && friendIsSingle;
            }

            return isAvailable;
        }

        static private bool userIsInterestedIn(User.eGender i_Gender, User i_User)
        {
            bool userMightBeInterested = false;

            foreach (User.eGender gender in i_User.InterestedIn)
            {
                if (gender == i_Gender)
                {
                    userMightBeInterested = true;
                    break;
                }
            }

            return userMightBeInterested;
        }
    }
}

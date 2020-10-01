using System.Collections.Generic;
using System.Collections;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class FriendsToMatch : IEnumerable<User>
    {
        IEnumerable<User> r_Friends;

        User r_User;
        private int r_Score;
        private readonly FriendFilterHandler r_FilterTestHandler;


        public FriendsToMatch(User i_User, FriendFilterHandler i_FilterTestHandler,int i_Score)
        {
            r_User = i_User;
            r_Friends = i_User.Friends;
            r_FilterTestHandler = i_FilterTestHandler;
            r_Score = i_Score;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach(User friend in r_Friends)
            {
                Request request = new Request(r_User, friend);
                r_FilterTestHandler.Handle(request, r_Score);
                if (request.isScoreHighEnough)
                {
                    yield return friend;
                }
            }
        }



        // move below to handelers.

        private bool usersCanBeMatched(User i_Friend)
        {
            bool isAvailable = false;
            if (r_User.InterestedIn != null && r_User.Gender != null && i_Friend.InterestedIn != null && i_Friend.Gender != null)
            {
                ///bool userMightBeInterested = userIsInterestedIn(i_Friend.Gender.Value, r_User);
                ///bool friendMightBeInterested = userIsInterestedIn(r_User.Gender.Value, i_Friend);
                bool friendIsSingle = i_Friend.RelationshipStatus != User.eRelationshipStatus.Married && i_Friend.RelationshipStatus != User.eRelationshipStatus.Enagaged && i_Friend.RelationshipStatus != User.eRelationshipStatus.InARelationship;

                isAvailable = userMightBeInterested && friendMightBeInterested && friendIsSingle;
            }

            return isAvailable;
        }

        private bool userIsInterestedIn(User.eGender i_Gender, User i_User)
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


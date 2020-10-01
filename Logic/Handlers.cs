using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public static class Handlers
    {
        private static readonly int sr_NumberOfFriendsThatMakeSomeonePopular;

       public static bool isEducated(Request i_Request)
        {
            return i_Request.Friend.Educations.Length != 0;
        }

        public static bool hasWorkExperience(Request i_Request)
        {
            return i_Request.Friend.WorkExperiences.Length != 0;
        }

        public static bool isPopular(Request i_Request)
        {
            return i_Request.Friend.Friends.Count >= sr_NumberOfFriendsThatMakeSomeonePopular;
        }

        public static bool isFromSameReligion(Request i_Request)
        {
            return i_Request.Friend.Religion == i_Request.MainUser.Religion;
        }

        public static bool isFromSameTown(Request i_Request)
        {
            return i_Request.Friend.Hometown == i_Request.MainUser.Hometown;
        }

        public static bool isUserAndFriendIntrestedInEachOtherGender(Request i_Request)
        {
            bool userMightBeInterested = false;

            foreach (User.eGender gendersUser in i_Request.MainUser.InterestedIn)
            {
                if (gendersUser == i_Request.Friend.Gender)
                {
                    foreach (User.eGender gendersFriend in i_Request.MainUser.InterestedIn)
                    {
                        if (gendersFriend == i_Request.MainUser.Gender)
                        {
                            userMightBeInterested = true;
                            break;
                        }
                    }
                }
            }

            return userMightBeInterested;
        }

        public static bool isFriendSingle(Request i_Request)
        {
            return (i_Request.Friend.RelationshipStatus == User.eRelationshipStatus.Divorced ||
                i_Request.Friend.RelationshipStatus == User.eRelationshipStatus.Single ||
                i_Request.Friend.RelationshipStatus == User.eRelationshipStatus.Separated);
        }
    }
}

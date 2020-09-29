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
    }
}

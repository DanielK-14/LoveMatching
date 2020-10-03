using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace Logic
{
    public static class ChainOfHandlers
    {
        private static readonly int sr_NumberOfFriendsThatMakeSomeonePopular=100;

        private static readonly Dictionary<eFilters, Func<Request, bool>> sr_StringToOptionalFilterTest = new Dictionary<eFilters, Func<Request, bool>>();

        private static readonly LinkedList<Func<Request, bool>> sr_CriticalFilterTests = new LinkedList<Func<Request, bool>>();

        public enum eFilters
        {
            Educated,
            WorkExperience,
            Popular,
            SameReligion,
            SameTown
        }

        static ChainOfHandlers()
        {
            sr_StringToOptionalFilterTest.Add(eFilters.Educated, isEducated);
            sr_StringToOptionalFilterTest.Add(eFilters.WorkExperience, hasWorkExperience);
            sr_StringToOptionalFilterTest.Add(eFilters.Popular, isPopular);
            sr_StringToOptionalFilterTest.Add(eFilters.SameReligion, isFromSameReligion);
            sr_StringToOptionalFilterTest.Add(eFilters.SameTown, isFromSameTown);

            sr_CriticalFilterTests.AddLast(isUserAndFriendIntrestedInEachOtherGender);
        }

        public static FriendFilterHandler Build(LinkedList<eFilters> i_ListOfOptionalFiltersToAdd)
        {
            FriendFilterHandler firstInChain = null;
            
            foreach(Func<Request,bool> criticalFilterTest in sr_CriticalFilterTests)
            {
                if (firstInChain==null)
                {
                    firstInChain = new CriticalHandler(criticalFilterTest);
                }
                else
                {
                    firstInChain.AddToEndOfChain(new CriticalHandler(criticalFilterTest));
                }
            }

            foreach(eFilters nameOfOptionalFilter in i_ListOfOptionalFiltersToAdd)
            {
                Func<Request, bool> optionalFilterTest = sr_StringToOptionalFilterTest[nameOfOptionalFilter];

                if (firstInChain == null)
                {
                    firstInChain = new OptionalHandler(optionalFilterTest);
                }
                else
                {
                    firstInChain.AddToEndOfChain(new OptionalHandler(optionalFilterTest));
                }
            }

            return firstInChain;


        }

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

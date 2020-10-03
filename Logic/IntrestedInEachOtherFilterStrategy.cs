using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class IntrestedInEachOtherFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            bool userMightBeInterested = false;

            if (i_Request.MainUser.InterestedIn != null)
            {
                foreach (User.eGender gendersUser in i_Request.MainUser.InterestedIn)
                {
                    if (gendersUser == i_Request.Friend.Gender)
                    {
                        if (i_Request.Friend.InterestedIn != null)
                        {
                            foreach (User.eGender gendersFriend in i_Request.Friend.InterestedIn)
                            {
                                if (gendersFriend == i_Request.MainUser.Gender)
                                {
                                    userMightBeInterested = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return userMightBeInterested;
        }
    }
}

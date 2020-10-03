namespace Logic
{
    public class WorkExpFriendsFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.WorkExperiences.Length != 0;
        }
    }
}

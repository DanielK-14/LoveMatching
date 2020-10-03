namespace Logic
{
    public class EducatedFriendsFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.Educations.Length != 0;
        }
    }
}

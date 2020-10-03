namespace Logic
{
    public class SameReligionFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.Religion == i_Request.MainUser.Religion;
        }
    }
}

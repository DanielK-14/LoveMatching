namespace Logic
{
    public class PopularFriendsFilterStrategy : IFilterStrategy
    {
        private const int k_NumberOfFriendsThatMakeSomeonePopular = 100;

        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.Friends.Count >= k_NumberOfFriendsThatMakeSomeonePopular;
        }
    }
}

using FacebookWrapper.ObjectModel;

namespace Logic
{
    /// <summary>
    /// Part of Chain of Responsability pattern.
    /// The request is Client's friend which we check in our chain of filters.
    /// </summary>
    public class Request
    {
        public int Score { get; set; }

        public int NeededScore { get; private set; }

        public User MainUser { get; private set; }

        public User Friend { get; private set; }

        public bool IsFriendMatchable { get; set; }

        public Request(User i_MainUser, User i_Friend, int i_NeededScore)
        {
            MainUser = i_MainUser;
            Friend = i_Friend;
            IsFriendMatchable = false;
            Score = 0;
            NeededScore = i_NeededScore;
        }
    }
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
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

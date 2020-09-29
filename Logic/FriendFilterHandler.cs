using Nevron.Nov.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public abstract class FriendFilterHandler
    {
        public FriendFilterHandler NextHandler { get; set; }

        public Func<Request, bool> FilterTest { get; private set; }

        public FriendFilterHandler(Func<Request,bool> i_FilterTest)
        {
            FilterTest = i_FilterTest;
        }

        public abstract void Handle(Request io_Request, int i_NeededScore);
    }
}

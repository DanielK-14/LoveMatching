using Nevron.Nov.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public interface IFriendFilterHandler
    {
        IFriendFilterHandler NextHandler { get; set; }

        Func<Request, bool> FilterTest { get; set; }

        void Handle(Request io_Request, int i_NeededScore);
    }
}

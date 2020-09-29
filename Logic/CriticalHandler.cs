using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class CriticalHandler: FriendFilterHandler
    {
        public CriticalHandler(Func<Request, bool> i_FilterTest) : base(i_FilterTest)
        {
        }


       public override void Handle(Request io_Request, int i_NeededScore)
        {
            if (FilterTest.Invoke(io_Request))
            {
                NextHandler.Handle(io_Request, i_NeededScore);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class OptionalHandler : FriendFilterHandler
    {
        public OptionalHandler(Func<Request, bool> i_FilterTest) : base(i_FilterTest) 
        { 
        }

       public override void Handle(Request io_Request, int i_NeededScore)
        {
            if (FilterTest.Invoke(io_Request))
            {
                io_Request.Score++;
            }

            if (io_Request.Score >= i_NeededScore)
            {
                io_Request.isScoreHighEnough = true;
            }
            else
            {
                NextHandler.Handle(io_Request, i_NeededScore);
            }
        }
    }
}

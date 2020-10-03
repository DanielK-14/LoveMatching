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

        
       public override void Proccess(Request io_Request)
        {
            if (FilterTest.Invoke(io_Request))
            {
                io_Request.Score++;
            }

            if (io_Request.Score >= io_Request.NeededScore)
            {
                handle(io_Request);
            }
            else if (NextHandler != null)
            {
                NextHandler.Proccess(io_Request);
            }
        }
        
    }
}

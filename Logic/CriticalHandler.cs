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

        
       public override void Proccess(Request io_Request)
        {
            if (FilterTest.Invoke(io_Request))
            {
                if (NextHandler != null)
                {
                    NextHandler.Proccess(io_Request);
                }
                else
                {
                    handle(io_Request);
                }
            }
        }
        
    }
}

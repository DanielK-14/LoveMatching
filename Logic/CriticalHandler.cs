using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class CriticalHandler: IFriendFilterHandler
    {
        public IFriendFilterHandler NextHandler { get; set; }
         public Func<Request, bool> FilterTest { get; set; }

         void IFriendFilterHandler.Handle(Request io_Request, int i_NeededScore)
        {
            if (FilterTest.Invoke(io_Request))
            {
                NextHandler.Handle(io_Request, i_NeededScore);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public abstract class FriendFilterHandler
    {
        private FriendFilterHandler m_LastHandlerInChain;

        public FriendFilterHandler NextHandler { get; set; }
            
        public Func<Request, bool> FilterTest { get; private set; }

        public FriendFilterHandler(Func<Request,bool> i_FilterTest)
        {
            FilterTest = i_FilterTest;
            m_LastHandlerInChain = this;
        }

        public void AddToEndOfChain(FriendFilterHandler i_Handler)
        {
            m_LastHandlerInChain.NextHandler = i_Handler;
            m_LastHandlerInChain = i_Handler;
        }

        public abstract void Proccess(Request io_Request);

        protected void handle(Request io_Request)
        {
            io_Request.IsFriendMatchable = true;
        }
    }
}

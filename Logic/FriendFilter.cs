using System;

namespace Logic
{
    /// <summary>
    /// 1- Chain of Resposability pattern
    /// Base Handler
    /// 
    /// 2- Includes the Strategy pattern
    /// FilterTest is the Strategy
    /// </summary>
    public abstract class FriendFilter
    {
        private FriendFilter m_LastHandlerInChain;

        public FriendFilter NextHandler { get; set; }
            
        public Func<Request, bool> FilterTest { get; private set; }

        public FriendFilter(Func<Request, bool> i_FilterTest)
        {
            FilterTest = i_FilterTest;
            m_LastHandlerInChain = this;
        }

        public void AddToEndOfChain(FriendFilter i_Handler)
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

namespace Logic
{
    /// <summary>
    /// 1- Chain of Resposability pattern
    /// Base Handler
    /// 
    /// 2- Includes the Strategy pattern
    /// FilterStrategy is the Strategy we choose to filter our input.
    /// Context
    /// </summary>
    public abstract class FriendFilter
    {
        private FriendFilter m_LastHandlerInChain;

        public FriendFilter NextHandler { get; set; }

        private IFilterStrategy r_FilterStrategy;

        public FriendFilter(IFilterStrategy i_FilterStrategy)
        {
            r_FilterStrategy = i_FilterStrategy;
            m_LastHandlerInChain = this;
        }

        public void AddToEndOfChain(FriendFilter i_Handler)
        {
            m_LastHandlerInChain.NextHandler = i_Handler;
            m_LastHandlerInChain = i_Handler;
        }

        public void Proccess(Request io_Request)
        {
            bool friendPassedTheFilterTest = r_FilterStrategy.DoFilterOnFriends(io_Request);
            handleRequestOrMoveToNext(io_Request, friendPassedTheFilterTest);
        }

        protected abstract void handleRequestOrMoveToNext(Request io_Request, bool i_FriendPassedTheFilterTest);

        protected void handle(Request io_Request)
        {
            io_Request.IsFriendMatchable = true;
        }
    }
}

namespace Logic
{
    /// <summary>
    /// Part of Chain of Responsability pattern.
    /// ConcreteHandler 2
    /// </summary>
    public class CriticalFilter : FriendFilter
    {
        public CriticalFilter(IFilterStrategy i_FilterTest) : base(i_FilterTest)
        {
        }

       public override void Proccess(Request io_Request)
        {
            if (FilterStrategy.DoFilterOnFriends(io_Request))
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

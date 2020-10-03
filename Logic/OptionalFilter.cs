namespace Logic
{
    /// <summary>
    /// Part of Chain of Responsability pattern.
    /// ConcreteHandler 1
    /// </summary>
    public class OptionalFilter : FriendFilter
    {
        public OptionalFilter(IFilterStrategy i_FilterTest) : base(i_FilterTest) 
        {
        }

       public override void Proccess(Request io_Request)
        {
            if (FilterStrategy.DoFilterOnFriends(io_Request))
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

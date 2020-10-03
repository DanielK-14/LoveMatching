using System;

namespace Logic
{
    /// <summary>
    /// Part of Chain of Responsability pattern.
    /// ConcreteHandler 2
    /// </summary>
    public class CriticalFilter : FriendFilter
    {
        public CriticalFilter(Func<Request, bool> i_FilterTest) : base(i_FilterTest)
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

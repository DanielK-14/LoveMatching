using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class ChainOfHandelers
    {
        public FriendFilterHandler FirstInChain { get; private set; }
        private FriendFilterHandler m_LastInChain;

        public ChainOfHandelers(FriendFilterHandler i_FirstInChain)
        {
           m_LastInChain = FirstInChain = i_FirstInChain;
        }

        public void AddHandler(FriendFilterHandler i_HandlerToAdd)
        {
            m_LastInChain.NextHandler = i_HandlerToAdd;
            m_LastInChain = i_HandlerToAdd;
        }
    }
}

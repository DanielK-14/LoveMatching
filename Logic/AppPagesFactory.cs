using System.Collections.Generic;

namespace Logic
{
    /// <summary>
    /// The 'Creator' Abstruct class.
    /// A part of Factory Abstruct Pattern.
    /// </summary>
    public abstract class AppPagesFactory<T>
    {
        protected List<T> m_Pages = new List<T>(); 

        public abstract void CreatePages();

        public List<T> AppPages 
        {
            get
            {
                return m_Pages;
            }
        }
    }
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Logic
{
    /// <summary>
    /// The 'Creator' Abstruct class.
    /// A part of Factory Abstruct Pattern.
    /// </summary>
    public abstract class AppPagesFactory<T>
    {
        protected List<T> m_Pages = new List<T>(); 

        public AppPagesFactory()
        {
            CreatePages();
        }

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

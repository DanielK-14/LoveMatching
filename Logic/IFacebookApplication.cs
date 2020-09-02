using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public interface IFacebookApplication
    {
        void Run();

        void Login();

        void Logout();
    }
}

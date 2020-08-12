using System;
using System.Windows.Forms;

namespace FaceBook_Application_WForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormsManager WindowsApplication = new FormsManager();
            WindowsApplication.Run();
        }
    }
}

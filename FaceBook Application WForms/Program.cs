using System;

namespace FaceBook_Application_WForms
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            AppManager WindowsApplication = new AppManager();
            WindowsApplication.Run();
        }
    }
}

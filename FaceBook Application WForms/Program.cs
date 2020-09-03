using System;

namespace UI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            AppManager windowsApplication = AppManager.GetInstance;
            windowsApplication.Factory = new WinFormAppPagesCreator();
            windowsApplication.Run();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    /// <summary>
    /// Singelton Pattern
    /// AppManger class is accessible to all.
    /// There is only one instance of itself created.
    /// </summary>
    ///

    public sealed class AppManager : IFacebookApplication
    {
        private readonly AppSettings r_AppSettings;
        private User m_LoggedInUser;
        private Form m_CurrentShownForm;
        private WinFormAppPagesCreator m_PagesFactory;
        private readonly Stack<Form> r_PagesStack = new Stack<Form>();

        public static AppManager s_Instance = null;
        private static readonly object sr_CreationalLockContext = new object();

        private AppManager()
        {
            r_AppSettings = AppSettings.LoadFromFile();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(MyCommonExceptionHandlingMethod);
        }

        public static AppManager GetInstance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_CreationalLockContext)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new AppManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        internal Form CurrentShownForm
        {
            get { return m_CurrentShownForm; }

            set
            {
                if (m_CurrentShownForm != null)
                {
                    Point location = m_CurrentShownForm.Location;

                    m_CurrentShownForm.Hide();
                    if (value != null)
                    {
                        value.Location = location;
                    }
                }

                m_CurrentShownForm = value;
                if (m_CurrentShownForm != null)
                {
                    m_CurrentShownForm.Show();
                }
            }
        }

        internal AppSettings Settings
        {
            get { return r_AppSettings; }
        }

        private static void MyCommonExceptionHandlingMethod(object sender, ThreadExceptionEventArgs i_ThreadException)
        {
            Logger.WriteException(i_ThreadException.Exception.Message);
        }

        public void Run()
        {
            Login();
            initAllFormsAndStart();
            Application.Run();
        }

        private void initAllFormsAndStart()
        {
            try
            {
                m_PagesFactory = new WinFormAppPagesCreator(m_LoggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (Form pageForm in m_PagesFactory.AppPages)
            {
                pageForm.StartPosition = FormStartPosition.Manual;
                pageForm.FormClosing += endApplication;
            }

            Form mainPage = m_PagesFactory.AppPages[0];
            Form userInformationPage = m_PagesFactory.AppPages[1];
            Form zodiacPage = m_PagesFactory.AppPages[2];

           // mainPage.ProfileLinkClicked += switchToUserInformation;
           // mainPage.ZodiacLinkClicked += switchToZodiacForm;
           // mainPage.LogoutButtonClicked += logout;
           // userInformationPage.BackButtonClicked += switchToMainForm;
            CurrentShownForm = mainPage;
        }

        public void Login()
        {
            string accessToken = r_AppSettings.LastAccessToken;
            if (accessToken != null)
            {
                m_LoggedInUser = FacebookService.Connect(accessToken).LoggedInUser;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }

                m_LoggedInUser = loginForm.LogInInfo.LoggedInUser;
                r_AppSettings.LastAccessToken = loginForm.LogInInfo.AccessToken;
                r_AppSettings.SaveToFile();
            }
        }

        public void Back()
        {
            if (r_PagesStack.Count == 1)
            {
                r_PagesStack.Pop();
                CurrentShownForm = r_PagesStack.Peek();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void NextPage(Form i_PageToShow)
        {
            r_PagesStack.Push(i_PageToShow);
            CurrentShownForm = i_PageToShow;
        }

        private void endApplication(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        public void Logout()
        {
            CurrentShownForm = null;
            Settings.LastAccessToken = null;
            Settings.SaveToFile();
            Login();
            initAllFormsAndStart();
        }
    }
}

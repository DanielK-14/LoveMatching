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
        private readonly Stack<Form> r_PagesStack = new Stack<Form>();
        private Form m_CurrentShownForm;
        public delegate void MyOperationFunctionDelegate();
        public event MyOperationFunctionDelegate LoginEvent;
        private Dictionary<string, Form> m_FormPagesDictionary = new Dictionary<string, Form>();
        public AppPagesFactory<Form> Factory { get; set; }
        public User LoggedInUser { get; private set; }

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
            if (Factory == null)
            {
                throw new Exception("Cannot run without initializing a pages creator");
            }


            r_PagesStack.Clear();
            Factory.CreatePages();
            foreach (Form pageForm in Factory.AppPages)
            {
                pageForm.StartPosition = FormStartPosition.Manual;
                pageForm.FormClosing += endApplication;
                m_FormPagesDictionary.Add(pageForm.GetType().Name.ToLower(), pageForm);
            }

            Login();
            Application.Run();
        }


        public void Login()
        {
            string accessToken = r_AppSettings.LastAccessToken;
            if (accessToken != null)
            {
                LoggedInUser = FacebookService.Connect(accessToken).LoggedInUser;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }

                LoggedInUser = loginForm.LogInInfo.LoggedInUser;
                r_AppSettings.LastAccessToken = loginForm.LogInInfo.AccessToken;

                r_AppSettings.SaveToFile();
            }
            if (LoginEvent != null)
            {
                LoginEvent.Invoke();
            }
            NextPage(Factory.AppPages[0].GetType().Name.ToLower());
        }

        public void Back()
        {
            if (r_PagesStack.Count > 1)
            {
                r_PagesStack.Pop();
                CurrentShownForm = r_PagesStack.Peek();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void NextPage(string i_NextPageClassName)
        {
            Form nextPage = m_FormPagesDictionary[i_NextPageClassName.ToLower()];
            r_PagesStack.Push(nextPage);
            CurrentShownForm = nextPage;
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
        }
    }
}

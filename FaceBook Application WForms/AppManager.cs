using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    public class AppManager
    {
        private readonly AppSettings r_AppSettings;
        private MainPageForm m_MainForm;
        private UserInformation m_UserInformation;
        private User m_LoggedInUser;
        private ZodiacSignForm m_ZodiacSignForm;
        private Form m_CurrentShownForm;

        private Form CurrentShownForm
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

        public AppManager()
        {
            r_AppSettings = AppSettings.LoadFromFile();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(MyCommonExceptionHandlingMethod);
        }

        private static void MyCommonExceptionHandlingMethod(object sender, ThreadExceptionEventArgs i_ThreadException)
        {
            Logger.WriteException(i_ThreadException.Exception.Message);
        }

        public void Run()
        {
            login();
            initAllFormsAndStart();
            Application.Run();
        }

        private void initAllFormsAndStart()
        {
            try
            {
                m_MainForm = new MainPageForm(m_LoggedInUser);
                m_UserInformation = new UserInformation(m_LoggedInUser);
                m_ZodiacSignForm = new ZodiacSignForm(m_LoggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            m_MainForm.StartPosition = FormStartPosition.Manual;
            m_UserInformation.StartPosition = FormStartPosition.Manual;
            m_ZodiacSignForm.StartPosition = FormStartPosition.Manual;
            m_MainForm.FormClosing += endApplication;
            m_MainForm.ProfileLinkClicked += switchToUserInformation;
            m_MainForm.ZodiacLinkClicked += switchToZodiacForm;
            m_MainForm.LogoutButtonClicked += logout;
            m_UserInformation.FormClosing += endApplication;
            m_UserInformation.BackButtonClicked += switchToMainForm;
            m_ZodiacSignForm.FormClosing += endApplication;
            m_ZodiacSignForm.BackButtonClicked += switchToMainForm;
            CurrentShownForm = m_MainForm;
        }

        private void login()
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

        private void logout()
        {
            CurrentShownForm = null;
            r_AppSettings.LastAccessToken = null;
            r_AppSettings.SaveToFile();
            login();
            initAllFormsAndStart();
        }

        private void switchToUserInformation()
        {
            CurrentShownForm = m_UserInformation;
            m_UserInformation.fetchOnLoad();
        }

        private void switchToMainForm()
        {
            CurrentShownForm = m_MainForm;
        }

        private void switchToZodiacForm()
        {
            CurrentShownForm = m_ZodiacSignForm;
        }

        private void endApplication(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

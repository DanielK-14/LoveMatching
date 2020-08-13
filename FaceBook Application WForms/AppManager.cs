using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FaceBook_Application_WForms
{
    public class AppManager
    {
        private const string k_FileName = @"\AccessToken.txt";
        private MainPageForm m_MainForm;
        private UserInformation m_UserInformation;
        private User m_LoggedInUser;
        private ZodiakSignForm m_ZodiacSignForm;
        private string m_AccessTokenFilePath;
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
            m_AccessTokenFilePath = AppDomain.CurrentDomain.BaseDirectory + k_FileName;
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
                m_ZodiacSignForm = new ZodiakSignForm(m_LoggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            m_MainForm.StartPosition = FormStartPosition.Manual;
            m_UserInformation.StartPosition = FormStartPosition.Manual;
            m_ZodiacSignForm.StartPosition = FormStartPosition.Manual;
            m_MainForm.FormClosing += endApplication;
            m_MainForm.ProfileLinkOperation += switchToUserInformation;
            m_MainForm.ZodiacLinkOperation += switchToZodiacForm;
            m_MainForm.LogoutButtonOperation += logout;
            m_UserInformation.FormClosing += endApplication;
            m_UserInformation.BackButtonOperation += switchToMainForm;
            m_ZodiacSignForm.FormClosing += endApplication;
            m_ZodiacSignForm.BackButtonOperation += switchToMainForm;
            CurrentShownForm = m_MainForm;
        }

        private void login()
        {
            if (File.Exists(m_AccessTokenFilePath) &&
                new FileInfo(m_AccessTokenFilePath).Length != 0)
            {
                string accessToken = File.ReadAllText(m_AccessTokenFilePath);
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
                File.WriteAllText(m_AccessTokenFilePath, loginForm.LogInInfo.AccessToken);
            }
        }

        private void logout()
        {
            CurrentShownForm = null;
            File.Delete(m_AccessTokenFilePath);
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

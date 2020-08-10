using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FaceBook_Application_WForms
{
    public partial class FormsManager : Form
    {
        private readonly MainPageForm r_MainForm;
        private readonly UserInformation r_UserInformation;
        private readonly User r_LoggedInUser;
        private readonly string r_AccessTokenFilePath;
        private const string k_FileName = @"\AccessToken.txt";

        public FormsManager()
        {
            r_AccessTokenFilePath = AppDomain.CurrentDomain.BaseDirectory + k_FileName;
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            r_LoggedInUser = getLoggedInUser();

            try
            {
                r_MainForm = new MainPageForm(r_LoggedInUser);
                r_UserInformation = new UserInformation(r_LoggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            initAllFormsAndStart();
        }

        private void initAllFormsAndStart()
        {
            r_MainForm.FormClosing += endApplication;
            r_MainForm.ProfileLinkOperation += switchToUserInformation;
            r_UserInformation.FormClosing += endApplication;
            r_UserInformation.BackButtonOperation += switchToMainForm;
            r_MainForm.Show();
        }

        private User getLoggedInUser()
        {
            User loggedInUser;

            if (File.Exists(r_AccessTokenFilePath) &&
                new FileInfo(r_AccessTokenFilePath).Length != 0)
            {
                string accessToken = File.ReadAllText(r_AccessTokenFilePath);
                loggedInUser = FacebookService.Connect(accessToken).LoggedInUser;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                }

                loggedInUser = loginForm.LogInInfo.LoggedInUser;
                File.WriteAllText(r_AccessTokenFilePath, loginForm.LogInInfo.AccessToken);
            }

            return loggedInUser;
        }

        private void switchToUserInformation()
        {
            r_MainForm.Hide();
            r_UserInformation.Show();
            r_UserInformation.fetchOnLoad();
        }

        private void switchToMainForm()
        {
            r_UserInformation.Hide();
            r_MainForm.Show();
        }

        private void FormsManager_Show(object sender, EventArgs e)
        {
            Hide();
            Visible = false;
        }

        private void endApplication(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

    }
}

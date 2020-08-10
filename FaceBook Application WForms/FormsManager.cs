using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public FormsManager()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            
            r_LoggedInUser = loginForm.LogInInfo.LoggedInUser;
            try
            {
                r_MainForm = new MainPageForm(r_LoggedInUser);
                r_UserInformation = new UserInformation(r_LoggedInUser);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            r_MainForm.FormClosing += endApplication;
            r_MainForm.ProfileLinkOperation += switchToUserInformation;
            r_UserInformation.FormClosing += endApplication;
            r_UserInformation.BackButtonOperation += switchToMainForm;
            r_MainForm.Show();
        }

        private void switchToUserInformation()
        {
            r_UserInformation.Show();
            r_MainForm.Hide();
        }

        private void switchToMainForm()
        {
            r_MainForm.Show();
            r_UserInformation.Hide();
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

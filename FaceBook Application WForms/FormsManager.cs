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
        private readonly MainForm r_MainForm;
        private readonly UserInformation r_UserInformation;
        private readonly User r_LoggedInUser;

        public FormsManager()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

            r_LoggedInUser = loginForm.LogInInfo.LoggedInUser;
            r_MainForm = new MainForm(r_LoggedInUser);
            r_UserInformation = new UserInformation(r_LoggedInUser);

            r_UserInformation.BackButtonOperation += switchToMainForm;
            r_MainForm.ShowDialog();
        }

        private void switchToUserInformation()
        {
            r_MainForm.Hide();
            r_UserInformation.ShowDialog();
        }

        private void switchToMainForm()
        {
            r_UserInformation.Hide();
            r_MainForm.ShowDialog();
        }
    }
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaceBook_Application_WForms
{
    public partial class ZodiakSignForm : Form
    {
        public ZodiakSignForm(User i_LoggedInUser)
        {
            ZodiacSign userFate = new ZodiacSign(i_LoggedInUser.Birthday);
            InitializeComponent();
            pictureBox1.LoadAsync(userFate.MatchPictureUrl);
            pictureBox2.LoadAsync(userFate.UserPictureUrl);
            userSignNameLabel.Text = Enum.GetName(typeof(ZodiacSign.eZodiacSign), userFate.UserSign);
            matchSignNameLabel.Text = Enum.GetName(typeof(ZodiacSign.eZodiacSign), userFate.BestMatchedWithSign);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            findButton.Visible = false;
            pictureBox2.Visible = true;
            matchSignNameLabel.Visible = true;
            fateQuotePicture.Visible = true;
            MessageBox.Show("Congratulations! A match was found!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

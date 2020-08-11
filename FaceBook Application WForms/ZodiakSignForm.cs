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
        public delegate void BackButtonDelegate();
        public event BackButtonDelegate BackButtonOperation;
        private readonly ZodiacSign r_Zodiac;

        public ZodiakSignForm(User i_LoggedInUser)
        {
           r_Zodiac = new ZodiacSign(i_LoggedInUser.Birthday);
            InitializeComponent();
            pictureBox1.LoadAsync(r_Zodiac.PictureUrl);
            userSignNameLabel.Text = Enum.GetName(typeof(ZodiacSign.eZodiacSign), r_Zodiac.Sign);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            ZodiacSign bestMatch = r_Zodiac.BestMatchedWithSign;
            pictureBox2.LoadAsync(bestMatch.PictureUrl);
            matchSignNameLabel.Text = Enum.GetName(typeof(ZodiacSign.eZodiacSign), bestMatch.Sign);
            findButton.Visible = false;
            pictureBox2.Visible = true;
            matchSignNameLabel.Visible = true;
            fateQuotePicture.Visible = true;
            MessageBox.Show("Congratulations! A match was found!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (BackButtonOperation != null)
            {
                BackButtonOperation.Invoke();
            }
            findButton.Visible = true;
            pictureBox2.Visible = false;
            matchSignNameLabel.Visible = false;
            fateQuotePicture.Visible = false;
        }
    }
}

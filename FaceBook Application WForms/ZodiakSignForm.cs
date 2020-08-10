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
        public ZodiakSignForm(ZodiakSign i_ZodiakSIgn)
        {
            ZodiakSign matchedSign = i_ZodiakSIgn.SignBestMatchedWith;
            InitializeComponent();
           // pictureBox1.LoadAsync(i_ZodiakSIgn.PictureUrl);
           // pictureBox2.LoadAsync(התמונה של מה שמתאים לו);
           //ZodiakLabel1.Text = ....
           //ZodiakLabel2.Text =...
        }


    }
}

namespace FaceBook_Application_WForms
{
    partial class ZodiakSignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YouAreLabel = new System.Windows.Forms.Label();
            this.AndYouMachBestLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ZodiakLabel1 = new System.Windows.Forms.Label();
            this.ZodiakLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // YouAreLabel
            // 
            this.YouAreLabel.AutoSize = true;
            this.YouAreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.YouAreLabel.Location = new System.Drawing.Point(81, 37);
            this.YouAreLabel.Name = "YouAreLabel";
            this.YouAreLabel.Size = new System.Drawing.Size(166, 40);
            this.YouAreLabel.TabIndex = 0;
            this.YouAreLabel.Text = "You Are: ";
            // 
            // AndYouMachBestLabel
            // 
            this.AndYouMachBestLabel.AutoSize = true;
            this.AndYouMachBestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AndYouMachBestLabel.Location = new System.Drawing.Point(466, 37);
            this.AndYouMachBestLabel.Name = "AndYouMachBestLabel";
            this.AndYouMachBestLabel.Size = new System.Drawing.Size(419, 40);
            this.AndYouMachBestLabel.TabIndex = 1;
            this.AndYouMachBestLabel.Text = "And you match best with:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(473, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 140);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // ZodiakLabel1
            // 
            this.ZodiakLabel1.AutoSize = true;
            this.ZodiakLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ZodiakLabel1.Location = new System.Drawing.Point(82, 258);
            this.ZodiakLabel1.Name = "ZodiakLabel1";
            this.ZodiakLabel1.Size = new System.Drawing.Size(188, 32);
            this.ZodiakLabel1.TabIndex = 4;
            this.ZodiakLabel1.Text = "ZodiakLabel1";
            // 
            // ZodiakLabel2
            // 
            this.ZodiakLabel2.AutoSize = true;
            this.ZodiakLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ZodiakLabel2.Location = new System.Drawing.Point(467, 258);
            this.ZodiakLabel2.Name = "ZodiakLabel2";
            this.ZodiakLabel2.Size = new System.Drawing.Size(188, 32);
            this.ZodiakLabel2.TabIndex = 5;
            this.ZodiakLabel2.Text = "ZodiakLabel2";
            // 
            // ZodiakSignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 487);
            this.Controls.Add(this.ZodiakLabel2);
            this.Controls.Add(this.ZodiakLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AndYouMachBestLabel);
            this.Controls.Add(this.YouAreLabel);
            this.Name = "ZodiakSignForm";
            this.Text = "ZodiakSignForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YouAreLabel;
        private System.Windows.Forms.Label AndYouMachBestLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ZodiakLabel1;
        private System.Windows.Forms.Label ZodiakLabel2;
    }
}
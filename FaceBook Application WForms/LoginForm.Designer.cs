namespace UI
{
    internal partial class LoginForm
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
            System.Windows.Forms.Button Login;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            Login.AccessibleDescription = "";
            Login.AccessibleName = "logInButton";
            Login.AutoSize = true;
            Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Login.Cursor = System.Windows.Forms.Cursors.Hand;
            Login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            Login.Location = new System.Drawing.Point(290, 337);
            Login.Margin = new System.Windows.Forms.Padding(0);
            Login.Name = "Login";
            Login.Size = new System.Drawing.Size(306, 52);
            Login.TabIndex = 0;
            Login.UseVisualStyleBackColor = false;
            Login.Click += new System.EventHandler(this.loginAndInit);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(Login);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}


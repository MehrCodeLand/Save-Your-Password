namespace YourPasswordApp.Forms
{
    partial class HomeFm
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
            this.yourPasswordsBtn = new System.Windows.Forms.Button();
            this.createNewPasswordBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MehrCodeLandBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yourPasswordsBtn
            // 
            this.yourPasswordsBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.yourPasswordsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yourPasswordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yourPasswordsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourPasswordsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yourPasswordsBtn.Location = new System.Drawing.Point(319, 173);
            this.yourPasswordsBtn.Name = "yourPasswordsBtn";
            this.yourPasswordsBtn.Size = new System.Drawing.Size(180, 39);
            this.yourPasswordsBtn.TabIndex = 0;
            this.yourPasswordsBtn.Text = "Your Passwords";
            this.yourPasswordsBtn.UseVisualStyleBackColor = false;
            this.yourPasswordsBtn.Click += new System.EventHandler(this.yourPasswordsBtn_Click);
            // 
            // createNewPasswordBtn
            // 
            this.createNewPasswordBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.createNewPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createNewPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createNewPasswordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewPasswordBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createNewPasswordBtn.Location = new System.Drawing.Point(319, 128);
            this.createNewPasswordBtn.Name = "createNewPasswordBtn";
            this.createNewPasswordBtn.Size = new System.Drawing.Size(180, 39);
            this.createNewPasswordBtn.TabIndex = 1;
            this.createNewPasswordBtn.Text = "Create New Password";
            this.createNewPasswordBtn.UseVisualStyleBackColor = false;
            this.createNewPasswordBtn.Click += new System.EventHandler(this.createNewPasswordBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitBtn.Location = new System.Drawing.Point(319, 263);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(180, 39);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MehrCodeLandBtn
            // 
            this.MehrCodeLandBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MehrCodeLandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MehrCodeLandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MehrCodeLandBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MehrCodeLandBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MehrCodeLandBtn.Location = new System.Drawing.Point(319, 218);
            this.MehrCodeLandBtn.Name = "MehrCodeLandBtn";
            this.MehrCodeLandBtn.Size = new System.Drawing.Size(180, 39);
            this.MehrCodeLandBtn.TabIndex = 3;
            this.MehrCodeLandBtn.Text = "MehrCodeLand";
            this.MehrCodeLandBtn.UseVisualStyleBackColor = false;
            this.MehrCodeLandBtn.Click += new System.EventHandler(this.MehrCodeLandBtn_Click);
            // 
            // HomeFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourPasswordApp.Properties.Resources.chong_wei__aWyVkkLrc8_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MehrCodeLandBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.createNewPasswordBtn);
            this.Controls.Add(this.yourPasswordsBtn);
            this.DoubleBuffered = true;
            this.Name = "HomeFm";
            this.Text = "Home | Password";
            this.Load += new System.EventHandler(this.HomeFm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button yourPasswordsBtn;
        private Button createNewPasswordBtn;
        private Button ExitBtn;
        private Button MehrCodeLandBtn;
    }
}
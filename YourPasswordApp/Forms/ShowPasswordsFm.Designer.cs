namespace YourPasswordApp.Forms
{
    partial class ShowPasswordsFm
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
            this.components = new System.ComponentModel.Container();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.passwordsDG = new System.Windows.Forms.DataGridView();
            this.passwordDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPasswordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.Location = new System.Drawing.Point(257, 336);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(120, 34);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(433, 336);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(120, 34);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // passwordsDG
            // 
            this.passwordsDG.AllowUserToAddRows = false;
            this.passwordsDG.AllowUserToDeleteRows = false;
            this.passwordsDG.AutoGenerateColumns = false;
            this.passwordsDG.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.passwordsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.myPasswordIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.passwordStrDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.passwordsDG.DataSource = this.passwordDataBindingSource;
            this.passwordsDG.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordsDG.Location = new System.Drawing.Point(139, 83);
            this.passwordsDG.Name = "passwordsDG";
            this.passwordsDG.ReadOnly = true;
            this.passwordsDG.RowTemplate.Height = 25;
            this.passwordsDG.Size = new System.Drawing.Size(537, 201);
            this.passwordsDG.TabIndex = 2;
            // 
            // passwordDataBindingSource
            // 
            this.passwordDataBindingSource.DataSource = typeof(YourPasswordApp.Models.PasswordData);
            // 
            // myPasswordIdDataGridViewTextBoxColumn
            // 
            this.myPasswordIdDataGridViewTextBoxColumn.DataPropertyName = "MyPasswordId";
            this.myPasswordIdDataGridViewTextBoxColumn.HeaderText = "MyPasswordId";
            this.myPasswordIdDataGridViewTextBoxColumn.Name = "myPasswordIdDataGridViewTextBoxColumn";
            this.myPasswordIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordStrDataGridViewTextBoxColumn
            // 
            this.passwordStrDataGridViewTextBoxColumn.DataPropertyName = "PasswordStr";
            this.passwordStrDataGridViewTextBoxColumn.HeaderText = "PasswordStr";
            this.passwordStrDataGridViewTextBoxColumn.Name = "passwordStrDataGridViewTextBoxColumn";
            this.passwordStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ShowPasswordsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourPasswordApp.Properties.Resources.chong_wei__aWyVkkLrc8_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordsDG);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.BackBtn);
            this.Name = "ShowPasswordsFm";
            this.Text = "ShowPasswordsFm";
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BackBtn;
        private Button EditBtn;
        private DataGridView passwordsDG;
        private DataGridViewTextBoxColumn myPasswordIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordStrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private BindingSource passwordDataBindingSource;
    }
}
namespace OnlyOffice2MSProject
{
    partial class MainForm
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.cbHTTPS = new System.Windows.Forms.CheckBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btImport = new System.Windows.Forms.Button();
            this.lvLog = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(105, 7);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(268, 23);
            this.tbAddress.TabIndex = 0;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(12, 10);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(87, 15);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Server Address:";
            // 
            // cbHTTPS
            // 
            this.cbHTTPS.AutoSize = true;
            this.cbHTTPS.Enabled = false;
            this.cbHTTPS.Location = new System.Drawing.Point(377, 9);
            this.cbHTTPS.Name = "cbHTTPS";
            this.cbHTTPS.Size = new System.Drawing.Size(62, 19);
            this.cbHTTPS.TabIndex = 2;
            this.cbHTTPS.Text = "HTTPS";
            this.cbHTTPS.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(12, 38);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(39, 15);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "EMail:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(105, 35);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(268, 23);
            this.tbUserName.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(105, 64);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(268, 23);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 67);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(60, 15);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password:";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(270, 93);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(103, 24);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "Import to MS Project";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // lvLog
            // 
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chText});
            this.lvLog.Location = new System.Drawing.Point(12, 123);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(996, 342);
            this.lvLog.TabIndex = 4;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 193;
            // 
            // chText
            // 
            this.chText.Text = "Text";
            this.chText.Width = 761;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 477);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.cbHTTPS);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbAddress);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "OnlyOffice to Microsoft Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.CheckBox cbHTTPS;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chText;
    }
}


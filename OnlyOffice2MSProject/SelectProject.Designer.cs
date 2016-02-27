namespace OnlyOffice2MSProject
{
    partial class SelectProject
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
            this.lvProjects = new System.Windows.Forms.ListBox();
            this.btNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProjects
            // 
            this.lvProjects.FormattingEnabled = true;
            this.lvProjects.ItemHeight = 15;
            this.lvProjects.Location = new System.Drawing.Point(12, 12);
            this.lvProjects.Name = "lvProjects";
            this.lvProjects.Size = new System.Drawing.Size(307, 229);
            this.lvProjects.TabIndex = 0;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(244, 247);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Далее";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // SelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 280);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lvProjects);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SelectProject";
            this.Text = "Выберите проект";
            this.Load += new System.EventHandler(this.SelectProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lvProjects;
        private System.Windows.Forms.Button btNext;
    }
}
namespace TextEditor
{
    partial class OpenFile
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
            this.workingDirectory = new System.Windows.Forms.TextBox();
            this.navButton = new System.Windows.Forms.Button();
            this.folderList = new System.Windows.Forms.ListBox();
            this.openButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workingDirectory
            // 
            this.workingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workingDirectory.Location = new System.Drawing.Point(13, 13);
            this.workingDirectory.Name = "workingDirectory";
            this.workingDirectory.Size = new System.Drawing.Size(188, 20);
            this.workingDirectory.TabIndex = 0;
            // 
            // navButton
            // 
            this.navButton.Location = new System.Drawing.Point(244, 13);
            this.navButton.Name = "navButton";
            this.navButton.Size = new System.Drawing.Size(28, 23);
            this.navButton.TabIndex = 1;
            this.navButton.Text = "-->";
            this.navButton.UseVisualStyleBackColor = true;
            this.navButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // folderList
            // 
            this.folderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderList.FormattingEnabled = true;
            this.folderList.Location = new System.Drawing.Point(13, 50);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(118, 173);
            this.folderList.TabIndex = 2;
            this.folderList.SelectedIndexChanged += new System.EventHandler(this.folderList_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(116, 229);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Öppna";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 229);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fileList
            // 
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(137, 50);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(135, 173);
            this.fileList.TabIndex = 5;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(207, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(31, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.navButton);
            this.Controls.Add(this.workingDirectory);
            this.Name = "OpenFile";
            this.Text = "openFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox workingDirectory;
        private System.Windows.Forms.Button navButton;
        private System.Windows.Forms.ListBox folderList;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button backButton;
    }
}
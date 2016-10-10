namespace TextEditor
{
    partial class SaveFile
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
            this.navButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.navField = new System.Windows.Forms.TextBox();
            this.folderList = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fileNameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // navButton
            // 
            this.navButton.Location = new System.Drawing.Point(241, 15);
            this.navButton.Name = "navButton";
            this.navButton.Size = new System.Drawing.Size(31, 21);
            this.navButton.TabIndex = 0;
            this.navButton.Text = "-->";
            this.navButton.UseVisualStyleBackColor = true;
            this.navButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(205, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 21);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // navField
            // 
            this.navField.Location = new System.Drawing.Point(12, 15);
            this.navField.Name = "navField";
            this.navField.Size = new System.Drawing.Size(187, 20);
            this.navField.TabIndex = 2;
            // 
            // folderList
            // 
            this.folderList.FormattingEnabled = true;
            this.folderList.Location = new System.Drawing.Point(13, 42);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(259, 173);
            this.folderList.TabIndex = 3;
            this.folderList.SelectedIndexChanged += new System.EventHandler(this.folderList_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(222, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 21);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(169, 228);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(47, 21);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Spara";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fileNameField
            // 
            this.fileNameField.Location = new System.Drawing.Point(12, 228);
            this.fileNameField.Name = "fileNameField";
            this.fileNameField.Size = new System.Drawing.Size(151, 20);
            this.fileNameField.TabIndex = 6;
            // 
            // SaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fileNameField);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.navField);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.navButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaveFile";
            this.Text = "Spara Som";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button navButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox navField;
        private System.Windows.Forms.ListBox folderList;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox fileNameField;
    }
}
namespace TextEditor
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchField = new System.Windows.Forms.TextBox();
            this.replaceField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.chooseFontButton = new System.Windows.Forms.Button();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.chooseFontSizeButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(-1, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1062, 621);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // searchField
            // 
            this.searchField.Enabled = false;
            this.searchField.Location = new System.Drawing.Point(13, 670);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(100, 20);
            this.searchField.TabIndex = 1;
            // 
            // replaceField
            // 
            this.replaceField.Enabled = false;
            this.replaceField.Location = new System.Drawing.Point(171, 670);
            this.replaceField.Name = "replaceField";
            this.replaceField.Size = new System.Drawing.Size(100, 20);
            this.replaceField.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(119, 667);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(46, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Sök";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // replaceButton
            // 
            this.replaceButton.Enabled = false;
            this.replaceButton.Location = new System.Drawing.Point(277, 668);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(42, 23);
            this.replaceButton.TabIndex = 4;
            this.replaceButton.Text = "Ersätt";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(179, 12);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(67, 23);
            this.saveAsButton.TabIndex = 5;
            this.saveAsButton.Text = "Spara Som";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(66, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(56, 23);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Öppna";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(13, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(47, 23);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "Nytt";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // chooseFontButton
            // 
            this.chooseFontButton.Location = new System.Drawing.Point(889, 12);
            this.chooseFontButton.Name = "chooseFontButton";
            this.chooseFontButton.Size = new System.Drawing.Size(53, 23);
            this.chooseFontButton.TabIndex = 9;
            this.chooseFontButton.Text = "Typsnitt";
            this.chooseFontButton.UseVisualStyleBackColor = true;
            this.chooseFontButton.Click += new System.EventHandler(this.chooseFontButton_Click);
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Location = new System.Drawing.Point(948, 12);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(42, 23);
            this.chooseColorButton.TabIndex = 10;
            this.chooseColorButton.Text = "Färg";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.chooseColorButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(996, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Avsluta";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(252, 12);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(47, 23);
            this.randomButton.TabIndex = 12;
            this.randomButton.Text = "RNG";
            this.randomButton.UseVisualStyleBackColor = true;
            // 
            // chooseFontSizeButton
            // 
            this.chooseFontSizeButton.Location = new System.Drawing.Point(810, 12);
            this.chooseFontSizeButton.Name = "chooseFontSizeButton";
            this.chooseFontSizeButton.Size = new System.Drawing.Size(73, 23);
            this.chooseFontSizeButton.TabIndex = 14;
            this.chooseFontSizeButton.Text = "Text Storlek";
            this.chooseFontSizeButton.UseVisualStyleBackColor = true;
            this.chooseFontSizeButton.Click += new System.EventHandler(this.chooseFontSizeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::TextEditor.Properties.Resources.saveButtonState2;
            this.saveButton.Location = new System.Drawing.Point(128, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(43, 32);
            this.saveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveButton.TabIndex = 15;
            this.saveButton.TabStop = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseDown);
            this.saveButton.MouseEnter += new System.EventHandler(this.saveButton_MouseEnter);
            this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
            this.saveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1060, 702);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.chooseFontSizeButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.chooseFontButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.replaceField);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.TextBox replaceField;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button chooseFontButton;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button chooseFontSizeButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox saveButton;
    }
}


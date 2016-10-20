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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchField = new System.Windows.Forms.TextBox();
            this.replaceField = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontSelectionTextBox = new System.Windows.Forms.TextBox();
            this.fontSizeValue = new System.Windows.Forms.NumericUpDown();
            this.colorButton = new System.Windows.Forms.PictureBox();
            this.fontSelectionButton = new System.Windows.Forms.PictureBox();
            this.fontSizeButton = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.PictureBox();
            this.replaceButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.saveAsButton = new System.Windows.Forms.PictureBox();
            this.rngButton = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSelectionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rngButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
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
            this.searchField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.searchField.ForeColor = System.Drawing.Color.White;
            this.searchField.Location = new System.Drawing.Point(13, 670);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(100, 20);
            this.searchField.TabIndex = 1;
            // 
            // replaceField
            // 
            this.replaceField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.replaceField.ForeColor = System.Drawing.Color.White;
            this.replaceField.Location = new System.Drawing.Point(171, 670);
            this.replaceField.Name = "replaceField";
            this.replaceField.Size = new System.Drawing.Size(100, 20);
            this.replaceField.TabIndex = 2;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(55, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(56, 23);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Öppna";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // fontSelectionTextBox
            // 
            this.fontSelectionTextBox.BackColor = System.Drawing.Color.Gray;
            this.fontSelectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fontSelectionTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.fontSelectionTextBox.Location = new System.Drawing.Point(853, 12);
            this.fontSelectionTextBox.Name = "fontSelectionTextBox";
            this.fontSelectionTextBox.ReadOnly = true;
            this.fontSelectionTextBox.Size = new System.Drawing.Size(72, 13);
            this.fontSelectionTextBox.TabIndex = 23;
            this.fontSelectionTextBox.Text = "Arial Black";
            this.fontSelectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fontSelectionTextBox.Click += new System.EventHandler(this.chooseFontButton_Click);
            this.fontSelectionTextBox.MouseEnter += new System.EventHandler(this.fontSelectionButton_MouseEnter);
            this.fontSelectionTextBox.MouseLeave += new System.EventHandler(this.fontSelectionButton_MouseLeave);
            // 
            // fontSizeValue
            // 
            this.fontSizeValue.BackColor = System.Drawing.Color.Gray;
            this.fontSizeValue.ForeColor = System.Drawing.SystemColors.Window;
            this.fontSizeValue.Location = new System.Drawing.Point(710, 10);
            this.fontSizeValue.Name = "fontSizeValue";
            this.fontSizeValue.Size = new System.Drawing.Size(65, 20);
            this.fontSizeValue.TabIndex = 24;
            // 
            // colorButton
            // 
            this.colorButton.Image = global::TextEditor.Properties.Resources.colorButton;
            this.colorButton.Location = new System.Drawing.Point(948, 3);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(47, 32);
            this.colorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorButton.TabIndex = 25;
            this.colorButton.TabStop = false;
            this.colorButton.Click += new System.EventHandler(this.chooseColorButton_Click);
            this.colorButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorButton_MouseDown);
            this.colorButton.MouseEnter += new System.EventHandler(this.colorButton_MouseEnter);
            this.colorButton.MouseLeave += new System.EventHandler(this.colorButton_MouseLeave);
            this.colorButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorButton_MouseUp);
            // 
            // fontSelectionButton
            // 
            this.fontSelectionButton.BackColor = System.Drawing.Color.Transparent;
            this.fontSelectionButton.Image = global::TextEditor.Properties.Resources.fontSelectionButton;
            this.fontSelectionButton.Location = new System.Drawing.Point(833, 3);
            this.fontSelectionButton.Name = "fontSelectionButton";
            this.fontSelectionButton.Size = new System.Drawing.Size(109, 32);
            this.fontSelectionButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fontSelectionButton.TabIndex = 22;
            this.fontSelectionButton.TabStop = false;
            this.fontSelectionButton.Click += new System.EventHandler(this.chooseFontButton_Click);
            this.fontSelectionButton.MouseEnter += new System.EventHandler(this.fontSelectionButton_MouseEnter);
            this.fontSelectionButton.MouseLeave += new System.EventHandler(this.fontSelectionButton_MouseLeave);
            // 
            // fontSizeButton
            // 
            this.fontSizeButton.Image = global::TextEditor.Properties.Resources.fontSizeButton;
            this.fontSizeButton.Location = new System.Drawing.Point(781, 3);
            this.fontSizeButton.Name = "fontSizeButton";
            this.fontSizeButton.Size = new System.Drawing.Size(46, 32);
            this.fontSizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fontSizeButton.TabIndex = 21;
            this.fontSizeButton.TabStop = false;
            this.fontSizeButton.Click += new System.EventHandler(this.fontSizeButton_Click);
            this.fontSizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fontSizeButton_MouseDown);
            this.fontSizeButton.MouseEnter += new System.EventHandler(this.fontSizeButton_MouseEnter);
            this.fontSizeButton.MouseLeave += new System.EventHandler(this.fontSizeButton_MouseLeave);
            this.fontSizeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fontSizeButton_MouseUp);
            // 
            // newButton
            // 
            this.newButton.Image = global::TextEditor.Properties.Resources.newButton;
            this.newButton.Location = new System.Drawing.Point(12, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(37, 32);
            this.newButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newButton.TabIndex = 20;
            this.newButton.TabStop = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            this.newButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newButton_MouseDown);
            this.newButton.MouseEnter += new System.EventHandler(this.newButton_MouseEnter);
            this.newButton.MouseLeave += new System.EventHandler(this.newButton_MouseLeave);
            this.newButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newButton_MouseUp);
            // 
            // replaceButton
            // 
            this.replaceButton.Image = ((System.Drawing.Image)(resources.GetObject("replaceButton.Image")));
            this.replaceButton.Location = new System.Drawing.Point(277, 668);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(72, 23);
            this.replaceButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.replaceButton.TabIndex = 19;
            this.replaceButton.TabStop = false;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            this.replaceButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.replaceButton_MouseDown);
            this.replaceButton.MouseEnter += new System.EventHandler(this.replaceButton_MouseEnter);
            this.replaceButton.MouseLeave += new System.EventHandler(this.relpaceButton_MouseLeave);
            this.replaceButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.replaceButton_MouseUp);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::TextEditor.Properties.Resources.searchButton_state2;
            this.searchButton.Location = new System.Drawing.Point(119, 668);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(37, 23);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 18;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchButton_MouseDown);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            this.searchButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.searchButton_MouseUp);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Image = global::TextEditor.Properties.Resources.saveAsButton_state2;
            this.saveAsButton.Location = new System.Drawing.Point(166, 3);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(39, 32);
            this.saveAsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveAsButton.TabIndex = 17;
            this.saveAsButton.TabStop = false;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            this.saveAsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saveAsButton_MouseDown);
            this.saveAsButton.MouseEnter += new System.EventHandler(this.saveAsButton_MouseEnter);
            this.saveAsButton.MouseLeave += new System.EventHandler(this.saveAsButton_MouseLeave);
            this.saveAsButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveAsButton_MouseUp);
            // 
            // rngButton
            // 
            this.rngButton.Image = global::TextEditor.Properties.Resources.FKLfl7l;
            this.rngButton.Location = new System.Drawing.Point(211, 3);
            this.rngButton.Name = "rngButton";
            this.rngButton.Size = new System.Drawing.Size(44, 32);
            this.rngButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rngButton.TabIndex = 16;
            this.rngButton.TabStop = false;
            this.rngButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::TextEditor.Properties.Resources.saveButtonState2;
            this.saveButton.Location = new System.Drawing.Point(117, 3);
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
            // exitButton
            // 
            this.exitButton.Image = global::TextEditor.Properties.Resources.exitButton;
            this.exitButton.Location = new System.Drawing.Point(1001, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 32);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 26;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitButton_MouseDown);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitButton_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1060, 702);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.fontSizeValue);
            this.Controls.Add(this.fontSelectionTextBox);
            this.Controls.Add(this.fontSelectionButton);
            this.Controls.Add(this.fontSizeButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.rngButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.replaceField);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSelectionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rngButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.TextBox replaceField;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox saveButton;
        private System.Windows.Forms.PictureBox rngButton;
        private System.Windows.Forms.PictureBox saveAsButton;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox replaceButton;
        private System.Windows.Forms.PictureBox newButton;
        private System.Windows.Forms.PictureBox fontSizeButton;
        private System.Windows.Forms.PictureBox fontSelectionButton;
        private System.Windows.Forms.TextBox fontSelectionTextBox;
        private System.Windows.Forms.NumericUpDown fontSizeValue;
        private System.Windows.Forms.PictureBox colorButton;
        private System.Windows.Forms.PictureBox exitButton;
    }
}


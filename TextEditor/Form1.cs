using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "[Insert name]";
        }

        bool isFileSaved = true;
        string openedFileName;
        OpenFile openDiag;
        SaveFile saveDiag;

        private void openButton_Click(object sender, EventArgs e)
        {
            // create a new instance of the form and open it
            openDiag = new OpenFile();
            openDiag.Show();

            // bind an eventlistner
            openDiag.FileSelected += OnFileSelected;
        }

        private void OnFileSelected(object sender, EventArgs e)
        {
           try
            {
                openedFileName = openDiag.SelectedFile;
                var ext = Path.GetExtension(openedFileName);
                richTextBox1.LoadFile(openedFileName, ext == ".txt" ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText);
                // one line magic :D (maybe use if/elseif/else to handle other filetypes?)
                isFileSaved = true;
                this.Text = Path.GetFileName(openedFileName);
                richTextBox1.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // add an asterisk at the end of the name if the file was saved, indicate that the file isnt saved
            if (isFileSaved)
                this.Text += "*";
            isFileSaved = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if ((openedFileName != null || openedFileName != String.Empty) && !isFileSaved)
            {
                try
                {
                    var ext = Path.GetExtension(openedFileName);
                    richTextBox1.SaveFile(openedFileName, ext == ".txt" ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText);
                    // one line magic :D (maybe use if/elseif/else to handle other filetypes?)
                    isFileSaved = true;
                    this.Text = this.Text.Trim('*');
                    richTextBox1.Enabled = true;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else if (isFileSaved && (openedFileName != null || openedFileName != String.Empty))
            {
                MessageBox.Show("Inga förändringar att spara.", "Warning");
            }
            else
            {
                saveDiag = new SaveFile();
                saveDiag.Show();

                // bind an event listner
                saveDiag.FileNameSelected += saveFileAs;
            }
        }

        private void saveFileAs(object sender, EventArgs e)
        {
            try
            {
                openedFileName = saveDiag.SelectedFileName;
                var ext = Path.GetExtension(openedFileName);
                richTextBox1.SaveFile(openedFileName, ext == ".txt" ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText);
                // one line magic :D (maybe use if/elseif/else to handle other filetypes?)
                isFileSaved = true;
                this.Text = this.Text.Trim('*');
                richTextBox1.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (!isFileSaved)
            {
                saveDiag = new SaveFile();
                saveDiag.Show();

                // bind an event listner
                saveDiag.FileNameSelected += saveFileAs;
            }
            else
            {
                MessageBox.Show("Inga förändringar att spara.", "Warning");
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            openedFileName = String.Empty;
            isFileSaved = true;
            richTextBox1.Clear();
            this.Text = "Ny Fil";
            richTextBox1.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!isFileSaved) OnClose();
            else this.Close();
        }

        private void OnClose()
        {
            DialogResult res = MessageBox.Show("Spara?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                if (!isFileSaved && (openedFileName != String.Empty || openedFileName != null))
                {
                    try
                    {
                        var ext = Path.GetExtension(openedFileName);
                        richTextBox1.SaveFile(openedFileName, ext == ".txt" ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText);
                        // one line magic :D (maybe use if/elseif/else to handle other filetypes?)
                        isFileSaved = true;
                        this.Text = this.Text.Trim('*');
                        richTextBox1.Enabled = true;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else if (!isFileSaved)
                {
                    saveDiag = new SaveFile();
                    saveDiag.Show();

                    // bind an event listner
                    saveDiag.FileNameSelected += saveFileAs;
                }
                isFileSaved = true;
                MessageBox.Show("Sparat.", "Warning");
            }
            else if (res == DialogResult.No)
            {
                isFileSaved = true;
            }

            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFileSaved)
            {
                e.Cancel = true;
                OnClose();
            }
            else e.Cancel = false;
        }
    }
}

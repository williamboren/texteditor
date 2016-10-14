using System;
using System.Drawing;
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

            // set the title of the program
            this.Text = "[Insert name]";

            // set the default text color (stored settings might be implemented if I have time for it)
            richTextBox1.ForeColor = Color.WhiteSmoke;
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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
            if ((openedFileName != null || openedFileName.Length > 0) && !isFileSaved)
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
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else if (isFileSaved && openedFileName.Length > 0)
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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
            DialogResult res = MessageBox.Show("Vill du spara filen?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                if (!isFileSaved && openedFileName.Length > 0)
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
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
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
            else
            {
                return;
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

        private void chooseFontButton_Click(object sender, EventArgs e)
        {
            // show the font diaglog and wait for the result
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // if the user have selected text before pressing the button, apply the font to the selected text
                if (richTextBox1.SelectedText.Length > 0)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
                // else apply it to all the text in the document
                else
                {
                    richTextBox1.Font = fontDialog1.Font;
                }
            }
        }

        private void chooseFontSizeButton_Click(object sender, EventArgs e)
        {
            // Hmm, richTextBox1.Font.Size is get only... How do I solve this??
        }

        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // if the user have selected text before pressing the button, apply the color to the selected text
                if (richTextBox1.SelectedText.Length > 0)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                // else apply it to all the text in the document
                else
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
            }
        }

        // switch image based on mouse events
        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.saveButtonState3;
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.saveButtonState2;
        }

        private void saveButton_MouseDown(object sender, MouseEventArgs e)
        {
            saveButton.Image = Properties.Resources.saveButtonState1;
        }

        private void saveButton_MouseUp(object sender, MouseEventArgs e)
        {
            saveButton.Image = Properties.Resources.saveButtonState3;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // if the search field have a value
            if (searchField.Text != null && searchField.Text.Length > 0)
            {
                // get the index of the first occurance of the input
                int index = richTextBox1.Find(searchField.Text), oldIndex = -1;

                // if theres is an selection already and it matches the one we're goning to create its *probably* the selection from the last search of the same word
                // save the index in oldIndex and use (oldIndex + searchinput length) as startindex for the next search
                if (richTextBox1.SelectionLength == searchField.TextLength && richTextBox1.Find(searchField.Text) == index)
                {
                    oldIndex = index;

                    // stop being a bitch rtb, let me search with string + startindex without searchoptions
                    // initiate a new char array and add each letter in the searchinput to it
                    char[] search = new char[searchField.TextLength];

                    for (int i = 0; i < searchField.TextLength; i++)
                    {
                        search[i] = searchField.Text[i];
                    }

                    index = richTextBox1.Find(search, oldIndex + searchField.Text.Length);
                }

                if (index >= 0)
                {
                    richTextBox1.Select(index, searchField.TextLength);
                }
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            // if both fields have a value
            if ((searchField.Text != null && searchField.Text.Length > 0) && (replaceField.Text != null && replaceField.Text.Length > 0))
            {
                // find the index of the first char
                int index = richTextBox1.Find(searchField.Text);

                if (index >= 0)
                {
                    // select the text from starting index to the length of the searchterm
                    richTextBox1.Select(index, searchField.TextLength);
                    // replace it with the value from the replace field
                    richTextBox1.SelectedText = replaceField.Text;
                }
            }
        }
    }
}

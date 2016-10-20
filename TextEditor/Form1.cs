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
            this.Text = title;

            // set the default text color (stored settings might be implemented if I have time for it)
            richTextBox1.ForeColor = Color.WhiteSmoke;

            // set the cursor to the normal arrow
            fontSelectionTextBox.Cursor = Cursors.Arrow;

            fontSelectionTextBox.Text = richTextBox1.Font.Name;
            fontSizeValue.Value = (decimal)richTextBox1.Font.Size;
        }
        string title = "TextPro";
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
                this.Text = title + " - " + Path.GetFileName(openedFileName);
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
            if ((openedFileName.Length > 0) && !isFileSaved)
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
            this.Text = title + " - Ny Fil";
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
            try
            {
                // show the font diaglog and wait for the result
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    fontSelectionTextBox.Text = fontDialog1.Font.Name;
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
            } catch (ArgumentException exception)
            {

                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void fontSizeButton_Click(object sender, EventArgs e)
        {
            float size = (float)fontSizeValue.Value;

            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, size, richTextBox1.Font.Style);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size, richTextBox1.Font.Style);
            }
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

        // switch image based on mouse events
        private void saveAsButton_MouseEnter(object sender, EventArgs e)
        {
            saveAsButton.Image = Properties.Resources.saveAsButton_state3;
        }

        private void saveAsButton_MouseLeave(object sender, EventArgs e)
        {
            saveAsButton.Image = Properties.Resources.saveAsButton_state2;
        }

        private void saveAsButton_MouseDown(object sender, MouseEventArgs e)
        {
            saveAsButton.Image = Properties.Resources.saveAsButton_state1;
        }

        private void saveAsButton_MouseUp(object sender, MouseEventArgs e)
        {
            saveAsButton.Image = Properties.Resources.saveAsButton_state3;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // if the search field have a value
            if (searchField.Text != null && searchField.Text.Length > 0)
            {
                // searches for any text matching the input and puts focus back on the textbox
                richTextBox1.Find(searchField.Text);
                richTextBox1.Focus();
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

        // Method to generate a random color
        private Color GenerateColor()
        {
            Random rng = new Random();
            ColorConverter converter = new ColorConverter();
            // generate a random Hex code and convert it to a color
            string colorHex = String.Format("#{0:X6}", rng.Next(0x1000000));
            Color color = (Color)converter.ConvertFromString(colorHex);
            return color;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            // Random class for generating random numbers
            Random rng = new Random();

            // Get 3 random ints, one for start index of selection and one for the length
            // and the last one to decide between the different "random" actions
            int selection = rng.Next(richTextBox1.Text.Length),
                selectionLength = rng.Next(richTextBox1.Text.Length),
                options = rng.Next(100);

            // select some text in the open document
            richTextBox1.Select(selection, selectionLength);

            if (options <= 10)
            {
                // sets the text, background and form background to random colors
                richTextBox1.SelectionColor = GenerateColor();
                richTextBox1.SelectionBackColor = GenerateColor();
                this.BackColor = GenerateColor();
            }
            else if (options > 10 && options <= 20)
            {
                // sets the selected text to protected (can't edit anything in the selection)
                richTextBox1.SelectionProtected = true; // :^)
                MessageBox.Show(":^)", ":^)");
                richTextBox1.Focus();
            }
            else if (options > 20 && options <= 30)
            {
                // undoes all possible changes :^)
                while (richTextBox1.CanUndo)
                {
                    richTextBox1.Undo();
                }
            }
            else if (options > 30 && options <= 40)
            {
                // minimize the window
                this.WindowState = FormWindowState.Minimized;
            }
            else if (options > 50 && options <= 60)
            {
                // this is pure evil
                this.Hide();
            }
            else if (options > 60 && options <= 70)
            {
                // quits the program :^)
                this.Close();
            }
            else if (options > 70 && options <= 80)
            {
                // I'm running out of ideas
                richTextBox1.Hide();
            }
            else if (options > 80 && options <= 90)
            {
                // self explainatory
                richTextBox1.ResetText();
            }
            else if (options > 90 && options <= 100)
            {
                // delete stored settings if its implemented 
                // and/or don't save them the next time the user quits the program
            }
        }

        private void searchButton_MouseDown(object sender, MouseEventArgs e)
        {
            searchButton.Image = Properties.Resources.searchButton_state1;
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.Image = Properties.Resources.searchButton_state3;
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.Image = Properties.Resources.searchButton_state2;
        }

        private void searchButton_MouseUp(object sender, MouseEventArgs e)
        {
            searchButton.Image = Properties.Resources.searchButton_state3;
        }

        private void replaceButton_MouseDown(object sender, MouseEventArgs e)
        {
            replaceButton.Image = Properties.Resources.replaceButton_state3;
        }

        private void replaceButton_MouseEnter(object sender, EventArgs e)
        {
            replaceButton.Image = Properties.Resources.replaceButton_state2;
        }

        private void relpaceButton_MouseLeave(object sender, EventArgs e)
        {
            replaceButton.Image = Properties.Resources.replaceButton;
        }

        private void replaceButton_MouseUp(object sender, MouseEventArgs e)
        {
            replaceButton.Image = Properties.Resources.replaceButton_state2;
        }

        private void newButton_MouseDown(object sender, MouseEventArgs e)
        {
            newButton.Image = Properties.Resources.newButton_state3;
        }

        private void newButton_MouseEnter(object sender, EventArgs e)
        {
            newButton.Image = Properties.Resources.newButton_state2;
        }

        private void newButton_MouseLeave(object sender, EventArgs e)
        {
            newButton.Image = Properties.Resources.newButton;
        }

        private void newButton_MouseUp(object sender, MouseEventArgs e)
        {
            newButton.Image = Properties.Resources.newButton_state2;
        }

        private void fontSizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            fontSizeButton.Image = Properties.Resources.fontSizeButton_state3;
        }

        private void fontSizeButton_MouseEnter(object sender, EventArgs e)
        {
            fontSizeButton.Image = Properties.Resources.fontSizeButton_state2;
        }

        private void fontSizeButton_MouseLeave(object sender, EventArgs e)
        {
            fontSizeButton.Image = Properties.Resources.fontSizeButton;
        }

        private void fontSizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            fontSizeButton.Image = Properties.Resources.fontSizeButton_state2;
        }

        private void fontSelectionButton_MouseEnter(object sender, EventArgs e)
        {
            fontSelectionButton.Image = Properties.Resources.fontSelectionButton_state2;
        }

        private void fontSelectionButton_MouseLeave(object sender, EventArgs e)
        {
            fontSelectionButton.Image = Properties.Resources.fontSelectionButton;
        }

        private void colorButton_MouseLeave(object sender, EventArgs e)
        {
            colorButton.Image = Properties.Resources.colorButton;
        }

        private void colorButton_MouseUp(object sender, MouseEventArgs e)
        {
            colorButton.Image = Properties.Resources.colorButton_state2;
        }

        private void colorButton_MouseEnter(object sender, EventArgs e)
        {
            colorButton.Image = Properties.Resources.colorButton_state2;
        }

        private void colorButton_MouseDown(object sender, MouseEventArgs e)
        {
            colorButton.Image = Properties.Resources.colorButton_state3;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exitButton;
        }

        private void exitButton_MouseUp(object sender, MouseEventArgs e)
        {
            exitButton.Image = Properties.Resources.exitButton_state2;
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exitButton_state2;
        }

        private void exitButton_MouseDown(object sender, MouseEventArgs e)
        {
            exitButton.Image = Properties.Resources.exitButton_state3;
        }
    }
}

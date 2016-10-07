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
        }
        bool isFileSaved = false;
        string openedFileName;
        OpenFile openDiag;

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
            openedFileName = openDiag.SelectedFile;
            var ext = Path.GetExtension(openedFileName);
            
            try
            {
                richTextBox1.LoadFile(openedFileName, ext == ".txt" ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText); 
                // one line magic :D (maybe use if/elseif/else to handle other filetypes?)
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            isFileSaved = true;
        }
    }
}

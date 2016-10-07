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
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();

            // set default dir to My Documents
            workingDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            UpdateList();
        }
        public string SelectedFile;
        public event EventHandler FileSelected;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navButton_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFunc();
        }

        private void folderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add the dir to the path and update the lists
            workingDirectory.Text += Path.DirectorySeparatorChar + folderList.Items[folderList.SelectedIndex].ToString();
            UpdateList();
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFunc();
        }

        private void UpdateList()
        {
            // clear the lists of all items
            folderList.Items.Clear();
            fileList.Items.Clear();

            // add all folders and files in the current dir to respective list, show a message if it can't access a file/folder
            try
            {
                foreach (string folder in Directory.GetDirectories(workingDirectory.Text).Select(f => f.Remove(0, f.LastIndexOf(Path.DirectorySeparatorChar) + 1))) // remove the full path from folder names
                {
                    folderList.Items.Add(folder);
                }

                foreach (string file in Directory.GetFiles(workingDirectory.Text).Select(Path.GetFileName)) // remove full path for file names
                {
                    fileList.Items.Add(file);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // event handler
        protected virtual void OnFileSelected(EventArgs e)
        {
            EventHandler handler = FileSelected;
            if (handler != null)
                handler(this, e);
        }

        private void OpenFunc()
        {
            // if a file is selected in the list
            if (fileList.SelectedIndex > -1)
            {
                SelectedFile = workingDirectory.Text + Path.DirectorySeparatorChar + fileList.Items[fileList.SelectedIndex].ToString();
                // Raise a new event since the file was selected
                OnFileSelected(EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Var god välj en fil.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // remove the current folder from the path (maybe store the different points in variables?
            workingDirectory.Text = workingDirectory.Text.Remove(workingDirectory.Text.LastIndexOf(Path.DirectorySeparatorChar) + 1, workingDirectory.Text.Length - (workingDirectory.Text.LastIndexOf(Path.DirectorySeparatorChar) + 1));
            UpdateList();
        }
    }
}

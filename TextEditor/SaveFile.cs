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
    public partial class SaveFile : Form
    {
        public SaveFile()
        {
            InitializeComponent();

            // set default dir to My Documents
            navField.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            UpdateList();
        }
        public string SelectedFileName;
        public event EventHandler FileNameSelected;

        private void UpdateList()
        {
            // clear the lists of all items
            folderList.Items.Clear();

            // add all folders and files in the current dir to respective list, show a message if it can't access a file/folder
            try
            {
                foreach (string folder in Directory.GetDirectories(navField.Text).Select(f => f.Remove(0, f.LastIndexOf(Path.DirectorySeparatorChar) + 1))) // remove the full path from folder names
                {
                    folderList.Items.Add(folder);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // remove the current folder from the path (maybe store the different points in variables?
            navField.Text = navField.Text.Remove(navField.Text.LastIndexOf(Path.DirectorySeparatorChar) + 1, navField.Text.Length - (navField.Text.LastIndexOf(Path.DirectorySeparatorChar) + 1));
            UpdateList();
        }

        private void navButton_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void folderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add the dir to the path and update the lists
            navField.Text += Path.DirectorySeparatorChar + folderList.Items[folderList.SelectedIndex].ToString();
            UpdateList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileNameField.MaxLength > 0)
            {
                SelectedFileName = navField.Text + Path.DirectorySeparatorChar + fileNameField.Text;
                // Raise the event
                OnFileNameSelected(EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Var god ange ett filnamn", "Error");
            }
        }

        // event handler
        protected virtual void OnFileNameSelected(EventArgs e)
        {
            EventHandler handler = FileNameSelected;
            if (handler != null)
                handler(this, e);
        }
    }
}

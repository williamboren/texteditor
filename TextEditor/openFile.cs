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
            workingDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            UpdateList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateList()
        {
            folderList.Items.Clear();
            fileList.Items.Clear();

            try
            {
                foreach (string folder in Directory.GetDirectories(workingDirectory.Text).Select(f => f.Remove(0, f.LastIndexOf(Path.DirectorySeparatorChar)+1)))
                {
                    folderList.Items.Add(folder);
                }

                foreach (string file in Directory.GetFiles(workingDirectory.Text).Select(Path.GetFileName))
                {
                    fileList.Items.Add(file);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void navButton_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}

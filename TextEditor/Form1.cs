﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFile openDiag = new OpenFile();
            openDiag.Show();
        }
    }
}

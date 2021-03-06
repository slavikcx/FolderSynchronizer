﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderSynchronizer
{
    public partial class FolderSynchronizerForm : Form
    {
        public FolderSynchronizerForm()
        {
            InitializeComponent();
        }

        FolderBrowserDialog FolderPathLeftDialog = new FolderBrowserDialog(); //creating dialog window instance for left file path
        FolderBrowserDialog FolderPathRightDialog = new FolderBrowserDialog(); //creating dialog window instance for right file path


        private void buttonFolderPathLeft_Click(object sender, EventArgs e)
        {
            
            FolderPathLeftDialog.Description = "Select folder for synchronizaton";

            // checking if user enter folder path manually then in folder browser dialog window this folder will be selected
            if (textBoxFolderPathLeft.Text != null)
            {
                FolderPathLeftDialog.SelectedPath = textBoxFolderPathLeft.Text;
            }

            
            if (FolderPathLeftDialog.ShowDialog() == DialogResult.OK) //checking if dialog window closed by clicking OK button
            {
                textBoxFolderPathLeft.Text = FolderPathLeftDialog.SelectedPath; //sending selected path into texbox
            }
        }

        private void buttonFolderPathRight_Click(object sender, EventArgs e)
        {
            FolderPathRightDialog.Description = "Select folder for synchronizaton";

            if (textBoxFolderPathRight.Text != null)
            {
                FolderPathRightDialog.SelectedPath = textBoxFolderPathRight.Text;
            }


            if (FolderPathRightDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFolderPathRight.Text = FolderPathRightDialog.SelectedPath;
            }
        }
    }
}

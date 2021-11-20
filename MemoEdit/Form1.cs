using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MemoEdit
{
    public partial class MemoEdit : Form
    {
        public MemoEdit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        private void MemoEdit_Load(object sender, EventArgs e)
        {
            
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to exit?";
            string caption = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
            return;           
            string filename = saveFile.FileName;
            System.IO.File.WriteAllText(filename, TextBox.Text);
        }

        private void open_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            TextBox.Text = fileText;
        }

        private void info_Click(object sender, EventArgs e)
        {
            string message = "MemoEdit v1.0";
            string caption = "Info";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Just type your text. You can use hotkeys";
            string caption = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

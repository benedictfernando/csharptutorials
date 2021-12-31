using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // open file dialog for user to choose an image to load
        private void showButton_Click(object sender, EventArgs e)
        {
            // load whatever user's chosen image if it's valid
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // clear existing picture, if any
        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        
        // change background color of picture box
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        // close windows form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // modify image's size depending on whether checkbox is checked or not
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickable_Images
{
    public partial class frmClickableImages : Form
    {
        public frmClickableImages()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("one", "clickable image");
            pictureBox1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("two", "clickable image");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("three", "clickable image");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("four", "clickable image");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("five", "clickable image");
        }
    }
}

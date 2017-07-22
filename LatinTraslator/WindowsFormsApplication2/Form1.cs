using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSinister_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "left";
            lbloutput.Left = 50;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "Center";
            lbloutput.Left = (this.ClientSize.Width / 2);
        }

        private void btnDexter_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "Right";
            lbloutput.Left = 240;
        }
    }
}

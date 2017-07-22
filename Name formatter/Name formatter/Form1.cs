/*******************************************
 * Programer: Jesse Muller
 * Program: Name formatter
 * Date: 22/07/2017
*******************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_formatter
{
    public partial class frmNameFormatter : Form
    {
        public frmNameFormatter()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string firstname;
            string middlename;
            string lastname;
            string title;

            firstname = txtFirstName.Text;
            middlename = txtMiddleName.Text;
            lastname = txtLastName.Text;
            title = txtTitle.Text;

            lbOutput.Items.Add(title + " " + firstname + " " + middlename + " " + lastname);
            lbOutput.Items.Add(firstname + " " + middlename + " " + lastname);
            lbOutput.Items.Add(firstname + " " + lastname);
            lbOutput.Items.Add(lastname + ", " + firstname + " " + middlename + ", " + title);
            lbOutput.Items.Add(lastname + ", " + firstname + " " + middlename);
            lbOutput.Items.Add(lastname + ", " + firstname);
        }
    }
}

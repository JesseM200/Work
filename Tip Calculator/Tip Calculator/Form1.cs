/********************
 * Programer: Jesse Muller
 * Program: Tip Calculater
 * Date: 22/07/2017
 ********************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class frmTipCalculator : Form
    {
        public frmTipCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double TIP = 0.15; //15%
            const double SALES_TAX = 0.07;//7%
            double costOfMeal;
            double totalAmountDue;

            costOfMeal = Convert.ToDouble(txtcost.Text);
            totalAmountDue = costOfMeal + (costOfMeal * TIP) + (costOfMeal * SALES_TAX);

            lsOutput.Items.Add("Cost Of Meal: " + costOfMeal.ToString("C"));
            lsOutput.Items.Add("Sales Tax: " + SALES_TAX.ToString("P"));
            lsOutput.Items.Add("Tip: " + TIP.ToString("P"));
            lsOutput.Items.Add("Total Amount Due: " + totalAmountDue.ToString("C"));
        }
    }
}

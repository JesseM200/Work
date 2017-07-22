/*****************
 * Programer: Jesse Muller
 * Program: PaintJobEstimator
 * 22/07/2017
 ******************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintJobEstimator
{
    public partial class frmPaintJobEstimator : Form
    {
        public frmPaintJobEstimator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int SQUARE_FEET = 115;
            const int HOUR_LABOR_COST = 20;

            decimal feetPaintedPerHour = SQUARE_FEET / 8m;
            decimal gallonsPerFoot = 1m / SQUARE_FEET;

            int squareFeetToPaint = Convert.ToInt32(txtSquareFeet.Text);
            decimal costPerGallon = Convert.ToDecimal(txtCost.Text);

            decimal gallonsNeeded = squareFeetToPaint * gallonsPerFoot;
            decimal laborHoursNeeded = squareFeetToPaint / feetPaintedPerHour;
            decimal costofpaint = gallonsNeeded * costPerGallon;
            decimal laborCharge = laborHoursNeeded * HOUR_LABOR_COST;
            decimal totalCostOfJob = laborCharge + costofpaint;

            lbOutput.Items.Add("Gallons Needed: " + gallonsNeeded.ToString("n2"));
            lbOutput.Items.Add("Hours of Labor Needed: " + laborHoursNeeded.ToString("n2"));
            lbOutput.Items.Add("Cost of paint: " + costofpaint.ToString("C"));
            lbOutput.Items.Add("Labor Charges: " + laborCharge.ToString("C"));
            lbOutput.Items.Add("Total Cost of Job: " + totalCostOfJob.ToString("C"));
        }
    }
}

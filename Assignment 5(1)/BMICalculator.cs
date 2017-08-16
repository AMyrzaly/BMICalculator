using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Abubakir Myrzaly
 * Date: 8/15/2017
 * Description: BMI Calculator
 * Version 0.1 - Created the Project
 */

namespace Assignment_5_1_
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void CalculateBMI_Click(object sender, EventArgs e)
        {
            double result;
            double height;
            double weight;

            try
            {
                height = Convert.ToDouble(heightTextBox.Text);
                weight = Convert.ToDouble(weightTexBox.Text);

                if (imperialRadBtn.Checked == true)
                {
                    result = ((weight * 703)) / ((height * height));
                }
                else if (metricRadBnt.Checked == true)
                {
                    result = (weight / (height * height));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Press OK to coninue");
            }

        }
    }
}

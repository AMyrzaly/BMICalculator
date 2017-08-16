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
            //initialize variables
            double result;
            double height;
            double weight;

            try
            {
                if (HeightTextBox.Text == "" || WeightTextBox.Text == "")
                {
                    MessageBox.Show("Fields can not be empty, please fill them out");

                    if ((HeightTextBox.Text == "") || (HeightTextBox.Text == "" && WeightTextBox.Text == ""))
                    {
                        HeightTextBox.Focus();
                    }
                    else
                    {
                        WeightTextBox.Focus();
                    }
                }

                try
                {
                    height = Convert.ToDouble(HeightTextBox.Text);
                    weight = Convert.ToDouble(WeightTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please type numbers");
                    HeightTextBox.Clear();
                    WeightTextBox.Clear();
                    HeightTextBox.Focus();
                }

                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);

                if (imperialRadBtn.Checked == true)
                {
                    result = ((weight * 703)) / ((height * height));
                    ResultTextBox.Text = Convert.ToString(result);

                    if (result < 18.5)
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Underweight");
                    }

                    if ((result > 18.5) && (result < 24.9))
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Normal");
                    }

                    if ((result > 25) && (result < 29.9))
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Overweight");
                    }

                    if (result > 30)
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Obese");
                    }
                }
                else if (metricRadBnt.Checked == true)
                {
                    result = (weight / (height * height));
                    ResultTextBox.Text = Convert.ToString(result);

                    if (result < 18.5)
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Underweight");
                    }

                    if ((result > 18.5) && (result < 24.9))
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Normal");
                    }

                    if ((result > 25) && (result < 29.9))
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Overweight");
                    }

                    if (result > 30)
                    {
                        ResultInfoTextBox.Text = Convert.ToString("Obese");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Press OK");
            }

        }

        // CLEAR BUTTON
        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            //clear fields
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            ResultTextBox.Clear();
            ResultInfoTextBox.Clear();


            //enable textboxes 
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }
    }
}

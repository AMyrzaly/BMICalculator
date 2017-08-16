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
 * Description: Splash Form
 * Version 0.1 - Created the Project
 */

namespace Assignment_5_1_
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BMICalculator bmicalculator = new BMICalculator();
            bmicalculator.Show();
            this.Hide();

            SplashFormTimer.Enabled = false;
        }
    }
}

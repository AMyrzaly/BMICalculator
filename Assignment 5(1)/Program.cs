using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Abubakir Myrzaly
 * Date: 8/15/2017
 * Description: BMI Calculator
 * Version 0.2 - Stated SplashFormFirst
 */

namespace Assignment_5_1_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}

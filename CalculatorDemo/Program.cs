using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Alvun Quijano
 * Date: Aug 04, 2017
 * Desc: This is a calculator demo
 * Ver: 0.3 - Created an instance of the CalculatorForm class
 */

namespace CalculatorDemo
{
    public static class Program
    {
        // Create Reference to Forms 
        public static CalculatorForm calculatorform;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculatorform = new CalculatorForm(); // Instantiate a new object of type Calculator Form.

            Application.Run(new SplashForm());
        }
    }
}

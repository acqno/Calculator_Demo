using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Alvun Quijano
 * Date: Aug 04, 2017
 * Desc: This is a calculator demo
 * Ver: 0.2 - Starts the SplashForm first
 */

namespace CalculatorDemo
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Alvun Quijano
 * Date: Aug 09, 2017
 * Desc: This is the SplashForm class
 * Ver: 0.2 - Created SplashFormTimer_tick event handler
 */

namespace CalculatorDemo
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashformTimer_Tick(object sender, EventArgs e)
        {
            CalculatorForm calculatorform = new CalculatorForm();
            calculatorform.Show();
            this.Hide();

            SplashformTimer.Enabled = false; // turn timer off 
        }
    }
}

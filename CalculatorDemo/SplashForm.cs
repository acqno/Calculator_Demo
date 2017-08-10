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
 * Ver: 0.4 - Created a public property as an Alias to Program.calculatorForm
 */

namespace CalculatorDemo
{
    public partial class SplashForm : Form
    {

        // PUBLIC PROPERTIES 
        public CalculatorForm CalculatorForm
        {
            get
            {
                return Program.calculatorform;
            }
        }

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
            this.CalculatorForm.Show();
            this.Hide();

            SplashformTimer.Enabled = false; // turn timer off 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    /// <summary>
    /// App Name - Movie Bonanza
    /// Author - Balpreet Punia
    /// Student Id - 200335082
    /// Creation Date - 2017-03-05
    /// Description - This app lets user select a movie to stream and also lets them order a DVD for the same.
    /// </summary>

    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Tick timer for 3 seconds, for the splash screen to stay visible for 3 seconds.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();
            this.SplashTimer.Enabled = false;
            selectionForm.Show();
            this.Hide();
        }
    }
}

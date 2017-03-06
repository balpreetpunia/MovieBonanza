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

    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// To get the values and display them in the stream form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamForm_Load(object sender, EventArgs e)
        {
            //Displaying the values
            StreamLabel2.Text = "Your Credit card will be charged $" + Program.movies.GrandTotal.ToString();
            StreamLabel3.Text = Program.movies.Title + " will begin streaming shortly.";
            StreamLabel2.TextAlign = ContentAlignment.MiddleCenter;
            StreamLabel3.TextAlign = ContentAlignment.MiddleCenter;
        }
        
        /// <summary>
        /// Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

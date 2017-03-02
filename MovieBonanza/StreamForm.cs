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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            StreamLabel2.Text = "Your Credit card will be charged $" + Program.movies.GrandTotal.ToString();
            StreamLabel3.Text = Program.movies.Title + " will begin streaming shortly.";
            StreamLabel2.TextAlign = ContentAlignment.MiddleCenter;
            StreamLabel3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

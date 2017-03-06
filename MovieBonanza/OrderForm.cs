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

    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;

        public OrderForm()
        {
            InitializeComponent();
            //call setForm.
            setForm();

        }

        public void setForm()
        {
            //Sets various values
            TitleTextBox.Text = Program.movies.Title;
            CategoryTextBox.Text = Program.movies.Category;
            CostTextBox.Text = Convert.ToString(Program.movies.Cost);
            ImagePictureBox.Image = Program.movies.Image;

            SubTotalTextBox.Text = (Program.movies.Cost * 1.13).ToString("#.##");
            SalesTaxTextBox.Text = (Program.movies.Cost * 0.13).ToString("#.##");
            GrandTotalTextBox.Text = (Program.movies.Cost * 1.13).ToString("#.##");
        }

        //To update the previous values
        public void updateValue()
        {
            SubTotalTextBox.Text = (Program.movies.Cost * 1.13 + 10).ToString("#.##");
            SalesTaxTextBox.Text = (double.Parse(SubTotalTextBox.Text) * 0.13).ToString("#.##");
            GrandTotalTextBox.Text = (double.Parse(SubTotalTextBox.Text) * 1.13).ToString("#.##");
        }

        //For the dvd property function
        private void DvdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(DvdCheckBox.Checked == true)
            {
                DvdLabel.Visible = true;
                DvdTextBox.Visible = true;
                DvdTextBox.Text = "10.00";
                updateValue();
            }
            else
            {
                DvdLabel.Visible = false;
                DvdTextBox.Visible = false;
                setForm();
            }
        }

        /// <summary>
        /// 
        /// BackButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();

        }

        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Stream
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            Program.movies.GrandTotal = (double.Parse(GrandTotalTextBox.Text) * 1.13).ToString("#.##");
            StreamForm streamForm = new StreamForm();
            streamForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Stream
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void streamStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamButton_Click( sender,  e);
        }

        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelButton_Click(sender, e);
        }

        /// <summary>
        /// Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Page has been sent to the printer.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
        }
    }
}

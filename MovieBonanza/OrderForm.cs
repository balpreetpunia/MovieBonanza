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
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;

        public OrderForm()
        {
            InitializeComponent();
            setForm();

        }

        public void setForm()
        {
            TitleTextBox.Text = Program.movies.Title;
            CategoryTextBox.Text = Program.movies.Category;
            CostTextBox.Text = Convert.ToString(Program.movies.Cost);
            ImagePictureBox.Image = Program.movies.Image;

            SubTotalTextBox.Text = (Program.movies.Cost * 1.13).ToString("#.##");
            SalesTaxTextBox.Text = (Program.movies.Cost * 0.13).ToString("#.##");
            GrandTotalTextBox.Text = (Program.movies.Cost * 1.13).ToString("#.##");
        }

        public void updateValue()
        {
            SubTotalTextBox.Text = (Program.movies.Cost * 1.13 + 10).ToString("#.##");
            SalesTaxTextBox.Text = (double.Parse(SubTotalTextBox.Text) * 0.13).ToString("#.##");
            GrandTotalTextBox.Text = (double.Parse(SubTotalTextBox.Text) * 1.13).ToString("#.##");
        }

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            Program.movies.GrandTotal = (double.Parse(GrandTotalTextBox.Text) * 1.13).ToString("#.##");
            StreamForm streamForm = new StreamForm();
            streamForm.Show();
            this.Hide();
        }
    }
}

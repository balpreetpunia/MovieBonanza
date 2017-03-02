using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }
        

        private void MoviesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            setTitle();
            setImage();
        }

        public void setTitle()
        {
            TitleTextBox.Text = MoviesListBox.Text;
            Program.movies.Title = TitleTextBox.Text;

        }

        public void setImage()
        {
            MoviePictureBox.Image = Properties.Resources.CedarRapids;
        }
    }
}

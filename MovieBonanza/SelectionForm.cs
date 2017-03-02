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
            setCategory();

            NextButton.Enabled = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.movies.Title = TitleTextBox.Text;
            Program.movies.Category = CategoryTextBox.Text;
            Program.movies.Image = MoviePictureBox.Image;

            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        public void setTitle()
        {
            TitleTextBox.Text = MoviesListBox.Text;

        }

        public void setCategory()
        {
            if(MoviesListBox.SelectedIndex == 3 || MoviesListBox.SelectedIndex == 8)
            {
                CategoryTextBox.Text = "New Releases";
                CostTextBox.Text = "4.99";
                Program.movies.Cost = 4.99;
            }
            else if(MoviesListBox.SelectedIndex == 5 || MoviesListBox.SelectedIndex == 10)
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = "2.99";
                Program.movies.Cost = 2.99;
            }
            else if (MoviesListBox.SelectedIndex == 11 || MoviesListBox.SelectedIndex == 0 || 
                MoviesListBox.SelectedIndex == 6 || MoviesListBox.SelectedIndex == 7)
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "1.99";
                Program.movies.Cost = 1.99;
            }
            else if (MoviesListBox.SelectedIndex == 1 || MoviesListBox.SelectedIndex == 18 || 
                MoviesListBox.SelectedIndex == 19)
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "1.99";
                Program.movies.Cost = 1.99;
            }
            else if (MoviesListBox.SelectedIndex == 2 || MoviesListBox.SelectedIndex == 13 ||
                MoviesListBox.SelectedIndex == 14 || MoviesListBox.SelectedIndex == 9 || 
                MoviesListBox.SelectedIndex == 12 || MoviesListBox.SelectedIndex == 15)
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "2.99";
                Program.movies.Cost = 2.99;
            }
            else if (MoviesListBox.SelectedIndex == 16)
            {
                CategoryTextBox.Text = "Horror";
                CostTextBox.Text = "2.99";
                Program.movies.Cost = 2.99;
            }
            else if (MoviesListBox.SelectedIndex == 17)
            {
                CategoryTextBox.Text = "Thriller";
                CostTextBox.Text = "1.99";
                Program.movies.Cost = 1.99;
            }
            else if (MoviesListBox.SelectedIndex == 4)
            {
                CategoryTextBox.Text = "Family";
                CostTextBox.Text = "0.99";
                Program.movies.Cost = 0.99;
            }
        }

        public void setImage()
        {
            if (TitleTextBox.Text == "Cedar Rapids")
            {
                MoviePictureBox.Image = Properties.Resources.CedarRapids;
            }
            else if (TitleTextBox.Text == "The Green Hornet")
            {
                MoviePictureBox.Image = Properties.Resources.TheGreenHornet;
            }
            else if (TitleTextBox.Text == "The Dilemma")
            {
                MoviePictureBox.Image = Properties.Resources.TheDilemma;
            }
            else if (TitleTextBox.Text == "Death Race 2")
            {
                MoviePictureBox.Image = Properties.Resources.DeathRace2;
            }
            else if (TitleTextBox.Text == "Footloose")
            {
                MoviePictureBox.Image = Properties.Resources.Footloose;
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                MoviePictureBox.Image = Properties.Resources.GmoneoAndJuliet;
            }
            else if (TitleTextBox.Text == "I am Number Four")
            {
                MoviePictureBox.Image = Properties.Resources.IAmNum4;
            }
            else if (TitleTextBox.Text == "Just Go With It")
            {
                MoviePictureBox.Image = Properties.Resources.JustGoWithIt;
            }
            else if (TitleTextBox.Text == "No Strings Attached")
            {
                MoviePictureBox.Image = Properties.Resources.NoStrings;
            }
            else if (TitleTextBox.Text == "Real Steel")
            {
                MoviePictureBox.Image = Properties.Resources.RealSteel;
            }
            else if (TitleTextBox.Text == "Sanctum")
            {
                MoviePictureBox.Image = Properties.Resources.Sanctum;
            }
            else if (TitleTextBox.Text == "Season Of The Witch")
            {
                MoviePictureBox.Image = Properties.Resources.SeasonOfTheWitch;
            }
            else if (TitleTextBox.Text == "Company Men")
            {
                MoviePictureBox.Image = Properties.Resources.TheCompanyMen;
            }
            else if (TitleTextBox.Text == "The Eagle")
            {
                MoviePictureBox.Image = Properties.Resources.TheEagle;
            }
            else if (TitleTextBox.Text == "The Mechanic")
            {
                MoviePictureBox.Image = Properties.Resources.TheMechanic;
            }
            else if (TitleTextBox.Text == "The Other Woman")
            {
                MoviePictureBox.Image = Properties.Resources.TheOtherWoman;
            }
            else if (TitleTextBox.Text == "The Rite")
            {
                MoviePictureBox.Image = Properties.Resources.TheRite;
            }
            else if (TitleTextBox.Text == "The Roommate")
            {
                MoviePictureBox.Image = Properties.Resources.TheRoommate;
            }
            else if (TitleTextBox.Text == "The Way Back")
            {
                MoviePictureBox.Image = Properties.Resources.TheWayBack;
            }
            else if (TitleTextBox.Text == "Waiting For Forever")
            {
                MoviePictureBox.Image = Properties.Resources.WaitingForForever;
            }
        }
    }
}

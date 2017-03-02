﻿using System;
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
        public OrderForm()
        {
            InitializeComponent();
            setForm();
        }

        public void setForm()
        {
            TitleTextBox.Text = Program.movies.Title;
            CategoryTextBox.Text = Program.movies.Category;
            ImagePictureBox.Image = Program.movies.Image;
        }
    }
}
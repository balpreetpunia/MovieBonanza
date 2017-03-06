namespace MovieBonanza
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.CausesValidation = false;
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season Of The Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting For Forever"});
            this.MoviesListBox.Location = new System.Drawing.Point(12, 76);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(158, 251);
            this.MoviesListBox.Sorted = true;
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedValueChanged += new System.EventHandler(this.MoviesListBox_SelectedValueChanged);
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(41, 61);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(92, 13);
            this.CurrentMoviesLabel.TabIndex = 1;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.CostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.TitleLabel);
            this.YourSelectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(202, 76);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(450, 216);
            this.YourSelectionGroupBox.TabIndex = 2;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(323, 157);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 6;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(157, 157);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(154, 69);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(269, 20);
            this.TitleTextBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(331, 131);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(32, 13);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(154, 131);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(57, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(151, 38);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(32, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoviePictureBox.Location = new System.Drawing.Point(7, 29);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(110, 155);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the Movie you wist to Stream from the list below.";
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(577, 316);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 351);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Movie";
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
    }
}


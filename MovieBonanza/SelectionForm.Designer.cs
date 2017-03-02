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
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            "Death Race",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back ",
            "Waiting for Forever "});
            this.MoviesListBox.Location = new System.Drawing.Point(12, 76);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(158, 212);
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
            this.YourSelectionGroupBox.Controls.Add(this.textBox3);
            this.YourSelectionGroupBox.Controls.Add(this.textBox2);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.label3);
            this.YourSelectionGroupBox.Controls.Add(this.label2);
            this.YourSelectionGroupBox.Controls.Add(this.label1);
            this.YourSelectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(202, 76);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(450, 216);
            this.YourSelectionGroupBox.TabIndex = 2;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
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
            this.label1.Location = new System.Drawing.Point(151, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(154, 69);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 315);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


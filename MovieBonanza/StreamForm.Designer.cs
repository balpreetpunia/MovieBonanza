namespace MovieBonanza
{
    partial class StreamForm
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
            this.StreamLabel = new System.Windows.Forms.Label();
            this.StreamLabel2 = new System.Windows.Forms.Label();
            this.StreamLabel3 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StreamLabel
            // 
            this.StreamLabel.AutoSize = true;
            this.StreamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamLabel.Location = new System.Drawing.Point(79, 33);
            this.StreamLabel.Name = "StreamLabel";
            this.StreamLabel.Size = new System.Drawing.Size(344, 24);
            this.StreamLabel.TabIndex = 0;
            this.StreamLabel.Text = "Thank you for using Movie Bonanza";
            // 
            // StreamLabel2
            // 
            this.StreamLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreamLabel2.AutoSize = true;
            this.StreamLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamLabel2.Location = new System.Drawing.Point(94, 79);
            this.StreamLabel2.Name = "StreamLabel2";
            this.StreamLabel2.Size = new System.Drawing.Size(121, 20);
            this.StreamLabel2.TabIndex = 1;
            this.StreamLabel2.Text = "StreamLabel2";
            // 
            // StreamLabel3
            // 
            this.StreamLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreamLabel3.AutoSize = true;
            this.StreamLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamLabel3.Location = new System.Drawing.Point(60, 112);
            this.StreamLabel3.Name = "StreamLabel3";
            this.StreamLabel3.Size = new System.Drawing.Size(121, 20);
            this.StreamLabel3.TabIndex = 2;
            this.StreamLabel3.Text = "StreamLabel3";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(182, 159);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(126, 33);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 214);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.StreamLabel3);
            this.Controls.Add(this.StreamLabel2);
            this.Controls.Add(this.StreamLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StreamLabel;
        private System.Windows.Forms.Label StreamLabel2;
        private System.Windows.Forms.Label StreamLabel3;
        private System.Windows.Forms.Button OkButton;
    }
}
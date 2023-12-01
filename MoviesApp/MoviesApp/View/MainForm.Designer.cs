namespace MoviesApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.selectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.titleInfoLabel = new System.Windows.Forms.Label();
            this.yearInfoLabel = new System.Windows.Forms.Label();
            this.ratingInfoLabel = new System.Windows.Forms.Label();
            this.durationInfoLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectedMovieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviesListBox
            // 
            this.moviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.ItemHeight = 16;
            this.moviesListBox.Location = new System.Drawing.Point(16, 15);
            this.moviesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(420, 468);
            this.moviesListBox.TabIndex = 0;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // selectedMovieGroupBox
            // 
            this.selectedMovieGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedMovieGroupBox.Controls.Add(this.titleInfoLabel);
            this.selectedMovieGroupBox.Controls.Add(this.yearInfoLabel);
            this.selectedMovieGroupBox.Controls.Add(this.ratingInfoLabel);
            this.selectedMovieGroupBox.Controls.Add(this.durationInfoLabel);
            this.selectedMovieGroupBox.Controls.Add(this.durationLabel);
            this.selectedMovieGroupBox.Controls.Add(this.ratingLabel);
            this.selectedMovieGroupBox.Controls.Add(this.genreLabel);
            this.selectedMovieGroupBox.Controls.Add(this.yearLabel);
            this.selectedMovieGroupBox.Controls.Add(this.titleLabel);
            this.selectedMovieGroupBox.Controls.Add(this.genreComboBox);
            this.selectedMovieGroupBox.Controls.Add(this.durationTextBox);
            this.selectedMovieGroupBox.Controls.Add(this.ratingTextBox);
            this.selectedMovieGroupBox.Controls.Add(this.yearTextBox);
            this.selectedMovieGroupBox.Controls.Add(this.titleTextBox);
            this.selectedMovieGroupBox.Location = new System.Drawing.Point(445, 15);
            this.selectedMovieGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedMovieGroupBox.Name = "selectedMovieGroupBox";
            this.selectedMovieGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedMovieGroupBox.Size = new System.Drawing.Size(621, 374);
            this.selectedMovieGroupBox.TabIndex = 1;
            this.selectedMovieGroupBox.TabStop = false;
            this.selectedMovieGroupBox.Text = "Selected Movies";
            // 
            // titleInfoLabel
            // 
            this.titleInfoLabel.Location = new System.Drawing.Point(375, 64);
            this.titleInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleInfoLabel.Name = "titleInfoLabel";
            this.titleInfoLabel.Size = new System.Drawing.Size(193, 21);
            this.titleInfoLabel.TabIndex = 13;
            this.titleInfoLabel.Text = "Длина строки меньше 100";
            // 
            // yearInfoLabel
            // 
            this.yearInfoLabel.Location = new System.Drawing.Point(375, 111);
            this.yearInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearInfoLabel.Name = "yearInfoLabel";
            this.yearInfoLabel.Size = new System.Drawing.Size(140, 21);
            this.yearInfoLabel.TabIndex = 12;
            this.yearInfoLabel.Text = "Больше 0";
            // 
            // ratingInfoLabel
            // 
            this.ratingInfoLabel.Location = new System.Drawing.Point(375, 226);
            this.ratingInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingInfoLabel.Name = "ratingInfoLabel";
            this.ratingInfoLabel.Size = new System.Drawing.Size(140, 21);
            this.ratingInfoLabel.TabIndex = 11;
            this.ratingInfoLabel.Text = "От 1 до 10";
            // 
            // durationInfoLabel
            // 
            this.durationInfoLabel.Location = new System.Drawing.Point(375, 278);
            this.durationInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durationInfoLabel.Name = "durationInfoLabel";
            this.durationInfoLabel.Size = new System.Drawing.Size(140, 21);
            this.durationInfoLabel.TabIndex = 10;
            this.durationInfoLabel.Text = "От 1 до 300";
            // 
            // durationLabel
            // 
            this.durationLabel.Location = new System.Drawing.Point(8, 278);
            this.durationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(87, 21);
            this.durationLabel.TabIndex = 9;
            this.durationLabel.Text = "Duration*:";
            this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Location = new System.Drawing.Point(19, 226);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(76, 21);
            this.ratingLabel.TabIndex = 8;
            this.ratingLabel.Text = "Rating*:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(19, 174);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(76, 22);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(19, 114);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(76, 21);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year*:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(19, 60);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title*:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genreComboBox
            // 
            this.genreComboBox.Enabled = false;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(103, 170);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(248, 24);
            this.genreComboBox.TabIndex = 4;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Enabled = false;
            this.durationTextBox.Location = new System.Drawing.Point(103, 274);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(248, 22);
            this.durationTextBox.TabIndex = 3;
            this.durationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Enabled = false;
            this.ratingTextBox.Location = new System.Drawing.Point(103, 223);
            this.ratingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(248, 22);
            this.ratingTextBox.TabIndex = 2;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Enabled = false;
            this.yearTextBox.Location = new System.Drawing.Point(103, 111);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(248, 22);
            this.yearTextBox.TabIndex = 1;
            this.yearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Enabled = false;
            this.titleTextBox.Location = new System.Drawing.Point(103, 60);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(248, 22);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(16, 503);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(32, 30);
            this.addButton.TabIndex = 2;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.Enabled = false;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(81, 503);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(32, 30);
            this.editButton.TabIndex = 3;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditMovieButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(143, 503);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(32, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.acceptButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acceptButton.BackgroundImage")));
            this.acceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(524, 415);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(32, 30);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(464, 415);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(32, 30);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.selectedMovieGroupBox);
            this.Controls.Add(this.moviesListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Movies App";
            this.selectedMovieGroupBox.ResumeLayout(false);
            this.selectedMovieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label durationInfoLabel;
        private System.Windows.Forms.Label ratingInfoLabel;
        private System.Windows.Forms.Label yearInfoLabel;
        private System.Windows.Forms.Label titleInfoLabel;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label durationLabel;

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.ComboBox genreComboBox;

        private System.Windows.Forms.TextBox ratingTextBox;

        private System.Windows.Forms.TextBox yearTextBox;

        private System.Windows.Forms.TextBox titleTextBox;

        private System.Windows.Forms.GroupBox selectedMovieGroupBox;

        private System.Windows.Forms.ListBox moviesListBox;

        #endregion
    }
}
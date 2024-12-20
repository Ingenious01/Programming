﻿namespace Programming.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MoviesBox = new GroupBox();
            NameBox = new TextBox();
            NameLabel = new Label();
            MovieFindButton = new Button();
            RatingBox = new TextBox();
            RatingLabel = new Label();
            GenreBox = new TextBox();
            DurationBox = new TextBox();
            YearBox = new TextBox();
            GenreLabel = new Label();
            DurationLabel = new Label();
            YearLabel = new Label();
            MoviesListBox = new ListBox();
            MoviesBox.SuspendLayout();
            SuspendLayout();
            // 
            // MoviesBox
            // 
            MoviesBox.BackgroundImageLayout = ImageLayout.None;
            MoviesBox.Controls.Add(NameBox);
            MoviesBox.Controls.Add(NameLabel);
            MoviesBox.Controls.Add(MovieFindButton);
            MoviesBox.Controls.Add(RatingBox);
            MoviesBox.Controls.Add(RatingLabel);
            MoviesBox.Controls.Add(GenreBox);
            MoviesBox.Controls.Add(DurationBox);
            MoviesBox.Controls.Add(YearBox);
            MoviesBox.Controls.Add(GenreLabel);
            MoviesBox.Controls.Add(DurationLabel);
            MoviesBox.Controls.Add(YearLabel);
            MoviesBox.Controls.Add(MoviesListBox);
            MoviesBox.Dock = DockStyle.Fill;
            MoviesBox.Location = new Point(0, 0);
            MoviesBox.Name = "MoviesBox";
            MoviesBox.Size = new Size(423, 683);
            MoviesBox.TabIndex = 2;
            MoviesBox.TabStop = false;
            MoviesBox.Text = "Films";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(248, 59);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 12;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(248, 35);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Name";
            // 
            // MovieFindButton
            // 
            MovieFindButton.Location = new Point(248, 409);
            MovieFindButton.Name = "MovieFindButton";
            MovieFindButton.Size = new Size(125, 27);
            MovieFindButton.TabIndex = 9;
            MovieFindButton.Text = "Find";
            MovieFindButton.UseVisualStyleBackColor = true;
            MovieFindButton.Click += FilmMovieButton_Click;
            // 
            // RatingBox
            // 
            RatingBox.Location = new Point(248, 335);
            RatingBox.Name = "RatingBox";
            RatingBox.Size = new Size(125, 27);
            RatingBox.TabIndex = 8;
            RatingBox.TextChanged += RatingBox_TextChanged;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(248, 313);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(52, 20);
            RatingLabel.TabIndex = 7;
            RatingLabel.Text = "Rating";
            // 
            // GenreBox
            // 
            GenreBox.Location = new Point(248, 263);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(125, 27);
            GenreBox.TabIndex = 6;
            GenreBox.TextChanged += GenreBox_TextChanged;
            // 
            // DurationBox
            // 
            DurationBox.Location = new Point(248, 191);
            DurationBox.Name = "DurationBox";
            DurationBox.Size = new Size(125, 27);
            DurationBox.TabIndex = 5;
            DurationBox.TextChanged += DurationBox_TextChanged;
            // 
            // YearBox
            // 
            YearBox.Location = new Point(248, 125);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(125, 27);
            YearBox.TabIndex = 4;
            YearBox.TextChanged += YearBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(248, 241);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(48, 20);
            GenreLabel.TabIndex = 3;
            GenreLabel.Text = "Genre";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(248, 167);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(67, 20);
            DurationLabel.TabIndex = 2;
            DurationLabel.Text = "Duration";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(248, 101);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(37, 20);
            YearLabel.TabIndex = 1;
            YearLabel.Text = "Year";
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 20;
            MoviesListBox.Location = new Point(24, 35);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(167, 264);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MoviesBox);
            Name = "MoviesControl";
            Size = new Size(423, 683);
            MoviesBox.ResumeLayout(false);
            MoviesBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MoviesBox;
        private TextBox NameBox;
        private Label NameLabel;
        private Button MovieFindButton;
        private TextBox RatingBox;
        private Label RatingLabel;
        private TextBox GenreBox;
        private TextBox DurationBox;
        private TextBox YearBox;
        private Label GenreLabel;
        private Label DurationLabel;
        private Label YearLabel;
        private ListBox MoviesListBox;
    }
}

namespace Programming.View.Panels
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
            FilmsBox = new GroupBox();
            NameBox = new TextBox();
            NameLabel = new Label();
            FilmFindButton = new Button();
            RatingBox = new TextBox();
            RatingLabel = new Label();
            GenreBox = new TextBox();
            DurationBox = new TextBox();
            YearBox = new TextBox();
            GenreLabel = new Label();
            DurationLabel = new Label();
            YearLabel = new Label();
            FilmsListBox = new ListBox();
            FilmsBox.SuspendLayout();
            SuspendLayout();
            // 
            // FilmsBox
            // 
            FilmsBox.BackgroundImageLayout = ImageLayout.None;
            FilmsBox.Controls.Add(NameBox);
            FilmsBox.Controls.Add(NameLabel);
            FilmsBox.Controls.Add(FilmFindButton);
            FilmsBox.Controls.Add(RatingBox);
            FilmsBox.Controls.Add(RatingLabel);
            FilmsBox.Controls.Add(GenreBox);
            FilmsBox.Controls.Add(DurationBox);
            FilmsBox.Controls.Add(YearBox);
            FilmsBox.Controls.Add(GenreLabel);
            FilmsBox.Controls.Add(DurationLabel);
            FilmsBox.Controls.Add(YearLabel);
            FilmsBox.Controls.Add(FilmsListBox);
            FilmsBox.Dock = DockStyle.Fill;
            FilmsBox.Location = new Point(0, 0);
            FilmsBox.Name = "FilmsBox";
            FilmsBox.Size = new Size(423, 683);
            FilmsBox.TabIndex = 2;
            FilmsBox.TabStop = false;
            FilmsBox.Text = "Films";
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
            // FilmFindButton
            // 
            FilmFindButton.Location = new Point(248, 409);
            FilmFindButton.Name = "FilmFindButton";
            FilmFindButton.Size = new Size(125, 27);
            FilmFindButton.TabIndex = 9;
            FilmFindButton.Text = "Find";
            FilmFindButton.UseVisualStyleBackColor = true;
            FilmFindButton.Click += FilmFindButton_Click;
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
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 20;
            FilmsListBox.Location = new Point(24, 35);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(167, 264);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmsBox);
            Name = "MoviesControl";
            Size = new Size(423, 683);
            FilmsBox.ResumeLayout(false);
            FilmsBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FilmsBox;
        private TextBox NameBox;
        private Label NameLabel;
        private Button FilmFindButton;
        private TextBox RatingBox;
        private Label RatingLabel;
        private TextBox GenreBox;
        private TextBox DurationBox;
        private TextBox YearBox;
        private Label GenreLabel;
        private Label DurationLabel;
        private Label YearLabel;
        private ListBox FilmsListBox;
    }
}

namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabPage = new System.Windows.Forms.TabControl();
            this.EnumPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EnumerationsBox = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParcingBox = new System.Windows.Forms.GroupBox();
            this.WeekDayParsingButton = new System.Windows.Forms.Button();
            this.ParsingResultLabel = new System.Windows.Forms.Label();
            this.WDParsingLabel = new System.Windows.Forms.Label();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.SeasonHandleBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.FilmsBox = new System.Windows.Forms.GroupBox();
            this.filmFindLabel = new System.Windows.Forms.Label();
            this.FilmFindButton = new System.Windows.Forms.Button();
            this.RatingBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.RectanglesBox = new System.Windows.Forms.GroupBox();
            this.rectanleFindLabel = new System.Windows.Forms.Label();
            this.RectengleFindButton = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.MainTabPage.SuspendLayout();
            this.EnumPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.EnumerationsBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.WeekdayParcingBox.SuspendLayout();
            this.SeasonHandleBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.FilmsBox.SuspendLayout();
            this.RectanglesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.EnumPage);
            this.MainTabPage.Controls.Add(this.ClassesTabPage);
            this.MainTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabPage.Location = new System.Drawing.Point(0, 0);
            this.MainTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.SelectedIndex = 0;
            this.MainTabPage.Size = new System.Drawing.Size(892, 676);
            this.MainTabPage.TabIndex = 0;
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.tableLayoutPanel1);
            this.EnumPage.Location = new System.Drawing.Point(4, 29);
            this.EnumPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumPage.Size = new System.Drawing.Size(884, 643);
            this.EnumPage.TabIndex = 0;
            this.EnumPage.Text = "Enum";
            this.EnumPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EnumerationsBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.07449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.92551F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 635);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // EnumerationsBox
            // 
            this.EnumerationsBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsBox.Controls.Add(this.ValuesTextBox);
            this.EnumerationsBox.Controls.Add(this.ValueLabel);
            this.EnumerationsBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsBox.Controls.Add(this.EnumLabel);
            this.EnumerationsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsBox.Location = new System.Drawing.Point(3, 3);
            this.EnumerationsBox.Name = "EnumerationsBox";
            this.EnumerationsBox.Size = new System.Drawing.Size(872, 394);
            this.EnumerationsBox.TabIndex = 6;
            this.EnumerationsBox.TabStop = false;
            this.EnumerationsBox.Text = "Enumerations";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(203, 58);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(25, 4, 3, 4);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(159, 279);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(390, 34);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(66, 20);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int Value";
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Enabled = false;
            this.ValuesTextBox.Location = new System.Drawing.Point(390, 58);
            this.ValuesTextBox.Margin = new System.Windows.Forms.Padding(25, 4, 3, 4);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(114, 27);
            this.ValuesTextBox.TabIndex = 5;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(203, 34);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(97, 20);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 58);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(159, 279);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(16, 34);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(146, 20);
            this.EnumLabel.TabIndex = 2;
            this.EnumLabel.Text = "Choose enumeration";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.WeekdayParcingBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SeasonHandleBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 400);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 235);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // WeekdayParcingBox
            // 
            this.WeekdayParcingBox.Controls.Add(this.WeekDayParsingButton);
            this.WeekdayParcingBox.Controls.Add(this.ParsingResultLabel);
            this.WeekdayParcingBox.Controls.Add(this.WDParsingLabel);
            this.WeekdayParcingBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayParcingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParcingBox.Location = new System.Drawing.Point(3, 3);
            this.WeekdayParcingBox.Name = "WeekdayParcingBox";
            this.WeekdayParcingBox.Size = new System.Drawing.Size(433, 229);
            this.WeekdayParcingBox.TabIndex = 6;
            this.WeekdayParcingBox.TabStop = false;
            this.WeekdayParcingBox.Text = "Weekday Parcing";
            // 
            // WeekDayParsingButton
            // 
            this.WeekDayParsingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekDayParsingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekDayParsingButton.Location = new System.Drawing.Point(198, 74);
            this.WeekDayParsingButton.Margin = new System.Windows.Forms.Padding(25, 4, 3, 4);
            this.WeekDayParsingButton.Name = "WeekDayParsingButton";
            this.WeekDayParsingButton.Size = new System.Drawing.Size(125, 36);
            this.WeekDayParsingButton.TabIndex = 2;
            this.WeekDayParsingButton.Text = "Parse";
            this.WeekDayParsingButton.UseVisualStyleBackColor = true;
            this.WeekDayParsingButton.Click += new System.EventHandler(this.WeekDayParsingButton_Click);
            // 
            // ParsingResultLabel
            // 
            this.ParsingResultLabel.AutoSize = true;
            this.ParsingResultLabel.Enabled = false;
            this.ParsingResultLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingResultLabel.Location = new System.Drawing.Point(6, 124);
            this.ParsingResultLabel.Name = "ParsingResultLabel";
            this.ParsingResultLabel.Size = new System.Drawing.Size(63, 25);
            this.ParsingResultLabel.TabIndex = 3;
            this.ParsingResultLabel.Text = "label1";
            this.ParsingResultLabel.Visible = false;
            // 
            // WDParsingLabel
            // 
            this.WDParsingLabel.AutoSize = true;
            this.WDParsingLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WDParsingLabel.Location = new System.Drawing.Point(6, 46);
            this.WDParsingLabel.Name = "WDParsingLabel";
            this.WDParsingLabel.Size = new System.Drawing.Size(198, 25);
            this.WDParsingLabel.TabIndex = 0;
            this.WDParsingLabel.Text = "Type value for parsing";
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParsingTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingTextBox.Location = new System.Drawing.Point(6, 77);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(164, 32);
            this.ParsingTextBox.TabIndex = 1;
            // 
            // SeasonHandleBox
            // 
            this.SeasonHandleBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.SeasonHandleBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleBox.Location = new System.Drawing.Point(442, 3);
            this.SeasonHandleBox.Name = "SeasonHandleBox";
            this.SeasonHandleBox.Size = new System.Drawing.Size(433, 229);
            this.SeasonHandleBox.TabIndex = 6;
            this.SeasonHandleBox.TabStop = false;
            this.SeasonHandleBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonButton.Location = new System.Drawing.Point(199, 77);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(125, 35);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonComboBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 77);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(165, 33);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonLabel.Location = new System.Drawing.Point(6, 37);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(142, 25);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.FilmsBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(884, 643);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // FilmsBox
            // 
            this.FilmsBox.Controls.Add(this.filmFindLabel);
            this.FilmsBox.Controls.Add(this.FilmFindButton);
            this.FilmsBox.Controls.Add(this.RatingBox);
            this.FilmsBox.Controls.Add(this.RatingLabel);
            this.FilmsBox.Controls.Add(this.GenreBox);
            this.FilmsBox.Controls.Add(this.DurationBox);
            this.FilmsBox.Controls.Add(this.YearBox);
            this.FilmsBox.Controls.Add(this.GenreLabel);
            this.FilmsBox.Controls.Add(this.DurationLabel);
            this.FilmsBox.Controls.Add(this.YearLabel);
            this.FilmsBox.Controls.Add(this.FilmsListBox);
            this.FilmsBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilmsBox.Location = new System.Drawing.Point(433, 3);
            this.FilmsBox.Name = "FilmsBox";
            this.FilmsBox.Size = new System.Drawing.Size(448, 637);
            this.FilmsBox.TabIndex = 1;
            this.FilmsBox.TabStop = false;
            this.FilmsBox.Text = "Films";
            // 
            // filmFindLabel
            // 
            this.filmFindLabel.AutoSize = true;
            this.filmFindLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmFindLabel.Location = new System.Drawing.Point(245, 373);
            this.filmFindLabel.Name = "filmFindLabel";
            this.filmFindLabel.Size = new System.Drawing.Size(124, 23);
            this.filmFindLabel.TabIndex = 10;
            this.filmFindLabel.Text = "(top rated film)";
            // 
            // FilmFindButton
            // 
            this.FilmFindButton.Location = new System.Drawing.Point(244, 343);
            this.FilmFindButton.Name = "FilmFindButton";
            this.FilmFindButton.Size = new System.Drawing.Size(125, 27);
            this.FilmFindButton.TabIndex = 9;
            this.FilmFindButton.Text = "Find";
            this.FilmFindButton.UseVisualStyleBackColor = true;
            this.FilmFindButton.Click += new System.EventHandler(this.FilmFindButton_Click);
            // 
            // RatingBox
            // 
            this.RatingBox.Location = new System.Drawing.Point(244, 270);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(125, 27);
            this.RatingBox.TabIndex = 8;
            this.RatingBox.TextChanged += new System.EventHandler(this.RatingBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(244, 247);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(52, 20);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(244, 198);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(125, 27);
            this.GenreBox.TabIndex = 6;
            this.GenreBox.TextChanged += new System.EventHandler(this.GenreBox_TextChanged);
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(244, 125);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(125, 27);
            this.DurationBox.TabIndex = 5;
            this.DurationBox.TextChanged += new System.EventHandler(this.DurationBox_TextChanged);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(244, 58);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(125, 27);
            this.YearBox.TabIndex = 4;
            this.YearBox.TextChanged += new System.EventHandler(this.YearBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(244, 175);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 20);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(244, 102);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(67, 20);
            this.DurationLabel.TabIndex = 2;
            this.DurationLabel.Text = "Duration";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(244, 35);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(37, 20);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "Year";
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 20;
            this.FilmsListBox.Location = new System.Drawing.Point(24, 35);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(167, 264);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // RectanglesBox
            // 
            this.RectanglesBox.Controls.Add(this.rectanleFindLabel);
            this.RectanglesBox.Controls.Add(this.RectengleFindButton);
            this.RectanglesBox.Controls.Add(this.ColorBox);
            this.RectanglesBox.Controls.Add(this.WidthBox);
            this.RectanglesBox.Controls.Add(this.LengthBox);
            this.RectanglesBox.Controls.Add(this.ColorLabel);
            this.RectanglesBox.Controls.Add(this.WidthLabel);
            this.RectanglesBox.Controls.Add(this.LengthLabel);
            this.RectanglesBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglesBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesBox.Name = "RectanglesBox";
            this.RectanglesBox.Size = new System.Drawing.Size(424, 637);
            this.RectanglesBox.TabIndex = 0;
            this.RectanglesBox.TabStop = false;
            this.RectanglesBox.Text = "Rectangles";
            // 
            // rectanleFindLabel
            // 
            this.rectanleFindLabel.AutoSize = true;
            this.rectanleFindLabel.Location = new System.Drawing.Point(197, 302);
            this.rectanleFindLabel.Name = "rectanleFindLabel";
            this.rectanleFindLabel.Size = new System.Drawing.Size(203, 20);
            this.rectanleFindLabel.TabIndex = 11;
            this.rectanleFindLabel.Text = "(rectangle with largest width)";
            // 
            // RectengleFindButton
            // 
            this.RectengleFindButton.Location = new System.Drawing.Point(228, 270);
            this.RectengleFindButton.Name = "RectengleFindButton";
            this.RectengleFindButton.Size = new System.Drawing.Size(125, 29);
            this.RectengleFindButton.TabIndex = 7;
            this.RectengleFindButton.Text = "Find";
            this.RectengleFindButton.UseVisualStyleBackColor = true;
            this.RectengleFindButton.Click += new System.EventHandler(this.RectengleFindButton_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(228, 198);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(125, 27);
            this.ColorBox.TabIndex = 6;
            this.ColorBox.TextChanged += new System.EventHandler(this.ColorBox_TextChanged);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(228, 125);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(125, 27);
            this.WidthBox.TabIndex = 5;
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(228, 58);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(125, 27);
            this.LengthBox.TabIndex = 4;
            this.LengthBox.TextChanged += new System.EventHandler(this.LengthBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(228, 175);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 20);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(226, 102);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(226, 35);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(57, 20);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(20, 35);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(167, 264);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 676);
            this.Controls.Add(this.MainTabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 552);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainTabPage.ResumeLayout(false);
            this.EnumPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EnumerationsBox.ResumeLayout(false);
            this.EnumerationsBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.WeekdayParcingBox.ResumeLayout(false);
            this.WeekdayParcingBox.PerformLayout();
            this.SeasonHandleBox.ResumeLayout(false);
            this.SeasonHandleBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.FilmsBox.ResumeLayout(false);
            this.FilmsBox.PerformLayout();
            this.RectanglesBox.ResumeLayout(false);
            this.RectanglesBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabPage;
        private TabPage EnumPage;
        private Label ParsingResultLabel;
        private Button WeekDayParsingButton;
        private TextBox ParsingTextBox;
        private Label WDParsingLabel;
        private GroupBox WeekdayParcingBox;
        private GroupBox EnumerationsBox;
        private ListBox ValuesListBox;
        private Label IntValueLabel;
        private TextBox ValuesTextBox;
        private Label ValueLabel;
        private ListBox EnumsListBox;
        private Label EnumLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox SeasonHandleBox;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
        private TabPage ClassesTabPage;
        private GroupBox RectanglesBox;
        private Button RectengleFindButton;
        private TextBox ColorBox;
        private TextBox WidthBox;
        private TextBox LengthBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
        private ListBox RectanglesListBox;
        private GroupBox FilmsBox;
        private TextBox GenreBox;
        private TextBox DurationBox;
        private TextBox YearBox;
        private Label GenreLabel;
        private Label DurationLabel;
        private Label YearLabel;
        private ListBox FilmsListBox;
        private TextBox RatingBox;
        private Label RatingLabel;
        private Button FilmFindButton;
        private Label filmFindLabel;
        private Label rectanleFindLabel;
    }
}
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
            MainTabPage = new TabControl();
            EnumPage = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            EnumerationsBox = new GroupBox();
            ValuesListBox = new ListBox();
            IntValueLabel = new Label();
            ValuesTextBox = new TextBox();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            EnumLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            WeekdayParcingBox = new GroupBox();
            WeekDayParsingButton = new Button();
            ParsingResultLabel = new Label();
            WDParsingLabel = new Label();
            ParsingTextBox = new TextBox();
            SeasonHandleBox = new GroupBox();
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            ClassesTabPage = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            RectanglesBox = new GroupBox();
            IdBox = new TextBox();
            IdLabel = new Label();
            YBox = new TextBox();
            YCoordinateLabel = new Label();
            XBox = new TextBox();
            XCoordinateLabel = new Label();
            RectengleFindButton = new Button();
            ColorBox = new TextBox();
            WidthBox = new TextBox();
            LengthBox = new TextBox();
            ColorLabel = new Label();
            WidthLabel = new Label();
            LengthLabel = new Label();
            RectanglesListBox = new ListBox();
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
            RectanglesTabPage = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            CoordinatesBox = new GroupBox();
            GeometryRemoveButton = new Button();
            GeometryAddButton = new Button();
            GeometryRectanglesWidthTextBox = new TextBox();
            GeometryWidthLabel = new Label();
            GeometryRectanglesYTextBox = new TextBox();
            GeometryYLabel = new Label();
            GeometryRectanglesHeightTextBox = new TextBox();
            GeometryHeightLabel = new Label();
            GeometryRectanglesXTextBox = new TextBox();
            GeometryXLabel = new Label();
            GeometryRectanglesIdTextBox = new TextBox();
            GeometryIdLabel = new Label();
            label1 = new Label();
            GeometryRectanglesBox = new GroupBox();
            GeometryRectanlesListBox = new ListBox();
            MainTabPage.SuspendLayout();
            EnumPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            EnumerationsBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            WeekdayParcingBox.SuspendLayout();
            SeasonHandleBox.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            RectanglesBox.SuspendLayout();
            FilmsBox.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            CoordinatesBox.SuspendLayout();
            GeometryRectanglesBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabPage
            // 
            MainTabPage.Controls.Add(EnumPage);
            MainTabPage.Controls.Add(ClassesTabPage);
            MainTabPage.Controls.Add(RectanglesTabPage);
            MainTabPage.Dock = DockStyle.Fill;
            MainTabPage.Location = new Point(0, 0);
            MainTabPage.Margin = new Padding(3, 4, 3, 4);
            MainTabPage.Name = "MainTabPage";
            MainTabPage.SelectedIndex = 0;
            MainTabPage.Size = new Size(1072, 680);
            MainTabPage.TabIndex = 0;
            // 
            // EnumPage
            // 
            EnumPage.Controls.Add(tableLayoutPanel1);
            EnumPage.Location = new Point(4, 29);
            EnumPage.Margin = new Padding(3, 4, 3, 4);
            EnumPage.Name = "EnumPage";
            EnumPage.Padding = new Padding(3, 4, 3, 4);
            EnumPage.Size = new Size(1064, 647);
            EnumPage.TabIndex = 0;
            EnumPage.Text = "Enum";
            EnumPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(EnumerationsBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.07449F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.92551F));
            tableLayoutPanel1.Size = new Size(1058, 639);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // EnumerationsBox
            // 
            EnumerationsBox.Controls.Add(ValuesListBox);
            EnumerationsBox.Controls.Add(IntValueLabel);
            EnumerationsBox.Controls.Add(ValuesTextBox);
            EnumerationsBox.Controls.Add(ValueLabel);
            EnumerationsBox.Controls.Add(EnumsListBox);
            EnumerationsBox.Controls.Add(EnumLabel);
            EnumerationsBox.Dock = DockStyle.Fill;
            EnumerationsBox.Location = new Point(3, 3);
            EnumerationsBox.Name = "EnumerationsBox";
            EnumerationsBox.Size = new Size(1052, 397);
            EnumerationsBox.TabIndex = 6;
            EnumerationsBox.TabStop = false;
            EnumerationsBox.Text = "Enumerations";
            // 
            // ValuesListBox
            // 
            ValuesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.IntegralHeight = false;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(203, 59);
            ValuesListBox.Margin = new Padding(25, 4, 3, 4);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(159, 281);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(390, 35);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(66, 20);
            IntValueLabel.TabIndex = 4;
            IntValueLabel.Text = "Int Value";
            // 
            // ValuesTextBox
            // 
            ValuesTextBox.Enabled = false;
            ValuesTextBox.Location = new Point(390, 59);
            ValuesTextBox.Margin = new Padding(25, 4, 3, 4);
            ValuesTextBox.Name = "ValuesTextBox";
            ValuesTextBox.Size = new Size(114, 27);
            ValuesTextBox.TabIndex = 5;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(203, 35);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(97, 20);
            ValueLabel.TabIndex = 3;
            ValueLabel.Text = "Choose value";
            // 
            // EnumsListBox
            // 
            EnumsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.IntegralHeight = false;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Location = new Point(16, 59);
            EnumsListBox.Margin = new Padding(3, 4, 3, 4);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(159, 281);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(16, 35);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(146, 20);
            EnumLabel.TabIndex = 2;
            EnumLabel.Text = "Choose enumeration";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(WeekdayParcingBox, 0, 0);
            tableLayoutPanel2.Controls.Add(SeasonHandleBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 403);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1058, 236);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // WeekdayParcingBox
            // 
            WeekdayParcingBox.Controls.Add(WeekDayParsingButton);
            WeekdayParcingBox.Controls.Add(ParsingResultLabel);
            WeekdayParcingBox.Controls.Add(WDParsingLabel);
            WeekdayParcingBox.Controls.Add(ParsingTextBox);
            WeekdayParcingBox.Dock = DockStyle.Fill;
            WeekdayParcingBox.Location = new Point(3, 3);
            WeekdayParcingBox.Name = "WeekdayParcingBox";
            WeekdayParcingBox.Size = new Size(523, 230);
            WeekdayParcingBox.TabIndex = 6;
            WeekdayParcingBox.TabStop = false;
            WeekdayParcingBox.Text = "Weekday Parcing";
            // 
            // WeekDayParsingButton
            // 
            WeekDayParsingButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WeekDayParsingButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            WeekDayParsingButton.Location = new Point(287, 75);
            WeekDayParsingButton.Margin = new Padding(25, 4, 3, 4);
            WeekDayParsingButton.Name = "WeekDayParsingButton";
            WeekDayParsingButton.Size = new Size(125, 36);
            WeekDayParsingButton.TabIndex = 2;
            WeekDayParsingButton.Text = "Parse";
            WeekDayParsingButton.UseVisualStyleBackColor = true;
            WeekDayParsingButton.Click += WeekDayParsingButton_Click;
            // 
            // ParsingResultLabel
            // 
            ParsingResultLabel.AutoSize = true;
            ParsingResultLabel.Enabled = false;
            ParsingResultLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ParsingResultLabel.Location = new Point(6, 124);
            ParsingResultLabel.Name = "ParsingResultLabel";
            ParsingResultLabel.Size = new Size(63, 25);
            ParsingResultLabel.TabIndex = 3;
            ParsingResultLabel.Text = "label1";
            ParsingResultLabel.Visible = false;
            // 
            // WDParsingLabel
            // 
            WDParsingLabel.AutoSize = true;
            WDParsingLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            WDParsingLabel.Location = new Point(6, 45);
            WDParsingLabel.Name = "WDParsingLabel";
            WDParsingLabel.Size = new Size(198, 25);
            WDParsingLabel.TabIndex = 0;
            WDParsingLabel.Text = "Type value for parsing";
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParsingTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ParsingTextBox.Location = new Point(6, 77);
            ParsingTextBox.Margin = new Padding(3, 4, 3, 4);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(254, 32);
            ParsingTextBox.TabIndex = 1;
            // 
            // SeasonHandleBox
            // 
            SeasonHandleBox.AccessibleRole = AccessibleRole.Client;
            SeasonHandleBox.Controls.Add(SeasonButton);
            SeasonHandleBox.Controls.Add(SeasonComboBox);
            SeasonHandleBox.Controls.Add(SeasonLabel);
            SeasonHandleBox.Dock = DockStyle.Fill;
            SeasonHandleBox.Location = new Point(532, 3);
            SeasonHandleBox.Name = "SeasonHandleBox";
            SeasonHandleBox.Size = new Size(523, 230);
            SeasonHandleBox.TabIndex = 6;
            SeasonHandleBox.TabStop = false;
            SeasonHandleBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            SeasonButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SeasonButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SeasonButton.Location = new Point(289, 77);
            SeasonButton.Margin = new Padding(25, 3, 3, 3);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(125, 35);
            SeasonButton.TabIndex = 2;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SeasonComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 77);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(255, 33);
            SeasonComboBox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SeasonLabel.Location = new Point(6, 37);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(142, 25);
            SeasonLabel.TabIndex = 0;
            SeasonLabel.Text = "Choose season:";
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(tableLayoutPanel3);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(1064, 647);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(RectanglesBox, 0, 0);
            tableLayoutPanel3.Controls.Add(FilmsBox, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1058, 641);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // RectanglesBox
            // 
            RectanglesBox.Controls.Add(IdBox);
            RectanglesBox.Controls.Add(IdLabel);
            RectanglesBox.Controls.Add(YBox);
            RectanglesBox.Controls.Add(YCoordinateLabel);
            RectanglesBox.Controls.Add(XBox);
            RectanglesBox.Controls.Add(XCoordinateLabel);
            RectanglesBox.Controls.Add(RectengleFindButton);
            RectanglesBox.Controls.Add(ColorBox);
            RectanglesBox.Controls.Add(WidthBox);
            RectanglesBox.Controls.Add(LengthBox);
            RectanglesBox.Controls.Add(ColorLabel);
            RectanglesBox.Controls.Add(WidthLabel);
            RectanglesBox.Controls.Add(LengthLabel);
            RectanglesBox.Controls.Add(RectanglesListBox);
            RectanglesBox.Dock = DockStyle.Fill;
            RectanglesBox.Location = new Point(3, 3);
            RectanglesBox.Name = "RectanglesBox";
            RectanglesBox.Size = new Size(523, 635);
            RectanglesBox.TabIndex = 0;
            RectanglesBox.TabStop = false;
            RectanglesBox.Text = "Rectangles";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(21, 335);
            IdBox.Name = "IdBox";
            IdBox.ReadOnly = true;
            IdBox.Size = new Size(125, 27);
            IdBox.TabIndex = 13;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(21, 313);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(24, 20);
            IdLabel.TabIndex = 12;
            IdLabel.Text = "ID";
            // 
            // YBox
            // 
            YBox.Location = new Point(229, 335);
            YBox.Name = "YBox";
            YBox.ReadOnly = true;
            YBox.Size = new Size(125, 27);
            YBox.TabIndex = 11;
            // 
            // YCoordinateLabel
            // 
            YCoordinateLabel.AutoSize = true;
            YCoordinateLabel.Location = new Point(229, 313);
            YCoordinateLabel.Name = "YCoordinateLabel";
            YCoordinateLabel.Size = new Size(101, 20);
            YCoordinateLabel.TabIndex = 10;
            YCoordinateLabel.Text = "Y coordonate:";
            // 
            // XBox
            // 
            XBox.Location = new Point(229, 263);
            XBox.Name = "XBox";
            XBox.ReadOnly = true;
            XBox.Size = new Size(125, 27);
            XBox.TabIndex = 9;
            // 
            // XCoordinateLabel
            // 
            XCoordinateLabel.AutoSize = true;
            XCoordinateLabel.Location = new Point(229, 241);
            XCoordinateLabel.Name = "XCoordinateLabel";
            XCoordinateLabel.Size = new Size(102, 20);
            XCoordinateLabel.TabIndex = 8;
            XCoordinateLabel.Text = "X coordonate:";
            // 
            // RectengleFindButton
            // 
            RectengleFindButton.Location = new Point(229, 407);
            RectengleFindButton.Name = "RectengleFindButton";
            RectengleFindButton.Size = new Size(125, 29);
            RectengleFindButton.TabIndex = 7;
            RectengleFindButton.Text = "Find";
            RectengleFindButton.UseVisualStyleBackColor = true;
            RectengleFindButton.Click += RectengleFindButton_Click;
            // 
            // ColorBox
            // 
            ColorBox.Location = new Point(229, 197);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(125, 27);
            ColorBox.TabIndex = 6;
            ColorBox.TextChanged += ColorBox_TextChanged;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(229, 125);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(125, 27);
            WidthBox.TabIndex = 5;
            WidthBox.TextChanged += WidthBox_TextChanged;
            // 
            // LengthBox
            // 
            LengthBox.Location = new Point(229, 59);
            LengthBox.Name = "LengthBox";
            LengthBox.Size = new Size(125, 27);
            LengthBox.TabIndex = 4;
            LengthBox.TextChanged += LengthBox_TextChanged;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(229, 175);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(48, 20);
            ColorLabel.TabIndex = 3;
            ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(226, 101);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 2;
            WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(226, 35);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(57, 20);
            LengthLabel.TabIndex = 1;
            LengthLabel.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 20;
            RectanglesListBox.Location = new Point(21, 35);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(167, 264);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
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
            FilmsBox.Location = new Point(532, 3);
            FilmsBox.Name = "FilmsBox";
            FilmsBox.Size = new Size(523, 635);
            FilmsBox.TabIndex = 1;
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
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(tableLayoutPanel4);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(1064, 647);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1058, 641);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(CoordinatesBox, 0, 1);
            tableLayoutPanel5.Controls.Add(GeometryRectanglesBox, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(470, 635);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // CoordinatesBox
            // 
            CoordinatesBox.Controls.Add(GeometryRemoveButton);
            CoordinatesBox.Controls.Add(GeometryAddButton);
            CoordinatesBox.Controls.Add(GeometryRectanglesWidthTextBox);
            CoordinatesBox.Controls.Add(GeometryWidthLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesYTextBox);
            CoordinatesBox.Controls.Add(GeometryYLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesHeightTextBox);
            CoordinatesBox.Controls.Add(GeometryHeightLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesXTextBox);
            CoordinatesBox.Controls.Add(GeometryXLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesIdTextBox);
            CoordinatesBox.Controls.Add(GeometryIdLabel);
            CoordinatesBox.Controls.Add(label1);
            CoordinatesBox.Dock = DockStyle.Fill;
            CoordinatesBox.Location = new Point(3, 320);
            CoordinatesBox.Name = "CoordinatesBox";
            CoordinatesBox.Size = new Size(464, 312);
            CoordinatesBox.TabIndex = 1;
            CoordinatesBox.TabStop = false;
            CoordinatesBox.Text = "Coordinates and stuff";
            // 
            // GeometryRemoveButton
            // 
            GeometryRemoveButton.Image = (Image)resources.GetObject("GeometryRemoveButton.Image");
            GeometryRemoveButton.Location = new Point(342, 137);
            GeometryRemoveButton.Name = "GeometryRemoveButton";
            GeometryRemoveButton.Size = new Size(96, 94);
            GeometryRemoveButton.TabIndex = 12;
            GeometryRemoveButton.UseVisualStyleBackColor = true;
            GeometryRemoveButton.Click += GeometryRemoveButton_Click;
            // 
            // GeometryAddButton
            // 
            GeometryAddButton.Image = (Image)resources.GetObject("GeometryAddButton.Image");
            GeometryAddButton.Location = new Point(224, 137);
            GeometryAddButton.Name = "GeometryAddButton";
            GeometryAddButton.Size = new Size(96, 94);
            GeometryAddButton.TabIndex = 11;
            GeometryAddButton.UseVisualStyleBackColor = true;
            GeometryAddButton.Click += GeometryAddButton_Click;
            // 
            // GeometryRectanglesWidthTextBox
            // 
            GeometryRectanglesWidthTextBox.Location = new Point(77, 200);
            GeometryRectanglesWidthTextBox.Name = "GeometryRectanglesWidthTextBox";
            GeometryRectanglesWidthTextBox.Size = new Size(125, 27);
            GeometryRectanglesWidthTextBox.TabIndex = 10;
            // 
            // GeometryWidthLabel
            // 
            GeometryWidthLabel.AutoSize = true;
            GeometryWidthLabel.Location = new Point(9, 207);
            GeometryWidthLabel.Name = "GeometryWidthLabel";
            GeometryWidthLabel.Size = new Size(52, 20);
            GeometryWidthLabel.TabIndex = 9;
            GeometryWidthLabel.Text = "Width:";
            // 
            // GeometryRectanglesYTextBox
            // 
            GeometryRectanglesYTextBox.Location = new Point(77, 167);
            GeometryRectanglesYTextBox.Name = "GeometryRectanglesYTextBox";
            GeometryRectanglesYTextBox.Size = new Size(125, 27);
            GeometryRectanglesYTextBox.TabIndex = 8;
            // 
            // GeometryYLabel
            // 
            GeometryYLabel.AutoSize = true;
            GeometryYLabel.Location = new Point(41, 174);
            GeometryYLabel.Name = "GeometryYLabel";
            GeometryYLabel.Size = new Size(20, 20);
            GeometryYLabel.TabIndex = 7;
            GeometryYLabel.Text = "Y:";
            // 
            // GeometryRectanglesHeightTextBox
            // 
            GeometryRectanglesHeightTextBox.Location = new Point(77, 233);
            GeometryRectanglesHeightTextBox.Name = "GeometryRectanglesHeightTextBox";
            GeometryRectanglesHeightTextBox.Size = new Size(125, 27);
            GeometryRectanglesHeightTextBox.TabIndex = 6;
            // 
            // GeometryHeightLabel
            // 
            GeometryHeightLabel.AutoSize = true;
            GeometryHeightLabel.Location = new Point(4, 240);
            GeometryHeightLabel.Name = "GeometryHeightLabel";
            GeometryHeightLabel.Size = new Size(57, 20);
            GeometryHeightLabel.TabIndex = 5;
            GeometryHeightLabel.Text = "Height:";
            // 
            // GeometryRectanglesXTextBox
            // 
            GeometryRectanglesXTextBox.Location = new Point(77, 134);
            GeometryRectanglesXTextBox.Name = "GeometryRectanglesXTextBox";
            GeometryRectanglesXTextBox.Size = new Size(125, 27);
            GeometryRectanglesXTextBox.TabIndex = 4;
            // 
            // GeometryXLabel
            // 
            GeometryXLabel.AutoSize = true;
            GeometryXLabel.Location = new Point(40, 141);
            GeometryXLabel.Name = "GeometryXLabel";
            GeometryXLabel.Size = new Size(21, 20);
            GeometryXLabel.TabIndex = 3;
            GeometryXLabel.Text = "X:";
            // 
            // GeometryRectanglesIdTextBox
            // 
            GeometryRectanglesIdTextBox.Location = new Point(77, 101);
            GeometryRectanglesIdTextBox.Name = "GeometryRectanglesIdTextBox";
            GeometryRectanglesIdTextBox.Size = new Size(125, 27);
            GeometryRectanglesIdTextBox.TabIndex = 2;
            // 
            // GeometryIdLabel
            // 
            GeometryIdLabel.AutoSize = true;
            GeometryIdLabel.Location = new Point(36, 108);
            GeometryIdLabel.Name = "GeometryIdLabel";
            GeometryIdLabel.Size = new Size(25, 20);
            GeometryIdLabel.TabIndex = 1;
            GeometryIdLabel.Text = "Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Selected Rectangle:";
            // 
            // GeometryRectanglesBox
            // 
            GeometryRectanglesBox.Controls.Add(GeometryRectanlesListBox);
            GeometryRectanglesBox.Dock = DockStyle.Fill;
            GeometryRectanglesBox.Location = new Point(3, 3);
            GeometryRectanglesBox.Name = "GeometryRectanglesBox";
            GeometryRectanglesBox.Size = new Size(464, 311);
            GeometryRectanglesBox.TabIndex = 2;
            GeometryRectanglesBox.TabStop = false;
            GeometryRectanglesBox.Text = "Rectangles:";
           
            // 
            // GeometryRectanlesListBox
            // 
            GeometryRectanlesListBox.Dock = DockStyle.Fill;
            GeometryRectanlesListBox.FormattingEnabled = true;
            GeometryRectanlesListBox.ItemHeight = 20;
            GeometryRectanlesListBox.Location = new Point(3, 23);
            GeometryRectanlesListBox.Name = "GeometryRectanlesListBox";
            GeometryRectanlesListBox.Size = new Size(458, 285);
            GeometryRectanlesListBox.TabIndex = 0;
            GeometryRectanlesListBox.SelectedIndexChanged += GeometryRectanlesListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1072, 680);
            Controls.Add(MainTabPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            MinimumSize = new Size(849, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            MainTabPage.ResumeLayout(false);
            EnumPage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            EnumerationsBox.ResumeLayout(false);
            EnumerationsBox.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            WeekdayParcingBox.ResumeLayout(false);
            WeekdayParcingBox.PerformLayout();
            SeasonHandleBox.ResumeLayout(false);
            SeasonHandleBox.PerformLayout();
            ClassesTabPage.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            RectanglesBox.ResumeLayout(false);
            RectanglesBox.PerformLayout();
            FilmsBox.ResumeLayout(false);
            FilmsBox.PerformLayout();
            RectanglesTabPage.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            CoordinatesBox.ResumeLayout(false);
            CoordinatesBox.PerformLayout();
            GeometryRectanglesBox.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox NameBox;
        private Label NameLabel;
        private TabPage RectanglesTabPage;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox CoordinatesBox;
        private TextBox XBox;
        private Label XCoordinateLabel;
        private TextBox YBox;
        private Label YCoordinateLabel;
        private TextBox IdBox;
        private Label IdLabel;
        private GroupBox GeometryRectanglesBox;
        private ListBox GeometryRectanlesListBox;
        private TextBox GeometryRectanglesWidthTextBox;
        private Label GeometryWidthLabel;
        private TextBox GeometryRectanglesYTextBox;
        private Label GeometryYLabel;
        private TextBox GeometryRectanglesHeightTextBox;
        private Label GeometryHeightLabel;
        private TextBox GeometryRectanglesXTextBox;
        private Label GeometryXLabel;
        private TextBox GeometryRectanglesIdTextBox;
        private Label GeometryIdLabel;
        private Label label1;
        private Button GeometryRemoveButton;
        private Button GeometryAddButton;
    }
}
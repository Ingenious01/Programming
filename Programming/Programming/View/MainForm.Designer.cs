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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
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
            this.MainTabPage.SuspendLayout();
            this.EnumPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.EnumerationsBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.WeekdayParcingBox.SuspendLayout();
            this.SeasonHandleBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.RectanglesBox.SuspendLayout();
            this.FilmsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.EnumPage);
            this.MainTabPage.Controls.Add(this.ClassesTabPage);
            this.MainTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabPage.Location = new System.Drawing.Point(0, 0);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.SelectedIndex = 0;
            this.MainTabPage.Size = new System.Drawing.Size(780, 507);
            this.MainTabPage.TabIndex = 0;
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.tableLayoutPanel1);
            this.EnumPage.Location = new System.Drawing.Point(4, 24);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumPage.Size = new System.Drawing.Size(772, 479);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.07449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.92551F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 473);
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
            this.EnumerationsBox.Location = new System.Drawing.Point(3, 2);
            this.EnumerationsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumerationsBox.Name = "EnumerationsBox";
            this.EnumerationsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumerationsBox.Size = new System.Drawing.Size(760, 294);
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
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(178, 44);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(22, 3, 3, 3);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(140, 208);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(341, 26);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(52, 15);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int Value";
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Enabled = false;
            this.ValuesTextBox.Location = new System.Drawing.Point(341, 44);
            this.ValuesTextBox.Margin = new System.Windows.Forms.Padding(22, 3, 3, 3);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(100, 23);
            this.ValuesTextBox.TabIndex = 5;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(178, 26);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(78, 15);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(14, 44);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(140, 208);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(14, 26);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(118, 15);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 298);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 175);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // WeekdayParcingBox
            // 
            this.WeekdayParcingBox.Controls.Add(this.WeekDayParsingButton);
            this.WeekdayParcingBox.Controls.Add(this.ParsingResultLabel);
            this.WeekdayParcingBox.Controls.Add(this.WDParsingLabel);
            this.WeekdayParcingBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayParcingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParcingBox.Location = new System.Drawing.Point(3, 2);
            this.WeekdayParcingBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParcingBox.Name = "WeekdayParcingBox";
            this.WeekdayParcingBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParcingBox.Size = new System.Drawing.Size(377, 171);
            this.WeekdayParcingBox.TabIndex = 6;
            this.WeekdayParcingBox.TabStop = false;
            this.WeekdayParcingBox.Text = "Weekday Parcing";
            // 
            // WeekDayParsingButton
            // 
            this.WeekDayParsingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekDayParsingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekDayParsingButton.Location = new System.Drawing.Point(171, 56);
            this.WeekDayParsingButton.Margin = new System.Windows.Forms.Padding(22, 3, 3, 3);
            this.WeekDayParsingButton.Name = "WeekDayParsingButton";
            this.WeekDayParsingButton.Size = new System.Drawing.Size(109, 27);
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
            this.ParsingResultLabel.Location = new System.Drawing.Point(5, 93);
            this.ParsingResultLabel.Name = "ParsingResultLabel";
            this.ParsingResultLabel.Size = new System.Drawing.Size(50, 20);
            this.ParsingResultLabel.TabIndex = 3;
            this.ParsingResultLabel.Text = "label1";
            this.ParsingResultLabel.Visible = false;
            // 
            // WDParsingLabel
            // 
            this.WDParsingLabel.AutoSize = true;
            this.WDParsingLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WDParsingLabel.Location = new System.Drawing.Point(5, 34);
            this.WDParsingLabel.Name = "WDParsingLabel";
            this.WDParsingLabel.Size = new System.Drawing.Size(155, 20);
            this.WDParsingLabel.TabIndex = 0;
            this.WDParsingLabel.Text = "Type value for parsing";
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParsingTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingTextBox.Location = new System.Drawing.Point(5, 58);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(142, 27);
            this.ParsingTextBox.TabIndex = 1;
            // 
            // SeasonHandleBox
            // 
            this.SeasonHandleBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.SeasonHandleBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleBox.Location = new System.Drawing.Point(386, 2);
            this.SeasonHandleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleBox.Name = "SeasonHandleBox";
            this.SeasonHandleBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleBox.Size = new System.Drawing.Size(377, 171);
            this.SeasonHandleBox.TabIndex = 6;
            this.SeasonHandleBox.TabStop = false;
            this.SeasonHandleBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonButton.Location = new System.Drawing.Point(172, 58);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(22, 2, 3, 2);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(109, 26);
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
            this.SeasonComboBox.Location = new System.Drawing.Point(5, 58);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(143, 28);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonLabel.Location = new System.Drawing.Point(5, 28);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(110, 20);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel3);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(772, 479);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RectanglesBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.FilmsBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(766, 475);
            this.tableLayoutPanel3.TabIndex = 12;
           
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
            this.RectanglesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesBox.Location = new System.Drawing.Point(3, 2);
            this.RectanglesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesBox.Name = "RectanglesBox";
            this.RectanglesBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesBox.Size = new System.Drawing.Size(377, 471);
            this.RectanglesBox.TabIndex = 0;
            this.RectanglesBox.TabStop = false;
            this.RectanglesBox.Text = "Rectangles";
            // 
            // rectanleFindLabel
            // 
            this.rectanleFindLabel.AutoSize = true;
            this.rectanleFindLabel.Location = new System.Drawing.Point(172, 226);
            this.rectanleFindLabel.Name = "rectanleFindLabel";
            this.rectanleFindLabel.Size = new System.Drawing.Size(161, 15);
            this.rectanleFindLabel.TabIndex = 11;
            this.rectanleFindLabel.Text = "(rectangle with largest width)";
            // 
            // RectengleFindButton
            // 
            this.RectengleFindButton.Location = new System.Drawing.Point(200, 202);
            this.RectengleFindButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectengleFindButton.Name = "RectengleFindButton";
            this.RectengleFindButton.Size = new System.Drawing.Size(109, 22);
            this.RectengleFindButton.TabIndex = 7;
            this.RectengleFindButton.Text = "Find";
            this.RectengleFindButton.UseVisualStyleBackColor = true;
            this.RectengleFindButton.Click += new System.EventHandler(this.RectengleFindButton_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(200, 148);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(110, 23);
            this.ColorBox.TabIndex = 6;
            this.ColorBox.TextChanged += new System.EventHandler(this.ColorBox_TextChanged);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(200, 94);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(110, 23);
            this.WidthBox.TabIndex = 5;
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(200, 44);
            this.LengthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(110, 23);
            this.LengthBox.TabIndex = 4;
            this.LengthBox.TextChanged += new System.EventHandler(this.LengthBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(200, 131);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(39, 15);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(198, 76);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(198, 26);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(47, 15);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(18, 26);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(147, 199);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
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
            this.FilmsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsBox.Location = new System.Drawing.Point(386, 2);
            this.FilmsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmsBox.Name = "FilmsBox";
            this.FilmsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmsBox.Size = new System.Drawing.Size(377, 471);
            this.FilmsBox.TabIndex = 1;
            this.FilmsBox.TabStop = false;
            this.FilmsBox.Text = "Films";
            // 
            // filmFindLabel
            // 
            this.filmFindLabel.AutoSize = true;
            this.filmFindLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmFindLabel.Location = new System.Drawing.Point(214, 280);
            this.filmFindLabel.Name = "filmFindLabel";
            this.filmFindLabel.Size = new System.Drawing.Size(100, 19);
            this.filmFindLabel.TabIndex = 10;
            this.filmFindLabel.Text = "(top rated film)";
            // 
            // FilmFindButton
            // 
            this.FilmFindButton.Location = new System.Drawing.Point(214, 257);
            this.FilmFindButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmFindButton.Name = "FilmFindButton";
            this.FilmFindButton.Size = new System.Drawing.Size(109, 20);
            this.FilmFindButton.TabIndex = 9;
            this.FilmFindButton.Text = "Find";
            this.FilmFindButton.UseVisualStyleBackColor = true;
            this.FilmFindButton.Click += new System.EventHandler(this.FilmFindButton_Click);
            // 
            // RatingBox
            // 
            this.RatingBox.Location = new System.Drawing.Point(214, 202);
            this.RatingBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(110, 23);
            this.RatingBox.TabIndex = 8;
            this.RatingBox.TextChanged += new System.EventHandler(this.RatingBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(214, 185);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 15);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(214, 148);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(110, 23);
            this.GenreBox.TabIndex = 6;
            this.GenreBox.TextChanged += new System.EventHandler(this.GenreBox_TextChanged);
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(214, 94);
            this.DurationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(110, 23);
            this.DurationBox.TabIndex = 5;
            this.DurationBox.TextChanged += new System.EventHandler(this.DurationBox_TextChanged);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(214, 44);
            this.YearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(110, 23);
            this.YearBox.TabIndex = 4;
            this.YearBox.TextChanged += new System.EventHandler(this.YearBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(214, 131);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(38, 15);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(214, 76);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(53, 15);
            this.DurationLabel.TabIndex = 2;
            this.DurationLabel.Text = "Duration";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(214, 26);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 15);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "Year";
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 15;
            this.FilmsListBox.Location = new System.Drawing.Point(21, 26);
            this.FilmsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(147, 199);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(780, 507);
            this.Controls.Add(this.MainTabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(745, 424);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.RectanglesBox.ResumeLayout(false);
            this.RectanglesBox.PerformLayout();
            this.FilmsBox.ResumeLayout(false);
            this.FilmsBox.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel3;
    }
}
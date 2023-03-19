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
            this.EnumsTabPage = new System.Windows.Forms.TabControl();
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
            this.ClasseTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesBox = new System.Windows.Forms.GroupBox();
            this.EnumsTabPage.SuspendLayout();
            this.EnumPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.EnumerationsBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.WeekdayParcingBox.SuspendLayout();
            this.SeasonHandleBox.SuspendLayout();
            this.ClasseTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.EnumPage);
            this.EnumsTabPage.Controls.Add(this.ClasseTabPage);
            this.EnumsTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabPage.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.SelectedIndex = 0;
            this.EnumsTabPage.Size = new System.Drawing.Size(892, 676);
            this.EnumsTabPage.TabIndex = 0;
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
            // ClasseTabPage
            // 
            this.ClasseTabPage.Controls.Add(this.RectanglesBox);
            this.ClasseTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClasseTabPage.Name = "ClasseTabPage";
            this.ClasseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClasseTabPage.Size = new System.Drawing.Size(884, 643);
            this.ClasseTabPage.TabIndex = 1;
            this.ClasseTabPage.Text = "Classe";
            this.ClasseTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesBox
            // 
            this.RectanglesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesBox.Name = "RectanglesBox";
            this.RectanglesBox.Size = new System.Drawing.Size(878, 637);
            this.RectanglesBox.TabIndex = 0;
            this.RectanglesBox.TabStop = false;
            this.RectanglesBox.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 676);
            this.Controls.Add(this.EnumsTabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 552);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EnumerationsBox.ResumeLayout(false);
            this.EnumerationsBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.WeekdayParcingBox.ResumeLayout(false);
            this.WeekdayParcingBox.PerformLayout();
            this.SeasonHandleBox.ResumeLayout(false);
            this.SeasonHandleBox.PerformLayout();
            this.ClasseTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabPage;
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
        private TabPage ClasseTabPage;
        private GroupBox RectanglesBox;
    }
}
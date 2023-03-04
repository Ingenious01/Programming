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
            this.EnumsTabPage = new System.Windows.Forms.TabControl();
            this.EnumPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleTabControl = new System.Windows.Forms.TabControl();
            this.SeasonHandle = new System.Windows.Forms.TabPage();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WDParsingTabControl = new System.Windows.Forms.TabControl();
            this.WeekDayParsingTabControl = new System.Windows.Forms.TabPage();
            this.ParsingResultLabel = new System.Windows.Forms.Label();
            this.WeekDayParsingButton = new System.Windows.Forms.Button();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.WDParsingLabel = new System.Windows.Forms.Label();
            this.EnumerationTabControl = new System.Windows.Forms.TabControl();
            this.EnumerationPage = new System.Windows.Forms.TabPage();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabPage.SuspendLayout();
            this.EnumPage.SuspendLayout();
            this.SeasonHandleTabControl.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.WDParsingTabControl.SuspendLayout();
            this.WeekDayParsingTabControl.SuspendLayout();
            this.EnumerationTabControl.SuspendLayout();
            this.EnumerationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumsTabPage.Controls.Add(this.EnumPage);
            this.EnumsTabPage.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.SelectedIndex = 0;
            this.EnumsTabPage.Size = new System.Drawing.Size(941, 771);
            this.EnumsTabPage.TabIndex = 0;
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.SeasonHandleTabControl);
            this.EnumPage.Controls.Add(this.WDParsingTabControl);
            this.EnumPage.Controls.Add(this.EnumerationTabControl);
            this.EnumPage.Location = new System.Drawing.Point(4, 29);
            this.EnumPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumPage.Size = new System.Drawing.Size(933, 738);
            this.EnumPage.TabIndex = 0;
            this.EnumPage.Text = "Enum";
            this.EnumPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleTabControl
            // 
            this.SeasonHandleTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleTabControl.Controls.Add(this.SeasonHandle);
            this.SeasonHandleTabControl.Location = new System.Drawing.Point(469, 437);
            this.SeasonHandleTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeasonHandleTabControl.Name = "SeasonHandleTabControl";
            this.SeasonHandleTabControl.SelectedIndex = 0;
            this.SeasonHandleTabControl.Size = new System.Drawing.Size(434, 263);
            this.SeasonHandleTabControl.TabIndex = 7;
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Controls.Add(this.SeasonComboBox);
            this.SeasonHandle.Controls.Add(this.SeasonButton);
            this.SeasonHandle.Controls.Add(this.SeasonLabel);
            this.SeasonHandle.Location = new System.Drawing.Point(4, 29);
            this.SeasonHandle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeasonHandle.Size = new System.Drawing.Size(426, 230);
            this.SeasonHandle.TabIndex = 0;
            this.SeasonHandle.Text = "SeasonHandle";
            this.SeasonHandle.UseVisualStyleBackColor = true;
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(25, 52);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(184, 28);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonButton.Location = new System.Drawing.Point(240, 48);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(125, 36);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonLabel.Location = new System.Drawing.Point(25, 17);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(142, 25);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WDParsingTabControl
            // 
            this.WDParsingTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WDParsingTabControl.Controls.Add(this.WeekDayParsingTabControl);
            this.WDParsingTabControl.Location = new System.Drawing.Point(8, 437);
            this.WDParsingTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WDParsingTabControl.Name = "WDParsingTabControl";
            this.WDParsingTabControl.SelectedIndex = 0;
            this.WDParsingTabControl.Size = new System.Drawing.Size(438, 263);
            this.WDParsingTabControl.TabIndex = 6;
            // 
            // WeekDayParsingTabControl
            // 
            this.WeekDayParsingTabControl.Controls.Add(this.ParsingResultLabel);
            this.WeekDayParsingTabControl.Controls.Add(this.WeekDayParsingButton);
            this.WeekDayParsingTabControl.Controls.Add(this.ParsingTextBox);
            this.WeekDayParsingTabControl.Controls.Add(this.WDParsingLabel);
            this.WeekDayParsingTabControl.Location = new System.Drawing.Point(4, 29);
            this.WeekDayParsingTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeekDayParsingTabControl.Name = "WeekDayParsingTabControl";
            this.WeekDayParsingTabControl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeekDayParsingTabControl.Size = new System.Drawing.Size(430, 230);
            this.WeekDayParsingTabControl.TabIndex = 0;
            this.WeekDayParsingTabControl.Text = "WeekDay Parsing";
            this.WeekDayParsingTabControl.UseVisualStyleBackColor = true;
            // 
            // ParsingResultLabel
            // 
            this.ParsingResultLabel.AutoSize = true;
            this.ParsingResultLabel.Enabled = false;
            this.ParsingResultLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingResultLabel.Location = new System.Drawing.Point(18, 88);
            this.ParsingResultLabel.Name = "ParsingResultLabel";
            this.ParsingResultLabel.Size = new System.Drawing.Size(63, 25);
            this.ParsingResultLabel.TabIndex = 3;
            this.ParsingResultLabel.Text = "label1";
            this.ParsingResultLabel.Visible = false;
            // 
            // WeekDayParsingButton
            // 
            this.WeekDayParsingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekDayParsingButton.Location = new System.Drawing.Point(266, 48);
            this.WeekDayParsingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeekDayParsingButton.Name = "WeekDayParsingButton";
            this.WeekDayParsingButton.Size = new System.Drawing.Size(125, 36);
            this.WeekDayParsingButton.TabIndex = 2;
            this.WeekDayParsingButton.Text = "Parse";
            this.WeekDayParsingButton.UseVisualStyleBackColor = true;
            this.WeekDayParsingButton.Click += new System.EventHandler(this.WeekDayParsingButton_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingTextBox.Location = new System.Drawing.Point(18, 48);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(230, 32);
            this.ParsingTextBox.TabIndex = 1;
            // 
            // WDParsingLabel
            // 
            this.WDParsingLabel.AutoSize = true;
            this.WDParsingLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WDParsingLabel.Location = new System.Drawing.Point(18, 17);
            this.WDParsingLabel.Name = "WDParsingLabel";
            this.WDParsingLabel.Size = new System.Drawing.Size(198, 25);
            this.WDParsingLabel.TabIndex = 0;
            this.WDParsingLabel.Text = "Type value for parsing";
            // 
            // EnumerationTabControl
            // 
            this.EnumerationTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationTabControl.Controls.Add(this.EnumerationPage);
            this.EnumerationTabControl.Location = new System.Drawing.Point(3, 4);
            this.EnumerationTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumerationTabControl.Name = "EnumerationTabControl";
            this.EnumerationTabControl.SelectedIndex = 0;
            this.EnumerationTabControl.Size = new System.Drawing.Size(898, 411);
            this.EnumerationTabControl.TabIndex = 0;
            // 
            // EnumerationPage
            // 
            this.EnumerationPage.Controls.Add(this.ValuesTextBox);
            this.EnumerationPage.Controls.Add(this.IntValueLabel);
            this.EnumerationPage.Controls.Add(this.ValueLabel);
            this.EnumerationPage.Controls.Add(this.EnumLabel);
            this.EnumerationPage.Controls.Add(this.ValuesListBox);
            this.EnumerationPage.Controls.Add(this.EnumsListBox);
            this.EnumerationPage.Location = new System.Drawing.Point(4, 29);
            this.EnumerationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumerationPage.Name = "EnumerationPage";
            this.EnumerationPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumerationPage.Size = new System.Drawing.Size(890, 378);
            this.EnumerationPage.TabIndex = 0;
            this.EnumerationPage.Text = "Enumeration";
            this.EnumerationPage.UseVisualStyleBackColor = true;
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Enabled = false;
            this.ValuesTextBox.Location = new System.Drawing.Point(437, 41);
            this.ValuesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(114, 27);
            this.ValuesTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(437, 17);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(66, 20);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int Value";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(229, 17);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(97, 20);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value";
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(23, 17);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(146, 20);
            this.EnumLabel.TabIndex = 2;
            this.EnumLabel.Text = "Choose enumeration";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(229, 41);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(159, 324);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged_1);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(23, 41);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(159, 324);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(941, 771);
            this.Controls.Add(this.EnumsTabPage);
            this.MinimumSize = new System.Drawing.Size(959, 818);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumPage.ResumeLayout(false);
            this.SeasonHandleTabControl.ResumeLayout(false);
            this.SeasonHandle.ResumeLayout(false);
            this.SeasonHandle.PerformLayout();
            this.WDParsingTabControl.ResumeLayout(false);
            this.WeekDayParsingTabControl.ResumeLayout(false);
            this.WeekDayParsingTabControl.PerformLayout();
            this.EnumerationTabControl.ResumeLayout(false);
            this.EnumerationPage.ResumeLayout(false);
            this.EnumerationPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabPage;
        private TabPage EnumPage;
        private TabControl EnumerationTabControl;
        private TabPage EnumerationPage;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TextBox ValuesTextBox;
        private Label IntValueLabel;
        private Label ValueLabel;
        private Label EnumLabel;
        private TabControl WDParsingTabControl;
        private TabPage WeekDayParsingTabControl;
        private Label WDParsingLabel;
        private Label ParsingResultLabel;
        private Button WeekDayParsingButton;
        private TextBox ParsingTextBox;
        private TabControl SeasonHandleTabControl;
        private TabPage SeasonHandle;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private Label SeasonLabel;
    }
}
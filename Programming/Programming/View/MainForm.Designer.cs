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
            this.EnumerationsBox = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.SeasonHandleBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParcingBox = new System.Windows.Forms.GroupBox();
            this.WeekDayParsingButton = new System.Windows.Forms.Button();
            this.ParsingResultLabel = new System.Windows.Forms.Label();
            this.WDParsingLabel = new System.Windows.Forms.Label();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.EnumsTabPage.SuspendLayout();
            this.EnumPage.SuspendLayout();
            this.EnumerationsBox.SuspendLayout();
            this.SeasonHandleBox.SuspendLayout();
            this.WeekdayParcingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.EnumPage);
            this.EnumsTabPage.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.SelectedIndex = 0;
            this.EnumsTabPage.Size = new System.Drawing.Size(934, 689);
            this.EnumsTabPage.TabIndex = 0;
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.EnumerationsBox);
            this.EnumPage.Controls.Add(this.SeasonHandleBox);
            this.EnumPage.Controls.Add(this.WeekdayParcingBox);
            this.EnumPage.Location = new System.Drawing.Point(4, 29);
            this.EnumPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumPage.Size = new System.Drawing.Size(926, 656);
            this.EnumPage.TabIndex = 0;
            this.EnumPage.Text = "Enum";
            this.EnumPage.UseVisualStyleBackColor = true;
            // 
            // EnumerationsBox
            // 
            this.EnumerationsBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsBox.Controls.Add(this.ValuesTextBox);
            this.EnumerationsBox.Controls.Add(this.ValueLabel);
            this.EnumerationsBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsBox.Controls.Add(this.EnumLabel);
            this.EnumerationsBox.Location = new System.Drawing.Point(8, 7);
            this.EnumerationsBox.Name = "EnumerationsBox";
            this.EnumerationsBox.Size = new System.Drawing.Size(880, 433);
            this.EnumerationsBox.TabIndex = 6;
            this.EnumerationsBox.TabStop = false;
            this.EnumerationsBox.Text = "Enumerations";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(193, 58);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(159, 324);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged_1);
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(456, 34);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(66, 20);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int Value";
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Enabled = false;
            this.ValuesTextBox.Location = new System.Drawing.Point(456, 58);
            this.ValuesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(114, 27);
            this.ValuesTextBox.TabIndex = 5;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(193, 34);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(97, 20);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 58);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(159, 324);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged_1);
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
            // SeasonHandleBox
            // 
            this.SeasonHandleBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.SeasonHandleBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleBox.Location = new System.Drawing.Point(458, 437);
            this.SeasonHandleBox.Name = "SeasonHandleBox";
            this.SeasonHandleBox.Size = new System.Drawing.Size(430, 193);
            this.SeasonHandleBox.TabIndex = 6;
            this.SeasonHandleBox.TabStop = false;
            this.SeasonHandleBox.Text = "SeasonHandle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeasonButton.Location = new System.Drawing.Point(196, 66);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(125, 35);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 72);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(184, 28);
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
            // WeekdayParcingBox
            // 
            this.WeekdayParcingBox.Controls.Add(this.WeekDayParsingButton);
            this.WeekdayParcingBox.Controls.Add(this.ParsingResultLabel);
            this.WeekdayParcingBox.Controls.Add(this.WDParsingLabel);
            this.WeekdayParcingBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayParcingBox.Location = new System.Drawing.Point(7, 437);
            this.WeekdayParcingBox.Name = "WeekdayParcingBox";
            this.WeekdayParcingBox.Size = new System.Drawing.Size(420, 193);
            this.WeekdayParcingBox.TabIndex = 6;
            this.WeekdayParcingBox.TabStop = false;
            this.WeekdayParcingBox.Text = "WeekdayParcing";
            // 
            // WeekDayParsingButton
            // 
            this.WeekDayParsingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekDayParsingButton.Location = new System.Drawing.Point(263, 73);
            this.WeekDayParsingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.ParsingTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingTextBox.Location = new System.Drawing.Point(6, 77);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(230, 32);
            this.ParsingTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(903, 672);
            this.Controls.Add(this.EnumsTabPage);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumPage.ResumeLayout(false);
            this.EnumerationsBox.ResumeLayout(false);
            this.EnumerationsBox.PerformLayout();
            this.SeasonHandleBox.ResumeLayout(false);
            this.SeasonHandleBox.PerformLayout();
            this.WeekdayParcingBox.ResumeLayout(false);
            this.WeekdayParcingBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabPage;
        private TabPage EnumPage;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private Label SeasonLabel;
        private Label ParsingResultLabel;
        private Button WeekDayParsingButton;
        private TextBox ParsingTextBox;
        private Label WDParsingLabel;
        private GroupBox WeekdayParcingBox;
        private GroupBox SeasonHandleBox;
        private GroupBox EnumerationsBox;
        private ListBox ValuesListBox;
        private Label IntValueLabel;
        private TextBox ValuesTextBox;
        private Label ValueLabel;
        private ListBox EnumsListBox;
        private Label EnumLabel;
    }
}
namespace Programming
{
    partial class Programming
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
            this.EnumTabPage = new System.Windows.Forms.TabControl();
            this.EnumPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WeekDayParsingTabControl = new System.Windows.Forms.TabPage();
            this.ParsingResultLabel = new System.Windows.Forms.Label();
            this.WeekDayParcingButton = new System.Windows.Forms.Button();
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EnumTabPage.SuspendLayout();
            this.EnumPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.WeekDayParsingTabControl.SuspendLayout();
            this.EnumerationTabControl.SuspendLayout();
            this.EnumerationPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumTabPage
            // 
            this.EnumTabPage.Controls.Add(this.EnumPage);
            this.EnumTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumTabPage.Location = new System.Drawing.Point(0, 0);
            this.EnumTabPage.Name = "EnumTabPage";
            this.EnumTabPage.SelectedIndex = 0;
            this.EnumTabPage.Size = new System.Drawing.Size(810, 561);
            this.EnumTabPage.TabIndex = 0;
            // 
            // EnumPage
            // 
            this.EnumPage.Controls.Add(this.tabControl2);
            this.EnumPage.Controls.Add(this.tabControl1);
            this.EnumPage.Controls.Add(this.EnumerationTabControl);
            this.EnumPage.Location = new System.Drawing.Point(4, 24);
            this.EnumPage.Name = "EnumPage";
            this.EnumPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumPage.Size = new System.Drawing.Size(802, 533);
            this.EnumPage.TabIndex = 0;
            this.EnumPage.Text = "Enum";
            this.EnumPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WeekDayParsingTabControl);
            this.tabControl1.Location = new System.Drawing.Point(27, 328);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 197);
            this.tabControl1.TabIndex = 6;
            // 
            // WeekDayParsingTabControl
            // 
            this.WeekDayParsingTabControl.Controls.Add(this.ParsingResultLabel);
            this.WeekDayParsingTabControl.Controls.Add(this.WeekDayParcingButton);
            this.WeekDayParsingTabControl.Controls.Add(this.ParsingTextBox);
            this.WeekDayParsingTabControl.Controls.Add(this.WDParsingLabel);
            this.WeekDayParsingTabControl.Location = new System.Drawing.Point(4, 24);
            this.WeekDayParsingTabControl.Name = "WeekDayParsingTabControl";
            this.WeekDayParsingTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.WeekDayParsingTabControl.Size = new System.Drawing.Size(417, 169);
            this.WeekDayParsingTabControl.TabIndex = 0;
            this.WeekDayParsingTabControl.Text = "WeekDay Parsing";
            this.WeekDayParsingTabControl.UseVisualStyleBackColor = true;
            // 
            // ParsingResultLabel
            // 
            this.ParsingResultLabel.AutoSize = true;
            this.ParsingResultLabel.Enabled = false;
            this.ParsingResultLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingResultLabel.Location = new System.Drawing.Point(16, 66);
            this.ParsingResultLabel.Name = "ParsingResultLabel";
            this.ParsingResultLabel.Size = new System.Drawing.Size(50, 20);
            this.ParsingResultLabel.TabIndex = 3;
            this.ParsingResultLabel.Text = "label1";
            this.ParsingResultLabel.Visible = false;
            // 
            // WeekDayParcingButton
            // 
            this.WeekDayParcingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekDayParcingButton.Location = new System.Drawing.Point(233, 36);
            this.WeekDayParcingButton.Name = "WeekDayParcingButton";
            this.WeekDayParcingButton.Size = new System.Drawing.Size(109, 27);
            this.WeekDayParcingButton.TabIndex = 2;
            this.WeekDayParcingButton.Text = "Parse";
            this.WeekDayParcingButton.UseVisualStyleBackColor = true;
            this.WeekDayParcingButton.Click += new System.EventHandler(this.WeekDayParcingButton_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParsingTextBox.Location = new System.Drawing.Point(16, 36);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(202, 27);
            this.ParsingTextBox.TabIndex = 1;
            // 
            // WDParsingLabel
            // 
            this.WDParsingLabel.AutoSize = true;
            this.WDParsingLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WDParsingLabel.Location = new System.Drawing.Point(16, 13);
            this.WDParsingLabel.Name = "WDParsingLabel";
            this.WDParsingLabel.Size = new System.Drawing.Size(155, 20);
            this.WDParsingLabel.TabIndex = 0;
            this.WDParsingLabel.Text = "Type value for parsing";
            this.WDParsingLabel.Click += new System.EventHandler(this.WDParcingLabel_Click);
            // 
            // EnumerationTabControl
            // 
            this.EnumerationTabControl.Controls.Add(this.EnumerationPage);
            this.EnumerationTabControl.Location = new System.Drawing.Point(3, 3);
            this.EnumerationTabControl.Name = "EnumerationTabControl";
            this.EnumerationTabControl.SelectedIndex = 0;
            this.EnumerationTabControl.Size = new System.Drawing.Size(791, 310);
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
            this.EnumerationPage.Location = new System.Drawing.Point(4, 24);
            this.EnumerationPage.Name = "EnumerationPage";
            this.EnumerationPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumerationPage.Size = new System.Drawing.Size(783, 282);
            this.EnumerationPage.TabIndex = 0;
            this.EnumerationPage.Text = "Enumeration";
            this.EnumerationPage.UseVisualStyleBackColor = true;
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Enabled = false;
            this.ValuesTextBox.Location = new System.Drawing.Point(382, 31);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(100, 23);
            this.ValuesTextBox.TabIndex = 5;
            this.ValuesTextBox.TextChanged += new System.EventHandler(this.ValuesTextBox_TextChanged_1);
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(382, 13);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(52, 15);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int Value";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(200, 13);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(78, 15);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value";
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(20, 13);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(118, 15);
            this.EnumLabel.TabIndex = 2;
            this.EnumLabel.Text = "Choose enumeration";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(200, 31);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(140, 244);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged_1);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(20, 31);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(140, 244);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged_1);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(469, 330);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 100);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Programming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 561);
            this.Controls.Add(this.EnumTabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Programming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnumTabPage.ResumeLayout(false);
            this.EnumPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.WeekDayParsingTabControl.ResumeLayout(false);
            this.WeekDayParsingTabControl.PerformLayout();
            this.EnumerationTabControl.ResumeLayout(false);
            this.EnumerationPage.ResumeLayout(false);
            this.EnumerationPage.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumTabPage;
        private TabPage EnumPage;
        private TabControl EnumerationTabControl;
        private TabPage EnumerationPage;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TextBox ValuesTextBox;
        private Label IntValueLabel;
        private Label ValueLabel;
        private Label EnumLabel;
        private TabControl tabControl1;
        private TabPage WeekDayParsingTabControl;
        private Label WDParsingLabel;
        private Label ParsingResultLabel;
        private Button WeekDayParcingButton;
        private TextBox ParsingTextBox;
        private TabControl tabControl2;
        private TabPage tabPage1;
    }
}
namespace Programming.View.Panels
{
    partial class AllEnumerationsControl
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
            EnumerationsBox = new GroupBox();
            ValuesListBox = new ListBox();
            IntValueLabel = new Label();
            ValuesTextBox = new TextBox();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            EnumLabel = new Label();
            EnumerationsBox.SuspendLayout();
            SuspendLayout();
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
            EnumerationsBox.Location = new Point(0, 0);
            EnumerationsBox.Name = "EnumerationsBox";
            EnumerationsBox.Size = new Size(716, 590);
            EnumerationsBox.TabIndex = 7;
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
            ValuesListBox.Size = new Size(159, 491);
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
            EnumsListBox.Size = new Size(159, 491);
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
            // AllEnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumerationsBox);
            Name = "AllEnumerationsControl";
            Size = new Size(716, 590);
            EnumerationsBox.ResumeLayout(false);
            EnumerationsBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumerationsBox;
        private ListBox ValuesListBox;
        private Label IntValueLabel;
        private TextBox ValuesTextBox;
        private Label ValueLabel;
        private ListBox EnumsListBox;
        private Label EnumLabel;
    }
}

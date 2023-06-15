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
            EnumerationsBox1 = new GroupBox();
            ValuesListBox1 = new ListBox();
            IntValueLabel1 = new Label();
            ValuesTextBox1 = new TextBox();
            ValueLabel1 = new Label();
            EnumsListBox1 = new ListBox();
            EnumLabel1 = new Label();
            EnumerationsBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumerationsBox1
            // 
            EnumerationsBox1.Controls.Add(ValuesListBox1);
            EnumerationsBox1.Controls.Add(IntValueLabel1);
            EnumerationsBox1.Controls.Add(ValuesTextBox1);
            EnumerationsBox1.Controls.Add(ValueLabel1);
            EnumerationsBox1.Controls.Add(EnumsListBox1);
            EnumerationsBox1.Controls.Add(EnumLabel1);
            EnumerationsBox1.Dock = DockStyle.Fill;
            EnumerationsBox1.Location = new Point(0, 0);
            EnumerationsBox1.Name = "EnumerationsBox1";
            EnumerationsBox1.Size = new Size(716, 590);
            EnumerationsBox1.TabIndex = 7;
            EnumerationsBox1.TabStop = false;
            EnumerationsBox1.Text = "Enumerations";
            // 
            // ValuesListBox1
            // 
            ValuesListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ValuesListBox1.FormattingEnabled = true;
            ValuesListBox1.IntegralHeight = false;
            ValuesListBox1.ItemHeight = 20;
            ValuesListBox1.Location = new Point(203, 59);
            ValuesListBox1.Margin = new Padding(25, 4, 3, 4);
            ValuesListBox1.Name = "ValuesListBox1";
            ValuesListBox1.Size = new Size(159, 491);
            ValuesListBox1.TabIndex = 1;
            ValuesListBox1.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // IntValueLabel1
            // 
            IntValueLabel1.AutoSize = true;
            IntValueLabel1.Location = new Point(390, 35);
            IntValueLabel1.Name = "IntValueLabel1";
            IntValueLabel1.Size = new Size(66, 20);
            IntValueLabel1.TabIndex = 4;
            IntValueLabel1.Text = "Int Value";
            // 
            // ValuesTextBox1
            // 
            ValuesTextBox1.Enabled = false;
            ValuesTextBox1.Location = new Point(390, 59);
            ValuesTextBox1.Margin = new Padding(25, 4, 3, 4);
            ValuesTextBox1.Name = "ValuesTextBox1";
            ValuesTextBox1.Size = new Size(114, 27);
            ValuesTextBox1.TabIndex = 5;
            // 
            // ValueLabel1
            // 
            ValueLabel1.AutoSize = true;
            ValueLabel1.Location = new Point(203, 35);
            ValueLabel1.Name = "ValueLabel1";
            ValueLabel1.Size = new Size(97, 20);
            ValueLabel1.TabIndex = 3;
            ValueLabel1.Text = "Choose value";
            // 
            // EnumsListBox1
            // 
            EnumsListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EnumsListBox1.FormattingEnabled = true;
            EnumsListBox1.IntegralHeight = false;
            EnumsListBox1.ItemHeight = 20;
            EnumsListBox1.Location = new Point(16, 59);
            EnumsListBox1.Margin = new Padding(3, 4, 3, 4);
            EnumsListBox1.Name = "EnumsListBox1";
            EnumsListBox1.Size = new Size(159, 491);
            EnumsListBox1.TabIndex = 0;
            EnumsListBox1.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumLabel1
            // 
            EnumLabel1.AutoSize = true;
            EnumLabel1.Location = new Point(16, 35);
            EnumLabel1.Name = "EnumLabel1";
            EnumLabel1.Size = new Size(146, 20);
            EnumLabel1.TabIndex = 2;
            EnumLabel1.Text = "Choose enumeration";
            // 
            // AllEnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumerationsBox1);
            Name = "AllEnumerationsControl";
            Size = new Size(716, 590);
            EnumerationsBox1.ResumeLayout(false);
            EnumerationsBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumerationsBox1;
        private ListBox ValuesListBox1;
        private Label IntValueLabel1;
        private TextBox ValuesTextBox1;
        private Label ValueLabel1;
        private ListBox EnumsListBox1;
        private Label EnumLabel1;
    }
}

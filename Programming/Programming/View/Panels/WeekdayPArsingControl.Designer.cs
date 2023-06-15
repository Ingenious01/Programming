namespace Programming.View.Panels
{
    partial class WeekdayPArsingControl
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
            WeekdayParcingBox = new GroupBox();
            WeekDayParsingButton = new Button();
            ParsingResultLabel = new Label();
            WDParsingLabel = new Label();
            ParsingTextBox = new TextBox();
            WeekdayParcingBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayParcingBox
            // 
            WeekdayParcingBox.Controls.Add(WeekDayParsingButton);
            WeekdayParcingBox.Controls.Add(ParsingResultLabel);
            WeekdayParcingBox.Controls.Add(WDParsingLabel);
            WeekdayParcingBox.Controls.Add(ParsingTextBox);
            WeekdayParcingBox.Dock = DockStyle.Fill;
            WeekdayParcingBox.Location = new Point(0, 0);
            WeekdayParcingBox.Name = "WeekdayParcingBox";
            WeekdayParcingBox.Size = new Size(616, 282);
            WeekdayParcingBox.TabIndex = 7;
            WeekdayParcingBox.TabStop = false;
            WeekdayParcingBox.Text = "Weekday Parcing";
            // 
            // WeekDayParsingButton
            // 
            WeekDayParsingButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WeekDayParsingButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            WeekDayParsingButton.Location = new Point(332, 74);
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
            ParsingTextBox.Size = new Size(268, 32);
            ParsingTextBox.TabIndex = 1;
            // 
            // WeekdayPArsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayParcingBox);
            Name = "WeekdayPArsingControl";
            Size = new Size(616, 282);
            WeekdayParcingBox.ResumeLayout(false);
            WeekdayParcingBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayParcingBox;
        private Button WeekDayParsingButton;
        private Label ParsingResultLabel;
        private Label WDParsingLabel;
        private TextBox ParsingTextBox;
    }
}

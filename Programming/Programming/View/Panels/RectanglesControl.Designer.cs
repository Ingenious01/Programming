namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            RectanglesBox.SuspendLayout();
            SuspendLayout();
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
            RectanglesBox.Location = new Point(0, 0);
            RectanglesBox.Name = "RectanglesBox";
            RectanglesBox.Size = new Size(394, 508);
            RectanglesBox.TabIndex = 1;
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
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesBox);
            Name = "RectanglesControl";
            Size = new Size(394, 508);
            RectanglesBox.ResumeLayout(false);
            RectanglesBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesBox;
        private TextBox IdBox;
        private Label IdLabel;
        private TextBox YBox;
        private Label YCoordinateLabel;
        private TextBox XBox;
        private Label XCoordinateLabel;
        private Button RectengleFindButton;
        private TextBox ColorBox;
        private TextBox WidthBox;
        private TextBox LengthBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
        private ListBox RectanglesListBox;
    }
}

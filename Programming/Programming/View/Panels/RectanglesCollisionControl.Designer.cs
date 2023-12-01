namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            CoordinatesBox = new GroupBox();
            GeometryRemoveButton = new Button();
            GeometryAddButton = new Button();
            GeometryRectanglesWidthTextBox = new TextBox();
            GeometryWidthLabel = new Label();
            GeometryRectanglesYTextBox = new TextBox();
            GeometryYLabel = new Label();
            GeometryRectanglesLengthTextBox = new TextBox();
            GeometryLengthLabel = new Label();
            GeometryRectanglesXTextBox = new TextBox();
            GeometryXLabel = new Label();
            GeometryRectanglesIdTextBox = new TextBox();
            GeometryIdLabel = new Label();
            SelectedRectangleLabel = new Label();
            GeometryRectanglesBox = new GroupBox();
            GeometryRectanglesListBox = new ListBox();
            RectanglesPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            CoordinatesBox.SuspendLayout();
            GeometryRectanglesBox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(RectanglesPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1237, 746);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(CoordinatesBox, 0, 1);
            tableLayoutPanel2.Controls.Add(GeometryRectanglesBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(550, 740);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // CoordinatesBox
            // 
            CoordinatesBox.Controls.Add(GeometryRemoveButton);
            CoordinatesBox.Controls.Add(GeometryAddButton);
            CoordinatesBox.Controls.Add(GeometryRectanglesWidthTextBox);
            CoordinatesBox.Controls.Add(GeometryWidthLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesYTextBox);
            CoordinatesBox.Controls.Add(GeometryYLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesLengthTextBox);
            CoordinatesBox.Controls.Add(GeometryLengthLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesXTextBox);
            CoordinatesBox.Controls.Add(GeometryXLabel);
            CoordinatesBox.Controls.Add(GeometryRectanglesIdTextBox);
            CoordinatesBox.Controls.Add(GeometryIdLabel);
            CoordinatesBox.Controls.Add(SelectedRectangleLabel);
            CoordinatesBox.Dock = DockStyle.Fill;
            CoordinatesBox.Location = new Point(3, 373);
            CoordinatesBox.Name = "CoordinatesBox";
            CoordinatesBox.Size = new Size(544, 364);
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
            GeometryRectanglesWidthTextBox.KeyDown += GeometryRectanglesWidthTextBox_KeyDown;
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
            GeometryRectanglesYTextBox.KeyDown += GeometryRectanglesYTextBox_KeyDown;
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
            // GeometryRectanglesLengthTextBox
            // 
            GeometryRectanglesLengthTextBox.Location = new Point(77, 233);
            GeometryRectanglesLengthTextBox.Name = "GeometryRectanglesLengthTextBox";
            GeometryRectanglesLengthTextBox.Size = new Size(125, 27);
            GeometryRectanglesLengthTextBox.TabIndex = 6;
            GeometryRectanglesLengthTextBox.KeyDown += GeometryRectanglesLengthTextBox_KeyDown;
            // 
            // GeometryLengthLabel
            // 
            GeometryLengthLabel.AutoSize = true;
            GeometryLengthLabel.Location = new Point(4, 240);
            GeometryLengthLabel.Name = "GeometryLengthLabel";
            GeometryLengthLabel.Size = new Size(57, 20);
            GeometryLengthLabel.TabIndex = 5;
            GeometryLengthLabel.Text = "Length:";
            // 
            // GeometryRectanglesXTextBox
            // 
            GeometryRectanglesXTextBox.Location = new Point(77, 134);
            GeometryRectanglesXTextBox.Name = "GeometryRectanglesXTextBox";
            GeometryRectanglesXTextBox.Size = new Size(125, 27);
            GeometryRectanglesXTextBox.TabIndex = 4;
            GeometryRectanglesXTextBox.KeyDown += GeometryRectanglesXTextBox_KeyDown;
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
            GeometryRectanglesIdTextBox.KeyPress += GeometryRectanglesIdTextBox_KeyPress;
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
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(16, 41);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 0;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // GeometryRectanglesBox
            // 
            GeometryRectanglesBox.Controls.Add(GeometryRectanglesListBox);
            GeometryRectanglesBox.Dock = DockStyle.Fill;
            GeometryRectanglesBox.Location = new Point(3, 3);
            GeometryRectanglesBox.Name = "GeometryRectanglesBox";
            GeometryRectanglesBox.Size = new Size(544, 364);
            GeometryRectanglesBox.TabIndex = 2;
            GeometryRectanglesBox.TabStop = false;
            GeometryRectanglesBox.Text = "Rectangles:";
            // 
            // GeometryRectanglesListBox
            // 
            GeometryRectanglesListBox.Dock = DockStyle.Fill;
            GeometryRectanglesListBox.FormattingEnabled = true;
            GeometryRectanglesListBox.ItemHeight = 20;
            GeometryRectanglesListBox.Location = new Point(3, 23);
            GeometryRectanglesListBox.Name = "GeometryRectanglesListBox";
            GeometryRectanglesListBox.Size = new Size(538, 338);
            GeometryRectanglesListBox.TabIndex = 0;
            GeometryRectanglesListBox.SelectedIndexChanged += GeometryRectanlesListBox_SelectedIndexChanged;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.Location = new Point(559, 3);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(675, 740);
            RectanglesPanel.TabIndex = 1;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "RectanglesCollisionControl";
            Size = new Size(1237, 746);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            CoordinatesBox.ResumeLayout(false);
            CoordinatesBox.PerformLayout();
            GeometryRectanglesBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox CoordinatesBox;
        private Button GeometryRemoveButton;
        private Button GeometryAddButton;
        private TextBox GeometryRectanglesWidthTextBox;
        private Label GeometryWidthLabel;
        private TextBox GeometryRectanglesYTextBox;
        private Label GeometryYLabel;
        private TextBox GeometryRectanglesLengthTextBox;
        private Label GeometryLengthLabel;
        private TextBox GeometryRectanglesXTextBox;
        private Label GeometryXLabel;
        private TextBox GeometryRectanglesIdTextBox;
        private Label GeometryIdLabel;
        private Label SelectedRectangleLabel;
        private GroupBox GeometryRectanglesBox;
        private ListBox GeometryRectanglesListBox;
        private Panel RectanglesPanel;
    }
}

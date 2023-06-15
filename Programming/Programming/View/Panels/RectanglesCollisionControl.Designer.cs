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
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            CoordinatesBox1 = new GroupBox();
            GeometryRemoveButton1 = new Button();
            GeometryAddButton1 = new Button();
            GeometryRectanglesWidthTextBox1 = new TextBox();
            GeometryWidthLabel1 = new Label();
            GeometryRectanglesYTextBox1 = new TextBox();
            GeometryYLabel1 = new Label();
            GeometryRectanglesLengthTextBox1 = new TextBox();
            GeometryLengthLabel1 = new Label();
            GeometryRectanglesXTextBox1 = new TextBox();
            GeometryXLabel1 = new Label();
            GeometryRectanglesIdTextBox1 = new TextBox();
            GeometryIdLabel1 = new Label();
            label1 = new Label();
            GeometryRectanglesBox1 = new GroupBox();
            GeometryRectanglesListBox1 = new ListBox();
            rectanglesPanel1 = new Panel();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            CoordinatesBox1.SuspendLayout();
            GeometryRectanglesBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(rectanglesPanel1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1237, 746);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(CoordinatesBox1, 0, 1);
            tableLayoutPanel5.Controls.Add(GeometryRectanglesBox1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(550, 740);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // CoordinatesBox1
            // 
            CoordinatesBox1.Controls.Add(GeometryRemoveButton1);
            CoordinatesBox1.Controls.Add(GeometryAddButton1);
            CoordinatesBox1.Controls.Add(GeometryRectanglesWidthTextBox1);
            CoordinatesBox1.Controls.Add(GeometryWidthLabel1);
            CoordinatesBox1.Controls.Add(GeometryRectanglesYTextBox1);
            CoordinatesBox1.Controls.Add(GeometryYLabel1);
            CoordinatesBox1.Controls.Add(GeometryRectanglesLengthTextBox1);
            CoordinatesBox1.Controls.Add(GeometryLengthLabel1);
            CoordinatesBox1.Controls.Add(GeometryRectanglesXTextBox1);
            CoordinatesBox1.Controls.Add(GeometryXLabel1);
            CoordinatesBox1.Controls.Add(GeometryRectanglesIdTextBox1);
            CoordinatesBox1.Controls.Add(GeometryIdLabel1);
            CoordinatesBox1.Controls.Add(label1);
            CoordinatesBox1.Dock = DockStyle.Fill;
            CoordinatesBox1.Location = new Point(3, 373);
            CoordinatesBox1.Name = "CoordinatesBox1";
            CoordinatesBox1.Size = new Size(544, 364);
            CoordinatesBox1.TabIndex = 1;
            CoordinatesBox1.TabStop = false;
            CoordinatesBox1.Text = "Coordinates and stuff";
            // 
            // GeometryRemoveButton1
            // 
            GeometryRemoveButton1.Image = (Image)resources.GetObject("GeometryRemoveButton1.Image");
            GeometryRemoveButton1.Location = new Point(342, 137);
            GeometryRemoveButton1.Name = "GeometryRemoveButton1";
            GeometryRemoveButton1.Size = new Size(96, 94);
            GeometryRemoveButton1.TabIndex = 12;
            GeometryRemoveButton1.UseVisualStyleBackColor = true;
            GeometryRemoveButton1.Click += GeometryRemoveButton1_Click;
            // 
            // GeometryAddButton1
            // 
            GeometryAddButton1.Image = (Image)resources.GetObject("GeometryAddButton1.Image");
            GeometryAddButton1.Location = new Point(224, 137);
            GeometryAddButton1.Name = "GeometryAddButton1";
            GeometryAddButton1.Size = new Size(96, 94);
            GeometryAddButton1.TabIndex = 11;
            GeometryAddButton1.UseVisualStyleBackColor = true;
            GeometryAddButton1.Click += GeometryAddButton1_Click;
            // 
            // GeometryRectanglesWidthTextBox1
            // 
            GeometryRectanglesWidthTextBox1.Location = new Point(77, 200);
            GeometryRectanglesWidthTextBox1.Name = "GeometryRectanglesWidthTextBox1";
            GeometryRectanglesWidthTextBox1.Size = new Size(125, 27);
            GeometryRectanglesWidthTextBox1.TabIndex = 10;
            GeometryRectanglesWidthTextBox1.TextChanged += GeometryRectanglesWidthTextBox1_TextChanged;
            // 
            // GeometryWidthLabel1
            // 
            GeometryWidthLabel1.AutoSize = true;
            GeometryWidthLabel1.Location = new Point(9, 207);
            GeometryWidthLabel1.Name = "GeometryWidthLabel1";
            GeometryWidthLabel1.Size = new Size(52, 20);
            GeometryWidthLabel1.TabIndex = 9;
            GeometryWidthLabel1.Text = "Width:";
            // 
            // GeometryRectanglesYTextBox1
            // 
            GeometryRectanglesYTextBox1.Location = new Point(77, 167);
            GeometryRectanglesYTextBox1.Name = "GeometryRectanglesYTextBox1";
            GeometryRectanglesYTextBox1.Size = new Size(125, 27);
            GeometryRectanglesYTextBox1.TabIndex = 8;
            GeometryRectanglesYTextBox1.TextChanged += GeometryRectanglesYTextBox1_TextChanged;
            // 
            // GeometryYLabel1
            // 
            GeometryYLabel1.AutoSize = true;
            GeometryYLabel1.Location = new Point(41, 174);
            GeometryYLabel1.Name = "GeometryYLabel1";
            GeometryYLabel1.Size = new Size(20, 20);
            GeometryYLabel1.TabIndex = 7;
            GeometryYLabel1.Text = "Y:";
            // 
            // GeometryRectanglesLengthTextBox1
            // 
            GeometryRectanglesLengthTextBox1.Location = new Point(77, 233);
            GeometryRectanglesLengthTextBox1.Name = "GeometryRectanglesLengthTextBox1";
            GeometryRectanglesLengthTextBox1.Size = new Size(125, 27);
            GeometryRectanglesLengthTextBox1.TabIndex = 6;
            GeometryRectanglesLengthTextBox1.TextChanged += GeometryRectanglesLengthTextBox1_TextChanged;
            // 
            // GeometryLengthLabel1
            // 
            GeometryLengthLabel1.AutoSize = true;
            GeometryLengthLabel1.Location = new Point(4, 240);
            GeometryLengthLabel1.Name = "GeometryLengthLabel1";
            GeometryLengthLabel1.Size = new Size(57, 20);
            GeometryLengthLabel1.TabIndex = 5;
            GeometryLengthLabel1.Text = "Length:";
            // 
            // GeometryRectanglesXTextBox1
            // 
            GeometryRectanglesXTextBox1.Location = new Point(77, 134);
            GeometryRectanglesXTextBox1.Name = "GeometryRectanglesXTextBox1";
            GeometryRectanglesXTextBox1.Size = new Size(125, 27);
            GeometryRectanglesXTextBox1.TabIndex = 4;
            GeometryRectanglesXTextBox1.TextChanged += GeometryRectanglesXTextBox1_TextChanged;
            // 
            // GeometryXLabel1
            // 
            GeometryXLabel1.AutoSize = true;
            GeometryXLabel1.Location = new Point(40, 141);
            GeometryXLabel1.Name = "GeometryXLabel1";
            GeometryXLabel1.Size = new Size(21, 20);
            GeometryXLabel1.TabIndex = 3;
            GeometryXLabel1.Text = "X:";
            // 
            // GeometryRectanglesIdTextBox1
            // 
            GeometryRectanglesIdTextBox1.Location = new Point(77, 101);
            GeometryRectanglesIdTextBox1.Name = "GeometryRectanglesIdTextBox1";
            GeometryRectanglesIdTextBox1.Size = new Size(125, 27);
            GeometryRectanglesIdTextBox1.TabIndex = 2;
            GeometryRectanglesIdTextBox1.KeyPress += GeometryRectanglesIdTextBox1_KeyPress;
            // 
            // GeometryIdLabel1
            // 
            GeometryIdLabel1.AutoSize = true;
            GeometryIdLabel1.Location = new Point(36, 108);
            GeometryIdLabel1.Name = "GeometryIdLabel1";
            GeometryIdLabel1.Size = new Size(25, 20);
            GeometryIdLabel1.TabIndex = 1;
            GeometryIdLabel1.Text = "Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Selected Rectangle:";
            // 
            // GeometryRectanglesBox1
            // 
            GeometryRectanglesBox1.Controls.Add(GeometryRectanglesListBox1);
            GeometryRectanglesBox1.Dock = DockStyle.Fill;
            GeometryRectanglesBox1.Location = new Point(3, 3);
            GeometryRectanglesBox1.Name = "GeometryRectanglesBox1";
            GeometryRectanglesBox1.Size = new Size(544, 364);
            GeometryRectanglesBox1.TabIndex = 2;
            GeometryRectanglesBox1.TabStop = false;
            GeometryRectanglesBox1.Text = "Rectangles:";
            // 
            // GeometryRectanglesListBox1
            // 
            GeometryRectanglesListBox1.Dock = DockStyle.Fill;
            GeometryRectanglesListBox1.FormattingEnabled = true;
            GeometryRectanglesListBox1.ItemHeight = 20;
            GeometryRectanglesListBox1.Location = new Point(3, 23);
            GeometryRectanglesListBox1.Name = "GeometryRectanglesListBox1";
            GeometryRectanglesListBox1.Size = new Size(538, 338);
            GeometryRectanglesListBox1.TabIndex = 0;
            GeometryRectanglesListBox1.SelectedIndexChanged += GeometryRectanlesListBox1_SelectedIndexChanged;
            // 
            // rectanglesPanel1
            // 
            rectanglesPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rectanglesPanel1.Location = new Point(559, 3);
            rectanglesPanel1.Name = "rectanglesPanel1";
            rectanglesPanel1.Size = new Size(675, 740);
            rectanglesPanel1.TabIndex = 1;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel4);
            Name = "RectanglesCollisionControl";
            Size = new Size(1237, 746);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            CoordinatesBox1.ResumeLayout(false);
            CoordinatesBox1.PerformLayout();
            GeometryRectanglesBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox CoordinatesBox1;
        private Button GeometryRemoveButton1;
        private Button GeometryAddButton1;
        private TextBox GeometryRectanglesWidthTextBox1;
        private Label GeometryWidthLabel1;
        private TextBox GeometryRectanglesYTextBox1;
        private Label GeometryYLabel1;
        private TextBox GeometryRectanglesLengthTextBox1;
        private Label GeometryLengthLabel1;
        private TextBox GeometryRectanglesXTextBox1;
        private Label GeometryXLabel1;
        private TextBox GeometryRectanglesIdTextBox1;
        private Label GeometryIdLabel1;
        private Label label1;
        private GroupBox GeometryRectanglesBox1;
        private ListBox GeometryRectanglesListBox1;
        private Panel rectanglesPanel1;
    }
}

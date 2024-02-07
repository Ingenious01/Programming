namespace ObjectOrientedPractics.View.Tabs
{
    partial class itemsTab
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchDescriptionLabel = new System.Windows.Forms.Label();
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.itemsListGroupBox = new System.Windows.Forms.GroupBox();
            this.orderbyComboBox = new System.Windows.Forms.ComboBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.findItemTextBox = new System.Windows.Forms.TextBox();
            this.findItemLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.selectedItemGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.itemsListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.selectedItemGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 678);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectedItemGroupBox
            // 
            this.selectedItemGroupBox.Controls.Add(this.categoryComboBox);
            this.selectedItemGroupBox.Controls.Add(this.categoryLabel);
            this.selectedItemGroupBox.Controls.Add(this.descriptionRichTextBox);
            this.selectedItemGroupBox.Controls.Add(this.searchDescriptionLabel);
            this.selectedItemGroupBox.Controls.Add(this.nameRichTextBox);
            this.selectedItemGroupBox.Controls.Add(this.searchNameLabel);
            this.selectedItemGroupBox.Controls.Add(this.costTextBox);
            this.selectedItemGroupBox.Controls.Add(this.idTextBox);
            this.selectedItemGroupBox.Controls.Add(this.costLabel);
            this.selectedItemGroupBox.Controls.Add(this.idLabel);
            this.selectedItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedItemGroupBox.Location = new System.Drawing.Point(406, 3);
            this.selectedItemGroupBox.Name = "selectedItemGroupBox";
            this.selectedItemGroupBox.Size = new System.Drawing.Size(600, 672);
            this.selectedItemGroupBox.TabIndex = 2;
            this.selectedItemGroupBox.TabStop = false;
            this.selectedItemGroupBox.Text = "Selected Item";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Enabled = false;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(118, 119);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(175, 30);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.Location = new System.Drawing.Point(8, 122);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(90, 24);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionRichTextBox.Enabled = false;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(11, 377);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(584, 223);
            this.descriptionRichTextBox.TabIndex = 7;
            this.descriptionRichTextBox.Text = "";
            this.descriptionRichTextBox.TextChanged += new System.EventHandler(this.DescriptionRichTextBox1_TextChanged);
            this.descriptionRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriptionRichTextBox_KeyPress);
            // 
            // searchDescriptionLabel
            // 
            this.searchDescriptionLabel.AutoSize = true;
            this.searchDescriptionLabel.Location = new System.Drawing.Point(7, 348);
            this.searchDescriptionLabel.Name = "searchDescriptionLabel";
            this.searchDescriptionLabel.Size = new System.Drawing.Size(127, 26);
            this.searchDescriptionLabel.TabIndex = 6;
            this.searchDescriptionLabel.Text = "Description:";
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameRichTextBox.Enabled = false;
            this.nameRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRichTextBox.Location = new System.Drawing.Point(10, 186);
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.Size = new System.Drawing.Size(584, 140);
            this.nameRichTextBox.TabIndex = 5;
            this.nameRichTextBox.Text = "";
            this.nameRichTextBox.TextChanged += new System.EventHandler(this.NameRichTextBox_TextChanged);
            this.nameRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameRichTextBox_KeyPress);
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Location = new System.Drawing.Point(6, 157);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(77, 26);
            this.searchNameLabel.TabIndex = 4;
            this.searchNameLabel.Text = "Name:";
            // 
            // costTextBox
            // 
            this.costTextBox.Enabled = false;
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(118, 82);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(141, 28);
            this.costTextBox.TabIndex = 3;
            this.costTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged);
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(118, 44);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(141, 28);
            this.idTextBox.TabIndex = 2;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(6, 85);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(52, 24);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(6, 47);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 24);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.itemsListGroupBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(397, 672);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.removeButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 607);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 62);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.Location = new System.Drawing.Point(133, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(124, 56);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 56);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // itemsListGroupBox
            // 
            this.itemsListGroupBox.Controls.Add(this.orderbyComboBox);
            this.itemsListGroupBox.Controls.Add(this.orderByLabel);
            this.itemsListGroupBox.Controls.Add(this.findItemTextBox);
            this.itemsListGroupBox.Controls.Add(this.findItemLabel);
            this.itemsListGroupBox.Controls.Add(this.itemsListBox);
            this.itemsListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsListGroupBox.Location = new System.Drawing.Point(3, 3);
            this.itemsListGroupBox.Name = "itemsListGroupBox";
            this.itemsListGroupBox.Size = new System.Drawing.Size(391, 598);
            this.itemsListGroupBox.TabIndex = 1;
            this.itemsListGroupBox.TabStop = false;
            this.itemsListGroupBox.Text = "Items";
            // 
            // orderbyComboBox
            // 
            this.orderbyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderbyComboBox.Enabled = false;
            this.orderbyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderbyComboBox.FormattingEnabled = true;
            this.orderbyComboBox.Location = new System.Drawing.Point(101, 559);
            this.orderbyComboBox.Name = "orderbyComboBox";
            this.orderbyComboBox.Size = new System.Drawing.Size(175, 30);
            this.orderbyComboBox.TabIndex = 11;
            this.orderbyComboBox.SelectedIndexChanged += new System.EventHandler(this.orderbyComboBox_SelectedIndexChanged);
            // 
            // orderByLabel
            // 
            this.orderByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderByLabel.Location = new System.Drawing.Point(6, 565);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(89, 24);
            this.orderByLabel.TabIndex = 10;
            this.orderByLabel.Text = "Order by:";
            // 
            // findItemTextBox
            // 
            this.findItemTextBox.Enabled = false;
            this.findItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findItemTextBox.Location = new System.Drawing.Point(75, 31);
            this.findItemTextBox.Name = "findItemTextBox";
            this.findItemTextBox.Size = new System.Drawing.Size(182, 28);
            this.findItemTextBox.TabIndex = 5;
            this.findItemTextBox.TextChanged += new System.EventHandler(this.findItemTextBox_TextChanged);
            // 
            // findItemLabel
            // 
            this.findItemLabel.AutoSize = true;
            this.findItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findItemLabel.Location = new System.Drawing.Point(16, 34);
            this.findItemLabel.Name = "findItemLabel";
            this.findItemLabel.Size = new System.Drawing.Size(53, 24);
            this.findItemLabel.TabIndex = 4;
            this.findItemLabel.Text = "Find:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 22;
            this.itemsListBox.Location = new System.Drawing.Point(3, 72);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(385, 488);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // itemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "itemsTab";
            this.Size = new System.Drawing.Size(1009, 678);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.selectedItemGroupBox.ResumeLayout(false);
            this.selectedItemGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.itemsListGroupBox.ResumeLayout(false);
            this.itemsListGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox itemsListGroupBox;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.GroupBox selectedItemGroupBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label searchDescriptionLabel;
        private System.Windows.Forms.RichTextBox nameRichTextBox;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox findItemTextBox;
        private System.Windows.Forms.Label findItemLabel;
        private System.Windows.Forms.ComboBox orderbyComboBox;
        private System.Windows.Forms.Label orderByLabel;
    }
}

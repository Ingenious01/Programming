namespace ObjectOrientedPractics.View.Tabs
{
    partial class ordersTab
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.selectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.orderItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.cartsListBox = new System.Windows.Forms.ListBox();
            this.ordersGroupBox1 = new System.Windows.Forms.GroupBox();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.selectedOrderGroupBox.SuspendLayout();
            this.orderItemsGroupBox.SuspendLayout();
            this.ordersGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ordersGroupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1131, 632);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.addressControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectedOrderGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.orderItemsGroupBox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(568, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.00857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.24105F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.75038F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(560, 626);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl1.Location = new System.Drawing.Point(3, 140);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(554, 264);
            this.addressControl1.TabIndex = 0;
            // 
            // selectedOrderGroupBox
            // 
            this.selectedOrderGroupBox.Controls.Add(this.categoryComboBox);
            this.selectedOrderGroupBox.Controls.Add(this.statusLabel);
            this.selectedOrderGroupBox.Controls.Add(this.costTextBox);
            this.selectedOrderGroupBox.Controls.Add(this.idTextBox);
            this.selectedOrderGroupBox.Controls.Add(this.costLabel);
            this.selectedOrderGroupBox.Controls.Add(this.idLabel);
            this.selectedOrderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedOrderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.selectedOrderGroupBox.Name = "selectedOrderGroupBox";
            this.selectedOrderGroupBox.Size = new System.Drawing.Size(554, 131);
            this.selectedOrderGroupBox.TabIndex = 1;
            this.selectedOrderGroupBox.TabStop = false;
            this.selectedOrderGroupBox.Text = "Selected Order";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(118, 90);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(141, 30);
            this.categoryComboBox.TabIndex = 15;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(8, 93);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(65, 24);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Status:";
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(118, 53);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(141, 28);
            this.costTextBox.TabIndex = 13;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(118, 15);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(141, 28);
            this.idTextBox.TabIndex = 12;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(6, 56);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(52, 24);
            this.costLabel.TabIndex = 11;
            this.costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(6, 18);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 24);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID:";
            // 
            // orderItemsGroupBox
            // 
            this.orderItemsGroupBox.Controls.Add(this.cartsListBox);
            this.orderItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsGroupBox.Location = new System.Drawing.Point(3, 410);
            this.orderItemsGroupBox.Name = "orderItemsGroupBox";
            this.orderItemsGroupBox.Size = new System.Drawing.Size(554, 213);
            this.orderItemsGroupBox.TabIndex = 2;
            this.orderItemsGroupBox.TabStop = false;
            this.orderItemsGroupBox.Text = "Order Items";
            // 
            // cartsListBox
            // 
            this.cartsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartsListBox.FormattingEnabled = true;
            this.cartsListBox.ItemHeight = 22;
            this.cartsListBox.Location = new System.Drawing.Point(3, 18);
            this.cartsListBox.Name = "cartsListBox";
            this.cartsListBox.Size = new System.Drawing.Size(548, 192);
            this.cartsListBox.TabIndex = 11;
            this.cartsListBox.SelectedIndexChanged += new System.EventHandler(this.cartsListBox_SelectedIndexChanged);
            // 
            // ordersGroupBox1
            // 
            this.ordersGroupBox1.Controls.Add(this.ordersGridView);
            this.ordersGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.ordersGroupBox1.Name = "ordersGroupBox1";
            this.ordersGroupBox1.Size = new System.Drawing.Size(559, 626);
            this.ordersGroupBox1.TabIndex = 1;
            this.ordersGroupBox1.TabStop = false;
            this.ordersGroupBox1.Text = "Orders";
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.AllowUserToResizeColumns = false;
            this.ordersGridView.AllowUserToResizeRows = false;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.DateColumn,
            this.StatusColumn,
            this.NameColumn});
            this.ordersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGridView.Location = new System.Drawing.Point(3, 18);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(553, 605);
            this.ordersGridView.TabIndex = 0;
            this.ordersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGridView_CellContentClick);
            // 
            // IdColumn
            // 
            this.IdColumn.Frozen = true;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 50;
            // 
            // DateColumn
            // 
            this.DateColumn.Frozen = true;
            this.DateColumn.HeaderText = "Created";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Frozen = true;
            this.StatusColumn.HeaderText = "Order Status";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Customer Full Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameColumn.Width = 200;
            // 
            // ordersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ordersTab";
            this.Size = new System.Drawing.Size(1131, 632);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.selectedOrderGroupBox.ResumeLayout(false);
            this.selectedOrderGroupBox.PerformLayout();
            this.orderItemsGroupBox.ResumeLayout(false);
            this.ordersGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.GroupBox selectedOrderGroupBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.GroupBox orderItemsGroupBox;
        private System.Windows.Forms.ListBox cartsListBox;
        private System.Windows.Forms.GroupBox ordersGroupBox1;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    }
}

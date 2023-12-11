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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearOrderButton = new System.Windows.Forms.Button();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.orderItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderItemsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ordersGroupBox1 = new System.Windows.Forms.GroupBox();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.selectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.priorityOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.deliverytimeLabel = new System.Windows.Forms.Label();
            this.totalPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.orderItemsGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.ordersGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.selectedOrderGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.priorityOptionsGroupBox.SuspendLayout();
            this.totalPriceGroupBox.SuspendLayout();
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
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.addressControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.orderItemsGroupBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(568, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(560, 626);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.addItemButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.removeItemButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.clearOrderButton, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 578);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(554, 45);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // addItemButton
            // 
            this.addItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemButton.Enabled = false;
            this.addItemButton.Location = new System.Drawing.Point(141, 3);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(132, 39);
            this.addItemButton.TabIndex = 8;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeItemButton.Enabled = false;
            this.removeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeItemButton.Location = new System.Drawing.Point(3, 3);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(132, 39);
            this.removeItemButton.TabIndex = 4;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearOrderButton.Enabled = false;
            this.clearOrderButton.Location = new System.Drawing.Point(417, 3);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(134, 39);
            this.clearOrderButton.TabIndex = 7;
            this.clearOrderButton.Text = "Clear Order";
            this.clearOrderButton.UseVisualStyleBackColor = true;
            this.clearOrderButton.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.AutoSize = true;
            this.addressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl1.Enabled = false;
            this.addressControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addressControl1.Location = new System.Drawing.Point(3, 140);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(554, 263);
            this.addressControl1.TabIndex = 0;
            // 
            // orderItemsGroupBox
            // 
            this.orderItemsGroupBox.Controls.Add(this.orderItemsListBox);
            this.orderItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsGroupBox.Location = new System.Drawing.Point(3, 409);
            this.orderItemsGroupBox.Name = "orderItemsGroupBox";
            this.orderItemsGroupBox.Size = new System.Drawing.Size(554, 163);
            this.orderItemsGroupBox.TabIndex = 2;
            this.orderItemsGroupBox.TabStop = false;
            this.orderItemsGroupBox.Text = "Order Items";
            // 
            // orderItemsListBox
            // 
            this.orderItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsListBox.Enabled = false;
            this.orderItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderItemsListBox.FormattingEnabled = true;
            this.orderItemsListBox.ItemHeight = 22;
            this.orderItemsListBox.Location = new System.Drawing.Point(3, 18);
            this.orderItemsListBox.Name = "orderItemsListBox";
            this.orderItemsListBox.Size = new System.Drawing.Size(548, 142);
            this.orderItemsListBox.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.Controls.Add(this.selectedOrderGroupBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(554, 131);
            this.tableLayoutPanel3.TabIndex = 3;
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
            this.ordersGridView.AutoGenerateColumns = false;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.ordersGridView.DataSource = this.OrderBindingSource;
            this.ordersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGridView.Location = new System.Drawing.Point(3, 18);
            this.ordersGridView.MultiSelect = false;
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(553, 605);
            this.ordersGridView.TabIndex = 0;
            this.ordersGridView.SelectionChanged += new System.EventHandler(this.ordersGridView_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(ObjectOrientedPractics.Model.Orders.Order);
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
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(96, 15);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(141, 28);
            this.idTextBox.TabIndex = 12;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(96, 53);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(141, 28);
            this.costTextBox.TabIndex = 13;
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
            // statusComboBox
            // 
            this.statusComboBox.Enabled = false;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(96, 90);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(141, 30);
            this.statusComboBox.TabIndex = 15;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // selectedOrderGroupBox
            // 
            this.selectedOrderGroupBox.Controls.Add(this.statusComboBox);
            this.selectedOrderGroupBox.Controls.Add(this.statusLabel);
            this.selectedOrderGroupBox.Controls.Add(this.costTextBox);
            this.selectedOrderGroupBox.Controls.Add(this.idTextBox);
            this.selectedOrderGroupBox.Controls.Add(this.costLabel);
            this.selectedOrderGroupBox.Controls.Add(this.idLabel);
            this.selectedOrderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedOrderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.selectedOrderGroupBox.Name = "selectedOrderGroupBox";
            this.selectedOrderGroupBox.Size = new System.Drawing.Size(243, 125);
            this.selectedOrderGroupBox.TabIndex = 2;
            this.selectedOrderGroupBox.TabStop = false;
            this.selectedOrderGroupBox.Text = "Selected Order";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.priorityOptionsGroupBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.totalPriceGroupBox, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(252, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(299, 125);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // priorityOptionsGroupBox
            // 
            this.priorityOptionsGroupBox.Controls.Add(this.deliveryTimeComboBox);
            this.priorityOptionsGroupBox.Controls.Add(this.deliverytimeLabel);
            this.priorityOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOptionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.priorityOptionsGroupBox.Name = "priorityOptionsGroupBox";
            this.priorityOptionsGroupBox.Size = new System.Drawing.Size(293, 56);
            this.priorityOptionsGroupBox.TabIndex = 4;
            this.priorityOptionsGroupBox.TabStop = false;
            this.priorityOptionsGroupBox.Text = "Priority Order";
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(144, 21);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(143, 30);
            this.deliveryTimeComboBox.TabIndex = 15;
            // 
            // deliverytimeLabel
            // 
            this.deliverytimeLabel.AutoSize = true;
            this.deliverytimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliverytimeLabel.Location = new System.Drawing.Point(8, 24);
            this.deliverytimeLabel.Name = "deliverytimeLabel";
            this.deliverytimeLabel.Size = new System.Drawing.Size(130, 24);
            this.deliverytimeLabel.TabIndex = 14;
            this.deliverytimeLabel.Text = "Delivery Time:";
            // 
            // totalPriceGroupBox
            // 
            this.totalPriceGroupBox.Controls.Add(this.totalPriceLabel);
            this.totalPriceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPriceGroupBox.Location = new System.Drawing.Point(3, 65);
            this.totalPriceGroupBox.Name = "totalPriceGroupBox";
            this.totalPriceGroupBox.Size = new System.Drawing.Size(293, 57);
            this.totalPriceGroupBox.TabIndex = 5;
            this.totalPriceGroupBox.TabStop = false;
            this.totalPriceGroupBox.Text = "Discounts";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceLabel.Location = new System.Drawing.Point(8, 25);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 24);
            this.totalPriceLabel.TabIndex = 15;
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
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.orderItemsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ordersGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.selectedOrderGroupBox.ResumeLayout(false);
            this.selectedOrderGroupBox.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.priorityOptionsGroupBox.ResumeLayout(false);
            this.priorityOptionsGroupBox.PerformLayout();
            this.totalPriceGroupBox.ResumeLayout(false);
            this.totalPriceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox ordersGroupBox1;
        private System.Windows.Forms.DataGridView ordersGridView;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox orderItemsGroupBox;
        private System.Windows.Forms.ListBox orderItemsListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearOrderButton;
        private System.Windows.Forms.GroupBox selectedOrderGroupBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox priorityOptionsGroupBox;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Label deliverytimeLabel;
        private System.Windows.Forms.GroupBox totalPriceGroupBox;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

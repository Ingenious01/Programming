namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.selectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.priorityOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.deliveryTimeBomboBox = new System.Windows.Forms.ComboBox();
            this.deliverytimeLabel = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.orderItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderItemsListBox = new System.Windows.Forms.ListBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.selectedOrderGroupBox.SuspendLayout();
            this.priorityOptionsGroupBox.SuspendLayout();
            this.orderItemsGroupBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addressControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderItemsGroupBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 825);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.priorityOptionsGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectedOrderGroupBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 159);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // selectedOrderGroupBox
            // 
            this.selectedOrderGroupBox.Controls.Add(this.statusComboBox);
            this.selectedOrderGroupBox.Controls.Add(this.statusLabel);
            this.selectedOrderGroupBox.Controls.Add(this.createdTextBox);
            this.selectedOrderGroupBox.Controls.Add(this.label1);
            this.selectedOrderGroupBox.Controls.Add(this.idTextBox);
            this.selectedOrderGroupBox.Controls.Add(this.PostIndexLabel);
            this.selectedOrderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedOrderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.selectedOrderGroupBox.Name = "selectedOrderGroupBox";
            this.selectedOrderGroupBox.Size = new System.Drawing.Size(307, 153);
            this.selectedOrderGroupBox.TabIndex = 0;
            this.selectedOrderGroupBox.TabStop = false;
            this.selectedOrderGroupBox.Text = "Selected Order";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(89, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 28);
            this.idTextBox.TabIndex = 11;
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostIndexLabel.Location = new System.Drawing.Point(3, 24);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(32, 24);
            this.PostIndexLabel.TabIndex = 10;
            this.PostIndexLabel.Text = "ID:";
            // 
            // createdTextBox
            // 
            this.createdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createdTextBox.Location = new System.Drawing.Point(89, 55);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.Size = new System.Drawing.Size(151, 28);
            this.createdTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Created:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(3, 92);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(65, 24);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(89, 89);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(151, 30);
            this.statusComboBox.TabIndex = 15;
            // 
            // priorityOptionsGroupBox
            // 
            this.priorityOptionsGroupBox.Controls.Add(this.deliveryTimeBomboBox);
            this.priorityOptionsGroupBox.Controls.Add(this.deliverytimeLabel);
            this.priorityOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOptionsGroupBox.Location = new System.Drawing.Point(316, 3);
            this.priorityOptionsGroupBox.Name = "priorityOptionsGroupBox";
            this.priorityOptionsGroupBox.Size = new System.Drawing.Size(307, 153);
            this.priorityOptionsGroupBox.TabIndex = 1;
            this.priorityOptionsGroupBox.TabStop = false;
            this.priorityOptionsGroupBox.Text = "Priority Order";
            // 
            // deliveryTimeBomboBox
            // 
            this.deliveryTimeBomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryTimeBomboBox.FormattingEnabled = true;
            this.deliveryTimeBomboBox.Location = new System.Drawing.Point(144, 21);
            this.deliveryTimeBomboBox.Name = "deliveryTimeBomboBox";
            this.deliveryTimeBomboBox.Size = new System.Drawing.Size(151, 30);
            this.deliveryTimeBomboBox.TabIndex = 15;
            this.deliveryTimeBomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Location = new System.Drawing.Point(3, 168);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(626, 282);
            this.addressControl1.TabIndex = 1;
            // 
            // orderItemsGroupBox
            // 
            this.orderItemsGroupBox.Controls.Add(this.totalCostLabel);
            this.orderItemsGroupBox.Controls.Add(this.amountLabel);
            this.orderItemsGroupBox.Controls.Add(this.orderItemsListBox);
            this.orderItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderItemsGroupBox.Location = new System.Drawing.Point(3, 456);
            this.orderItemsGroupBox.Name = "orderItemsGroupBox";
            this.orderItemsGroupBox.Size = new System.Drawing.Size(626, 307);
            this.orderItemsGroupBox.TabIndex = 2;
            this.orderItemsGroupBox.TabStop = false;
            this.orderItemsGroupBox.Text = "Order Items";
            // 
            // orderItemsListBox
            // 
            this.orderItemsListBox.FormattingEnabled = true;
            this.orderItemsListBox.ItemHeight = 18;
            this.orderItemsListBox.Location = new System.Drawing.Point(10, 23);
            this.orderItemsListBox.Name = "orderItemsListBox";
            this.orderItemsListBox.Size = new System.Drawing.Size(601, 202);
            this.orderItemsListBox.TabIndex = 0;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCostLabel.Location = new System.Drawing.Point(538, 272);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(28, 29);
            this.totalCostLabel.TabIndex = 13;
            this.totalCostLabel.Text = "0";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(523, 248);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(88, 24);
            this.amountLabel.TabIndex = 12;
            this.amountLabel.Text = "Amount:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.createOrderButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.removeItemButton, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.clearCartButton, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 769);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(626, 53);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOrderButton.Location = new System.Drawing.Point(3, 3);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(150, 47);
            this.createOrderButton.TabIndex = 4;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeItemButton.Location = new System.Drawing.Point(315, 3);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(150, 47);
            this.removeItemButton.TabIndex = 5;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // clearCartButton
            // 
            this.clearCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearCartButton.Location = new System.Drawing.Point(471, 3);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(152, 47);
            this.clearCartButton.TabIndex = 7;
            this.clearCartButton.Text = "ClearCart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(632, 825);
            this.Load += new System.EventHandler(this.PriorityOrdersTab_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.selectedOrderGroupBox.ResumeLayout(false);
            this.selectedOrderGroupBox.PerformLayout();
            this.priorityOptionsGroupBox.ResumeLayout(false);
            this.priorityOptionsGroupBox.PerformLayout();
            this.orderItemsGroupBox.ResumeLayout(false);
            this.orderItemsGroupBox.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox selectedOrderGroupBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label PostIndexLabel;
        private System.Windows.Forms.GroupBox priorityOptionsGroupBox;
        private System.Windows.Forms.ComboBox deliveryTimeBomboBox;
        private System.Windows.Forms.Label deliverytimeLabel;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.GroupBox orderItemsGroupBox;
        private System.Windows.Forms.ListBox orderItemsListBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
    }
}

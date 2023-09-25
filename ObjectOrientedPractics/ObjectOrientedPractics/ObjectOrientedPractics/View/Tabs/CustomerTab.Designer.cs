namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.AdressGroupBox = new System.Windows.Forms.GroupBox();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.ApartamentTextBox = new System.Windows.Forms.TextBox();
            this.ApartamentLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.AdressGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 881);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CustomersGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(435, 875);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(429, 781);
            this.CustomersGroupBox.TabIndex = 0;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 26;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 28);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(423, 750);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RemoveButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 790);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(429, 82);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 76);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(146, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(137, 76);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.AdressGroupBox, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(444, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.88571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.11429F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(625, 875);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // AdressGroupBox
            // 
            this.AdressGroupBox.Controls.Add(this.BuildingTextBox);
            this.AdressGroupBox.Controls.Add(this.BuildingLabel);
            this.AdressGroupBox.Controls.Add(this.CountryTextBox);
            this.AdressGroupBox.Controls.Add(this.CountryLabel);
            this.AdressGroupBox.Controls.Add(this.ApartamentTextBox);
            this.AdressGroupBox.Controls.Add(this.ApartamentLabel);
            this.AdressGroupBox.Controls.Add(this.StreetTextBox);
            this.AdressGroupBox.Controls.Add(this.StreetLabel);
            this.AdressGroupBox.Controls.Add(this.CityTextBox);
            this.AdressGroupBox.Controls.Add(this.CityLabel);
            this.AdressGroupBox.Controls.Add(this.PostIndexTextBox);
            this.AdressGroupBox.Controls.Add(this.PostIndexLabel);
            this.AdressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressGroupBox.Location = new System.Drawing.Point(3, 177);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Size = new System.Drawing.Size(619, 695);
            this.AdressGroupBox.TabIndex = 0;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Delivery Adress";
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostIndexLabel.Location = new System.Drawing.Point(6, 50);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(103, 24);
            this.PostIndexLabel.TabIndex = 8;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostIndexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostIndexTextBox.Location = new System.Drawing.Point(111, 47);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(153, 28);
            this.PostIndexTextBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NameTextBox);
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.FullNameLabel);
            this.groupBox2.Controls.Add(this.IdLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Customer";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(6, 47);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(32, 24);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(6, 87);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(99, 24);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full name:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdTextBox.Location = new System.Drawing.Point(111, 44);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(151, 28);
            this.IdTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(111, 83);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(463, 28);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityTextBox.Location = new System.Drawing.Point(429, 106);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(169, 28);
            this.CityTextBox.TabIndex = 11;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(378, 109);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(45, 24);
            this.CityLabel.TabIndex = 10;
            this.CityLabel.Text = "City:";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(111, 165);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(502, 28);
            this.StreetTextBox.TabIndex = 13;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetLabel.Location = new System.Drawing.Point(6, 169);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(63, 24);
            this.StreetLabel.TabIndex = 12;
            this.StreetLabel.Text = "Street:";
            // 
            // ApartamentTextBox
            // 
            this.ApartamentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartamentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartamentTextBox.Location = new System.Drawing.Point(428, 229);
            this.ApartamentTextBox.Name = "ApartamentTextBox";
            this.ApartamentTextBox.Size = new System.Drawing.Size(170, 28);
            this.ApartamentTextBox.TabIndex = 15;
            // 
            // ApartamentLabel
            // 
            this.ApartamentLabel.AutoSize = true;
            this.ApartamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartamentLabel.Location = new System.Drawing.Point(311, 233);
            this.ApartamentLabel.Name = "ApartamentLabel";
            this.ApartamentLabel.Size = new System.Drawing.Size(111, 24);
            this.ApartamentLabel.TabIndex = 14;
            this.ApartamentLabel.Text = "Apartament:";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryTextBox.Location = new System.Drawing.Point(111, 106);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(226, 28);
            this.CountryTextBox.TabIndex = 17;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(6, 109);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(80, 24);
            this.CountryLabel.TabIndex = 16;
            this.CountryLabel.Text = "Country:";
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingTextBox.Location = new System.Drawing.Point(111, 229);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(194, 28);
            this.BuildingTextBox.TabIndex = 19;
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingLabel.Location = new System.Drawing.Point(6, 233);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(83, 24);
            this.BuildingLabel.TabIndex = 18;
            this.BuildingLabel.Text = "Building:";
            // 
            // CustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerTab";
            this.Size = new System.Drawing.Size(1072, 881);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.CustomersGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.AdressGroupBox.ResumeLayout(false);
            this.AdressGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.GroupBox AdressGroupBox;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.Label PostIndexLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox ApartamentTextBox;
        private System.Windows.Forms.Label ApartamentLabel;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
    }
}

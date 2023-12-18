namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.AdressGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.ApartamentTextBox = new System.Windows.Forms.TextBox();
            this.ApartamentLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.AdressGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.AdressGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Size = new System.Drawing.Size(896, 502);
            this.AdressGroupBox.TabIndex = 2;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Delivery Adress";
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingTextBox.Location = new System.Drawing.Point(111, 229);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(194, 28);
            this.BuildingTextBox.TabIndex = 19;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            this.BuildingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuildingTextBox_KeyPress);
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
            // CountryTextBox
            // 
            this.CountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryTextBox.Location = new System.Drawing.Point(111, 106);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(226, 28);
            this.CountryTextBox.TabIndex = 17;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            this.CountryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryTextBox_KeyPress);
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
            // ApartamentTextBox
            // 
            this.ApartamentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartamentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartamentTextBox.Location = new System.Drawing.Point(428, 229);
            this.ApartamentTextBox.Name = "ApartamentTextBox";
            this.ApartamentTextBox.Size = new System.Drawing.Size(447, 28);
            this.ApartamentTextBox.TabIndex = 15;
            this.ApartamentTextBox.TextChanged += new System.EventHandler(this.ApartamentTextBox_TextChanged);
            this.ApartamentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApartamentextBox_KeyPress);
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
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(111, 165);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(764, 28);
            this.StreetTextBox.TabIndex = 13;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            this.StreetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StreetTextBox_KeyPress);
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
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityTextBox.Location = new System.Drawing.Point(429, 106);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(446, 28);
            this.CityTextBox.TabIndex = 11;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            this.CityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityTextBox_KeyPress);
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(378, 109);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(45, 24);
            this.CityLabel.TabIndex = 10;
            this.CityLabel.Text = "City:";
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostIndexTextBox.Location = new System.Drawing.Point(111, 47);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(226, 28);
            this.PostIndexTextBox.TabIndex = 9;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            this.PostIndexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostIndexTextBox_KeyPress);
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
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdressGroupBox);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(896, 502);
            this.AdressGroupBox.ResumeLayout(false);
            this.AdressGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdressGroupBox;
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
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.Label PostIndexLabel;
    }
}

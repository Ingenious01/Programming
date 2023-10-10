namespace ObjectOrientedPractics
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTavPage = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customerTab1 = new ObjectOrientedPractics.View.Tabs.CustomerTab();
            this.MainTavPage.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTavPage
            // 
            this.MainTavPage.Controls.Add(this.ItemsTabPage);
            this.MainTavPage.Controls.Add(this.CustomersTabPage);
            this.MainTavPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTavPage.Location = new System.Drawing.Point(0, 0);
            this.MainTavPage.Name = "MainTavPage";
            this.MainTavPage.SelectedIndex = 0;
            this.MainTavPage.Size = new System.Drawing.Size(996, 762);
            this.MainTavPage.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.itemsTab1);
            this.ItemsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(988, 733);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.customerTab1);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(988, 733);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(982, 727);
            this.itemsTab1.TabIndex = 0;
            // 
            // customerTab1
            // 
            this.customerTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTab1.Location = new System.Drawing.Point(3, 3);
            this.customerTab1.Name = "customerTab1";
            this.customerTab1.Size = new System.Drawing.Size(982, 727);
            this.customerTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 762);
            this.Controls.Add(this.MainTavPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTavPage.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTavPage;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomerTab customerTab1;
    }
}


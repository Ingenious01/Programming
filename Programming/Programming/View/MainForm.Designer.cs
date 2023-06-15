namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabPage = new TabControl();
            EnumPage = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            weekdayparsingControl1 = new View.Panels.WeekdayParsingControl();
            seasonControl1 = new View.Panels.SeasonControl();
            allEnumerationsControl1 = new View.Panels.AllEnumerationsControl();
            ClassesTabPage = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            RectanglesTabPage1 = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            moviesControl2 = new View.Panels.MoviesControl();
            MainTabPage.SuspendLayout();
            EnumPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            RectanglesTabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabPage
            // 
            MainTabPage.Controls.Add(EnumPage);
            MainTabPage.Controls.Add(ClassesTabPage);
            MainTabPage.Controls.Add(RectanglesTabPage1);
            MainTabPage.Dock = DockStyle.Fill;
            MainTabPage.Location = new Point(0, 0);
            MainTabPage.Margin = new Padding(3, 4, 3, 4);
            MainTabPage.Name = "MainTabPage";
            MainTabPage.SelectedIndex = 0;
            MainTabPage.Size = new Size(1072, 680);
            MainTabPage.TabIndex = 0;
            // 
            // EnumPage
            // 
            EnumPage.Controls.Add(tableLayoutPanel1);
            EnumPage.Location = new Point(4, 29);
            EnumPage.Margin = new Padding(3, 4, 3, 4);
            EnumPage.Name = "EnumPage";
            EnumPage.Padding = new Padding(3, 4, 3, 4);
            EnumPage.Size = new Size(1064, 647);
            EnumPage.TabIndex = 0;
            EnumPage.Text = "Enum";
            EnumPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(allEnumerationsControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.07449F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.92551F));
            tableLayoutPanel1.Size = new Size(1058, 639);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(weekdayparsingControl1, 0, 0);
            tableLayoutPanel2.Controls.Add(seasonControl1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 403);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1058, 236);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // weekdayparsingControl1
            // 
            weekdayparsingControl1.Dock = DockStyle.Fill;
            weekdayparsingControl1.Location = new Point(3, 3);
            weekdayparsingControl1.Name = "weekdayparsingControl1";
            weekdayparsingControl1.Size = new Size(523, 230);
            weekdayparsingControl1.TabIndex = 7;
            // 
            // seasonControl1
            // 
            seasonControl1.Dock = DockStyle.Fill;
            seasonControl1.Location = new Point(532, 3);
            seasonControl1.Name = "seasonControl1";
            seasonControl1.Size = new Size(523, 230);
            seasonControl1.TabIndex = 8;
            // 
            // allEnumerationsControl1
            // 
            allEnumerationsControl1.Dock = DockStyle.Fill;
            allEnumerationsControl1.Location = new Point(3, 3);
            allEnumerationsControl1.Name = "allEnumerationsControl1";
            allEnumerationsControl1.Size = new Size(1052, 397);
            allEnumerationsControl1.TabIndex = 8;
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(tableLayoutPanel3);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(1064, 647);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(rectanglesControl1, 0, 0);
            tableLayoutPanel3.Controls.Add(moviesControl2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1058, 641);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Dock = DockStyle.Fill;
            rectanglesControl1.Location = new Point(3, 3);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(523, 635);
            rectanglesControl1.TabIndex = 2;
            // 
            // RectanglesTabPage1
            // 
            RectanglesTabPage1.Controls.Add(rectanglesCollisionControl1);
            RectanglesTabPage1.Location = new Point(4, 29);
            RectanglesTabPage1.Name = "RectanglesTabPage1";
            RectanglesTabPage1.Padding = new Padding(3);
            RectanglesTabPage1.Size = new Size(1064, 647);
            RectanglesTabPage1.TabIndex = 2;
            RectanglesTabPage1.Text = "Rectangles";
            RectanglesTabPage1.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(1058, 641);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // moviesControl2
            // 
            moviesControl2.Dock = DockStyle.Fill;
            moviesControl2.Location = new Point(532, 3);
            moviesControl2.Name = "moviesControl2";
            moviesControl2.Size = new Size(523, 635);
            moviesControl2.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1072, 680);
            Controls.Add(MainTabPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            MinimumSize = new Size(849, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            MainTabPage.ResumeLayout(false);
            EnumPage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ClassesTabPage.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            RectanglesTabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabPage;
        private TabPage ClassesTabPage;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage RectanglesTabPage1;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private TabPage EnumPage;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesControl moviesControl1;
        private View.Panels.AllEnumerationsControl allEnumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayparsingControl1;
        private View.Panels.SeasonControl seasonControl1;
        private View.Panels.MoviesControl moviesControl2;
    }
}
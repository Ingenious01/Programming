namespace Programming.View.Panels
{
    partial class SeasonControl
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
            SeasonHandleBox = new GroupBox();
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            SeasonHandleBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonHandleBox
            // 
            SeasonHandleBox.AccessibleRole = AccessibleRole.Client;
            SeasonHandleBox.Controls.Add(SeasonButton);
            SeasonHandleBox.Controls.Add(SeasonComboBox);
            SeasonHandleBox.Controls.Add(SeasonLabel);
            SeasonHandleBox.Dock = DockStyle.Fill;
            SeasonHandleBox.Location = new Point(0, 0);
            SeasonHandleBox.Name = "SeasonHandleBox";
            SeasonHandleBox.Size = new Size(712, 391);
            SeasonHandleBox.TabIndex = 7;
            SeasonHandleBox.TabStop = false;
            SeasonHandleBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            SeasonButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SeasonButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SeasonButton.Location = new Point(476, 77);
            SeasonButton.Margin = new Padding(25, 3, 3, 3);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(125, 35);
            SeasonButton.TabIndex = 2;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SeasonComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 77);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(421, 33);
            SeasonComboBox.TabIndex = 3;
            SeasonComboBox.SelectedIndexChanged += SeasonComboBox_SelectedIndexChanged;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SeasonLabel.Location = new Point(6, 37);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(142, 25);
            SeasonLabel.TabIndex = 0;
            SeasonLabel.Text = "Choose season:";
            // 
            // SeasonControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandleBox);
            Name = "SeasonControl";
            Size = new Size(712, 391);
            SeasonHandleBox.ResumeLayout(false);
            SeasonHandleBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonHandleBox;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
    }
}

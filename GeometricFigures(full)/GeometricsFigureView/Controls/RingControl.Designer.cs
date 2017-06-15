namespace GeometricsFigureView.Controls
{
    partial class RingControl
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
            this.OutsideRadiusLabel = new System.Windows.Forms.Label();
            this.InnerRadiusLabel = new System.Windows.Forms.Label();
            this.OutsideRadiusTextBox = new System.Windows.Forms.TextBox();
            this.InnerRadiusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutsideRadiusLabel
            // 
            this.OutsideRadiusLabel.AutoSize = true;
            this.OutsideRadiusLabel.Location = new System.Drawing.Point(60, 38);
            this.OutsideRadiusLabel.Name = "OutsideRadiusLabel";
            this.OutsideRadiusLabel.Size = new System.Drawing.Size(90, 13);
            this.OutsideRadiusLabel.TabIndex = 0;
            this.OutsideRadiusLabel.Text = "Внешний радиус";
            // 
            // InnerRadiusLabel
            // 
            this.InnerRadiusLabel.AutoSize = true;
            this.InnerRadiusLabel.Location = new System.Drawing.Point(205, 38);
            this.InnerRadiusLabel.Name = "InnerRadiusLabel";
            this.InnerRadiusLabel.Size = new System.Drawing.Size(104, 13);
            this.InnerRadiusLabel.TabIndex = 1;
            this.InnerRadiusLabel.Text = "Внутренний радиус";
            // 
            // OutsideRadiusTextBox
            // 
            this.OutsideRadiusTextBox.Location = new System.Drawing.Point(63, 54);
            this.OutsideRadiusTextBox.Name = "OutsideRadiusTextBox";
            this.OutsideRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutsideRadiusTextBox.TabIndex = 2;
            // 
            // InnerRadiusTextBox
            // 
            this.InnerRadiusTextBox.Location = new System.Drawing.Point(208, 54);
            this.InnerRadiusTextBox.Name = "InnerRadiusTextBox";
            this.InnerRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.InnerRadiusTextBox.TabIndex = 3;
            // 
            // RingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InnerRadiusTextBox);
            this.Controls.Add(this.OutsideRadiusTextBox);
            this.Controls.Add(this.InnerRadiusLabel);
            this.Controls.Add(this.OutsideRadiusLabel);
            this.Name = "RingControl";
            this.Size = new System.Drawing.Size(390, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutsideRadiusLabel;
        private System.Windows.Forms.Label InnerRadiusLabel;
        private System.Windows.Forms.TextBox OutsideRadiusTextBox;
        private System.Windows.Forms.TextBox InnerRadiusTextBox;
    }
}

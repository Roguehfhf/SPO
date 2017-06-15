using System;

namespace GeometricsFigureView.Controls
{
    partial class FigureControl
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
            this.FigureComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.triangleControl1 = new GeometricsFigureView.Controls.TriangleControl();
            this.ringControl1 = new GeometricsFigureView.Controls.RingControl();
            this.rectangleControl1 = new GeometricsFigureView.Controls.RectangleControl();
            this.circleControl1 = new GeometricsFigureView.Controls.CircleControl();
            this.SuspendLayout();
            // 
            // FigureComboBox1
            // 
            this.FigureComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureComboBox1.FormattingEnabled = true;
            this.FigureComboBox1.Location = new System.Drawing.Point(138, 33);
            this.FigureComboBox1.Name = "FigureComboBox1";
            this.FigureComboBox1.Size = new System.Drawing.Size(136, 21);
            this.FigureComboBox1.TabIndex = 0;
            this.FigureComboBox1.SelectedIndexChanged += new System.EventHandler(this.figurecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите фигуру";
            // 
            // triangleControl1
            // 
            this.triangleControl1.Location = new System.Drawing.Point(15, 60);
            this.triangleControl1.Name = "triangleControl1";
            this.triangleControl1.Size = new System.Drawing.Size(390, 110);
            this.triangleControl1.TabIndex = 5;
            // 
            // ringControl1
            // 
            this.ringControl1.Location = new System.Drawing.Point(15, 60);
            this.ringControl1.Name = "ringControl1";
            this.ringControl1.Size = new System.Drawing.Size(390, 110);
            this.ringControl1.TabIndex = 4;
            // 
            // rectangleControl1
            // 
            this.rectangleControl1.Location = new System.Drawing.Point(15, 60);
            this.rectangleControl1.Name = "rectangleControl1";
            this.rectangleControl1.Size = new System.Drawing.Size(390, 110);
            this.rectangleControl1.TabIndex = 3;
            // 
            // circleControl1
            // 
            this.circleControl1.Location = new System.Drawing.Point(15, 60);
            this.circleControl1.Name = "circleControl1";
            this.circleControl1.Size = new System.Drawing.Size(390, 110);
            this.circleControl1.TabIndex = 2;
            // 
            // FigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.triangleControl1);
            this.Controls.Add(this.ringControl1);
            this.Controls.Add(this.rectangleControl1);
            this.Controls.Add(this.circleControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FigureComboBox1);
            this.Name = "FigureControl";
            this.Size = new System.Drawing.Size(420, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureComboBox1;
        private System.Windows.Forms.Label label1;
        private CircleControl circleControl1;
        private RectangleControl rectangleControl1;
        private RingControl ringControl1;
        private TriangleControl triangleControl1;
    }
}

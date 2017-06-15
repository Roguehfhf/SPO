namespace GeometricsFigureView
{
    partial class AddFigureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFigureForm));
            this.FigureComboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InnerRadiusTextBox = new System.Windows.Forms.TextBox();
            this.OutsideRadiusTextBox = new System.Windows.Forms.TextBox();
            this.InnerRadiusLabel = new System.Windows.Forms.Label();
            this.OutsideRadiusLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.SideCLabel = new System.Windows.Forms.Label();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.SideALabel = new System.Windows.Forms.Label();
            this.SideCTextBox = new System.Windows.Forms.TextBox();
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FigureComboBox1
            // 
            this.FigureComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureComboBox1.FormattingEnabled = true;
            this.FigureComboBox1.Items.AddRange(new object[] {
            resources.GetString("FigureComboBox1.Items"),
            resources.GetString("FigureComboBox1.Items1"),
            resources.GetString("FigureComboBox1.Items2"),
            resources.GetString("FigureComboBox1.Items3")});
            resources.ApplyResources(this.FigureComboBox1, "FigureComboBox1");
            this.FigureComboBox1.Name = "FigureComboBox1";
            this.FigureComboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OkButton);
            this.groupBox1.Controls.Add(this.CanselButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FigureComboBox1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CanselButton
            // 
            resources.ApplyResources(this.CanselButton, "CanselButton");
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.UseVisualStyleBackColor = true;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InnerRadiusTextBox);
            this.groupBox2.Controls.Add(this.OutsideRadiusTextBox);
            this.groupBox2.Controls.Add(this.InnerRadiusLabel);
            this.groupBox2.Controls.Add(this.OutsideRadiusLabel);
            this.groupBox2.Controls.Add(this.RadiusLabel);
            this.groupBox2.Controls.Add(this.RadiusTextBox);
            this.groupBox2.Controls.Add(this.SideCLabel);
            this.groupBox2.Controls.Add(this.SideBLabel);
            this.groupBox2.Controls.Add(this.SideALabel);
            this.groupBox2.Controls.Add(this.SideCTextBox);
            this.groupBox2.Controls.Add(this.SideBTextBox);
            this.groupBox2.Controls.Add(this.SideATextBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // InnerRadiusTextBox
            // 
            resources.ApplyResources(this.InnerRadiusTextBox, "InnerRadiusTextBox");
            this.InnerRadiusTextBox.Name = "InnerRadiusTextBox";
            this.InnerRadiusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InnerRadiusTextBox_KeyPress);
            // 
            // OutsideRadiusTextBox
            // 
            resources.ApplyResources(this.OutsideRadiusTextBox, "OutsideRadiusTextBox");
            this.OutsideRadiusTextBox.Name = "OutsideRadiusTextBox";
            this.OutsideRadiusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutsideRadiusTextBox_KeyPress);
            // 
            // InnerRadiusLabel
            // 
            resources.ApplyResources(this.InnerRadiusLabel, "InnerRadiusLabel");
            this.InnerRadiusLabel.Name = "InnerRadiusLabel";
            // 
            // OutsideRadiusLabel
            // 
            resources.ApplyResources(this.OutsideRadiusLabel, "OutsideRadiusLabel");
            this.OutsideRadiusLabel.Name = "OutsideRadiusLabel";
            // 
            // RadiusLabel
            // 
            resources.ApplyResources(this.RadiusLabel, "RadiusLabel");
            this.RadiusLabel.Name = "RadiusLabel";
            // 
            // RadiusTextBox
            // 
            resources.ApplyResources(this.RadiusTextBox, "RadiusTextBox");
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadiusTextBox_KeyPress);
            // 
            // SideCLabel
            // 
            resources.ApplyResources(this.SideCLabel, "SideCLabel");
            this.SideCLabel.Name = "SideCLabel";
            // 
            // SideBLabel
            // 
            resources.ApplyResources(this.SideBLabel, "SideBLabel");
            this.SideBLabel.Name = "SideBLabel";
            // 
            // SideALabel
            // 
            resources.ApplyResources(this.SideALabel, "SideALabel");
            this.SideALabel.Name = "SideALabel";
            // 
            // SideCTextBox
            // 
            resources.ApplyResources(this.SideCTextBox, "SideCTextBox");
            this.SideCTextBox.Name = "SideCTextBox";
            this.SideCTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideCTextBox_KeyPress);
            // 
            // SideBTextBox
            // 
            resources.ApplyResources(this.SideBTextBox, "SideBTextBox");
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.TextChanged += new System.EventHandler(this.SideBTextBox_TextChanged);
            this.SideBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideBTextBox_KeyPress);
            // 
            // SideATextBox
            // 
            resources.ApplyResources(this.SideATextBox, "SideATextBox");
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideATextBox_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AddFigureForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddFigureForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SideCTextBox;
        private System.Windows.Forms.TextBox SideBTextBox;
        private System.Windows.Forms.TextBox SideATextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SideBLabel;
        private System.Windows.Forms.Label SideALabel;
        private System.Windows.Forms.Label SideCLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label OutsideRadiusLabel;
        private System.Windows.Forms.Label InnerRadiusLabel;
        private System.Windows.Forms.TextBox InnerRadiusTextBox;
        private System.Windows.Forms.TextBox OutsideRadiusTextBox;
        private System.Windows.Forms.Button OkButton;
    }
}


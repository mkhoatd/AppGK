namespace AppGK
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.NgayNhapDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TenSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.MaSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.MatHangComboBox = new System.Windows.Forms.ComboBox();
            this.NhaSanXuatComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NhaSanXuatComboBox);
            this.groupBox1.Controls.Add(this.MatHangComboBox);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.NgayNhapDateTimePicker);
            this.groupBox1.Controls.Add(this.TenSanPhamTextBox);
            this.groupBox1.Controls.Add(this.MaSanPhamTextBox);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.OKButton);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(634, 127);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 20);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hết hàng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(525, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 20);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Còn hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // NgayNhapDateTimePicker
            // 
            this.NgayNhapDateTimePicker.Location = new System.Drawing.Point(111, 125);
            this.NgayNhapDateTimePicker.Name = "NgayNhapDateTimePicker";
            this.NgayNhapDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.NgayNhapDateTimePicker.TabIndex = 11;
            // 
            // TenSanPhamTextBox
            // 
            this.TenSanPhamTextBox.Location = new System.Drawing.Point(111, 76);
            this.TenSanPhamTextBox.Name = "TenSanPhamTextBox";
            this.TenSanPhamTextBox.Size = new System.Drawing.Size(100, 22);
            this.TenSanPhamTextBox.TabIndex = 8;
            // 
            // MaSanPhamTextBox
            // 
            this.MaSanPhamTextBox.Location = new System.Drawing.Point(111, 23);
            this.MaSanPhamTextBox.Name = "MaSanPhamTextBox";
            this.MaSanPhamTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaSanPhamTextBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(478, 200);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(236, 200);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(17, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(88, 16);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Mã sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhà SX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mặt hàng";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(17, 127);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 16);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Ngày nhập";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Tên sản phẩm";
            // 
            // MatHangComboBox
            // 
            this.MatHangComboBox.FormattingEnabled = true;
            this.MatHangComboBox.Location = new System.Drawing.Point(525, 23);
            this.MatHangComboBox.Name = "MatHangComboBox";
            this.MatHangComboBox.Size = new System.Drawing.Size(121, 24);
            this.MatHangComboBox.TabIndex = 14;
            this.MatHangComboBox.SelectedIndexChanged += new System.EventHandler(this.MatHangComboBox_SelectedIndexChanged);
            // 
            // NhaSanXuatComboBox
            // 
            this.NhaSanXuatComboBox.FormattingEnabled = true;
            this.NhaSanXuatComboBox.Location = new System.Drawing.Point(525, 76);
            this.NhaSanXuatComboBox.Name = "NhaSanXuatComboBox";
            this.NhaSanXuatComboBox.Size = new System.Drawing.Size(121, 24);
            this.NhaSanXuatComboBox.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 312);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker NgayNhapDateTimePicker;
        private System.Windows.Forms.TextBox TenSanPhamTextBox;
        private System.Windows.Forms.TextBox MaSanPhamTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox NhaSanXuatComboBox;
        private System.Windows.Forms.ComboBox MatHangComboBox;
    }
}
namespace BaiTapBuoi4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMSNV = new TextBox();
            txtTenNhanVien = new TextBox();
            txtLuongCoBan = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 0;
            label1.Text = "MSNV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.Location = new Point(50, 67);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(57, 117);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Lương Cơ Bản:";
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(249, 20);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(222, 27);
            txtMSNV.TabIndex = 3;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(249, 71);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(387, 27);
            txtTenNhanVien.TabIndex = 4;
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(249, 121);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(222, 27);
            txtLuongCoBan.TabIndex = 5;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(205, 183);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(117, 30);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng Ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(372, 183);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(117, 30);
            btnBoQua.TabIndex = 7;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 241);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtLuongCoBan);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMSNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Nhân Viên";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMSNV;
        private TextBox txtTenNhanVien;
        private TextBox txtLuongCoBan;
        private Button btnDongY;
        private Button btnBoQua;
    }
}
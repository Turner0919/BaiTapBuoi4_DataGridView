namespace BaiTapBuoi4
{
    partial class Form1
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
            GridViewNV = new DataGridView();
            MSNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            LuongCB = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDesign = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewNV).BeginInit();
            SuspendLayout();
            // 
            // GridViewNV
            // 
            GridViewNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewNV.Columns.AddRange(new DataGridViewColumn[] { MSNV, TenNV, LuongCB });
            GridViewNV.Location = new Point(24, 30);
            GridViewNV.Name = "GridViewNV";
            GridViewNV.RowHeadersVisible = false;
            GridViewNV.RowHeadersWidth = 51;
            GridViewNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewNV.Size = new Size(474, 395);
            GridViewNV.TabIndex = 0;
            // 
            // MSNV
            // 
            MSNV.HeaderText = "MSNV";
            MSNV.MinimumWidth = 6;
            MSNV.Name = "MSNV";
            MSNV.Width = 120;
            // 
            // TenNV
            // 
            TenNV.HeaderText = "TenNV";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.Width = 200;
            // 
            // LuongCB
            // 
            LuongCB.HeaderText = "LuongCB";
            LuongCB.MinimumWidth = 6;
            LuongCB.Name = "LuongCB";
            LuongCB.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAdd.Location = new Point(565, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDesign
            // 
            btnDesign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDesign.Location = new Point(565, 119);
            btnDesign.Name = "btnDesign";
            btnDesign.Size = new Size(177, 40);
            btnDesign.TabIndex = 2;
            btnDesign.Text = "Sửa";
            btnDesign.UseVisualStyleBackColor = true;
            btnDesign.Click += btnDesign_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDelete.Location = new Point(565, 197);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnClose.Location = new Point(565, 272);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnDesign);
            Controls.Add(btnAdd);
            Controls.Add(GridViewNV);
            Name = "Form1";
            Text = "List View";
            ((System.ComponentModel.ISupportInitialize)GridViewNV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridViewNV;
        private DataGridViewTextBoxColumn MSNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn LuongCB;
        private Button btnAdd;
        private Button btnDesign;
        private Button btnDelete;
        private Button btnClose;
    }
}

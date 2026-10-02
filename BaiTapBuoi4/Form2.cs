using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTapBuoi4
{
    public partial class Form2 : Form
    {
        public string MSNV { get; private set; }
        public string TenNV { get; private set; }
        public string LuongCB { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(string msnv, string tenNV, string luongCB) : this()
        {
            txtMSNV.Text = msnv;
            txtTenNhanVien.Text = tenNV;
            txtLuongCoBan.Text = luongCB;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa nhập MSNV
            if (string.IsNullOrWhiteSpace(txtMSNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã số nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSNV.Focus();
                return;
            }

            // Gán giá trị từ TextBox vào các thuộc tính
            MSNV = txtMSNV.Text.Trim();
            TenNV = txtTenNhanVien.Text.Trim();
            LuongCB = txtLuongCoBan.Text.Trim();

            // Đặt kết quả là OK và đóng Form2
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

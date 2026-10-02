namespace BaiTapBuoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                // Mở Form2 và chờ người dùng thao tác
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    // Đưa dữ liệu từ Form2 vào DataGridView
                    GridViewNV.Rows.Add(f2.MSNV, f2.TenNV, f2.LuongCB);
                }
            }
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            if (GridViewNV.SelectedRows.Count > 0 || GridViewNV.CurrentRow != null)
            {
                // Lấy dòng đang chọn
                DataGridViewRow row = GridViewNV.CurrentRow;

                // Kiểm tra dòng đó có dữ liệu hay không (tránh chọn dòng trống cuối cùng)
                if (row.Cells[0].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng có dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dữ liệu 3 cột của dòng đang chọn
                string msnv = row.Cells[0].Value?.ToString() ?? "";
                string tenNV = row.Cells[1].Value?.ToString() ?? "";
                string luongCB = row.Cells[2].Value?.ToString() ?? "";

                // Mở Form2 và truyền dữ liệu sang
                using (Form2 f2 = new Form2(msnv, tenNV, luongCB))
                {
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        // Cập nhật lại dữ liệu cho dòng đang chọn
                        row.Cells[0].Value = f2.MSNV;
                        row.Cells[1].Value = f2.TenNV;
                        row.Cells[2].Value = f2.LuongCB;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (GridViewNV.CurrentRow != null && !GridViewNV.CurrentRow.IsNewRow)
            {
                // Kiểm tra xem dòng đó có dữ liệu không
                if (GridViewNV.CurrentRow.Cells[0].Value != null)
                {
                    // Hiển thị hộp thoại xác nhận trước khi xóa
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Nếu người dùng chọn Yes
                    if (result == DialogResult.Yes)
                    {
                        // Xóa dòng đang chọn khỏi GridViewNV
                        GridViewNV.Rows.Remove(GridViewNV.CurrentRow);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Tắt Form1 và thoát toàn bộ ứng dụng
                Application.Exit();
            }
        }
    }
}

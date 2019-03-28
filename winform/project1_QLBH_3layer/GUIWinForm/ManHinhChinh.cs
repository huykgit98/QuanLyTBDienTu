using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUIWinForm
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {

            InitializeComponent();
            
        }
        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            DuaLoaiThietBiLenComboboxTraCuu();
            DuaDSThietBiLenDataGridView();
            DuaLoaiTBLenCombobox();
            DuaDSHoaDonLenDataGridView();
        }

        private void DuaLoaiThietBiLenComboboxTraCuu()
        {
            List<Category> _dsltd = CategoryBLL.LayDSLoaiThietBi();
            cmbLoaiTB.DataSource = _dsltd;
            cmbLoaiTB.DisplayMember = "name_cate";
            cmbLoaiTB.ValueMember = "id";
        }


        // lấy danh sách thiet bi
        public void DuaDSThietBiLenDataGridView()
        {
            DataTable _dstb = ProductBLL.LayDanhSachTB();
            dgvDSTB.DataSource = _dstb;
        }

        private void dgvDSTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DuaLoaiTBLenCombobox()
        {
            List<Category> _dsltb = CategoryBLL.LayDSLoaiThietBi();
            cmbLoaiTB.DataSource = _dsltb;
            cmbLoaiTB.DisplayMember = "name_cate";
            cmbLoaiTB.ValueMember = "id";

        }
        //Thêm Thiết Bị
        private void ThemThietBi()
        {
            Product tb = new Product();
            tb.Id = ProductBLL.MaTuTang();
            tb.Id_cate = CategoryBLL.LayMaLoaiTuTenLoai(cmbLoaiTB.Text);
            tb.Name_pro = txtTenTB.Text;
            
             try
            {
                tb.Qty = int.Parse(txtSLTon.Text);
                tb.Price = int.Parse(txtDonGia.Text);

                bool kt = ProductBLL.KiemTraTrungTenThietBi(tb.Name_pro);
                if (kt == true)
                 {
                bool kq = ProductBLL.ThemThietBi(tb);
                    if (kq == true)
                    {
                       
                        MessageBox.Show("Thêm thiết bị thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DuaDSThietBiLenDataGridView();
                        txtTenTB.Text = "";
                        txtSLTon.Text = "";
                        txtDonGia.Text = "";
                    }
                }
                else
                    MessageBox.Show("Thiết bị này đã có!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu đơn giá hoặc số lượng không chính xác! Vui lòng nhập lại!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenTB.Text != "")
            {
                if (txtSLTon.Text != "")
                {
                    if (txtDonGia.Text != "")
                    {
        
                        ThemThietBi();
                    }
                    else
                        MessageBox.Show("Chưa nhập đơn giá!");
                }
                else
                    MessageBox.Show("Chưa nhập số lượng tồn!");
            }
            else
                MessageBox.Show("Chưa nhập tên thiết bị!");
        }


        //end thêm thiết bị
        
        //cập nhật và xóa thiết bị

        private void btnSua_Click(object sender, EventArgs e)
        {
            Product tb = new Product();
            int idx = dgvDSTB.CurrentRow.Index;
            if (txtTenTB.Text != "")
            {

                if (txtSLTon.Text != "")
                {
                    tb.Id = dgvDSTB.Rows[idx].Cells[0].Value.ToString();
                    tb.Id_cate = CategoryBLL.LayMaLoaiTuTenLoai(cmbLoaiTB.Text);
                    tb.Name_pro = txtTenTB.Text;
                    tb.Qty = int.Parse(txtSLTon.Text);

                    bool kt;
                    kt = ProductBLL.KiemTraTenTBCapNhat(txtTenTB.Text, tb.Id);
                    if (kt == true)
                    {

                        try
                        {
                            int gia = int.Parse(txtDonGia.Text);
                            if (gia > 0)
                            {
                                tb.Price = gia;
                                bool kq1 = ProductBLL.CapNhatThietBi(tb);
                                if (kq1 == true)
                                {
                                    MessageBox.Show("Cập nhật thiết bị thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtTenTB.Text = "";
                                    txtSLTon.Text = "";
                                    txtDonGia.Text = "";
                                    cmbTraCuuLoaiTB_SelectedValueChanged(sender, e);
                                }
                                else
                                    MessageBox.Show("Cập nhật thiết bị thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtDonGia.Text = "";
                                txtDonGia.Focus();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Chưa nhập đơn giá hoặc kiểu dữ liệu đơn giá không đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDonGia.Text = "";
                            txtDonGia.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên thiết bị bị trùng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenTB.Text = "";
                        txtTenTB.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập số lượng tồn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSLTon.Text = "";
                    txtSLTon.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên thiết bị!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTB.Text = "";
                txtTenTB.Focus();
            }
        }


        private void cmbTraCuuLoaiTB_Click(object sender, EventArgs e)
        {
            List<Category> _dsltb = CategoryBLL.LayDSLoaiThietBi();
            cmbLoaiTB.DataSource = _dsltb;
            cmbLoaiTB.DisplayMember = "name_cate";
            cmbLoaiTB.ValueMember = "id";

            cmbTraCuuLoaiTB.DataSource = _dsltb;
            cmbTraCuuLoaiTB.DisplayMember = "name_cate";
            cmbTraCuuLoaiTB.ValueMember = "id";
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idx = dgvDSTB.CurrentRow.Index;
                string maTB = (dgvDSTB.Rows[idx].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    bool kq;
                    try
                    {
                        kq = ProductBLL.XoaThietBiTheoMaTB(maTB);

                        if (kq == true)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTenTB.Text = "";
                            txtSLTon.Text = "";
                            txtDonGia.Text = "";
                            DuaDSThietBiLenDataGridView();
                            
                          if (txtTraCuuTenTB.Text != "")
                               btnTim_Click(sender, e);
                           if (cmbTraCuuLoaiTB.Text != "")
                                cmbTraCuuLoaiTB_SelectedValueChanged(sender, e);
                        }
                        else
                            MessageBox.Show("Xóa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn thiết bị cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //end cập nhật và xóa thiết bị

        
        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTenTB.Text = "";
            cmbLoaiTB.Text = "";
            txtDonGia.Text = "";
            txtSLTon.Text = "";
            if (txtTraCuuTenTB.Text == "")
                MessageBox.Show("Chưa nhập tên thiết bị cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable kq = ProductBLL.TraCuuThietBiTheoTen(txtTraCuuTenTB.Text);
                dgvDSTB.DataSource = kq;
            }
        }

        private void cmbTraCuuLoaiTB_SelectedValueChanged(object sender, EventArgs e)
        {
            string maLoai = CategoryBLL.LayMaLoaiTuTenLoai(cmbTraCuuLoaiTB.Text);
            DataTable dsTD = ProductBLL.LayDanhSachTBTheoMaLoai(maLoai);
            dgvDSTB.DataSource = dsTD;
            txtTraCuuTenTB.Text = "";

        }

        //QUẢN LÝ HÓA ĐƠN
        public void DuaDSHoaDonLenDataGridView()
        {
            DataTable _dshd = BillBLL.LayDSHoaDon();
            dgvDSHD.DataSource = _dshd;

        }
 


        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = dgvDSHD.CurrentRow.Index;
                string maHD = dgvDSHD.Rows[idx].Cells[0].Value.ToString();
                DataTable _ds = BillDetailsBLL.LayDSCTHDTuMaHD(maHD);
                dgvCTHD.DataSource = _ds;
            }
            catch { }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            DuaDSThietBiLenDataGridView();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            HoaDonReport hdr = new HoaDonReport();
            hdr.CreateDocument();
            FrmReportHoaDon frm = new FrmReportHoaDon();
            frm.documentViewer1.DocumentSource = hdr;
            frm.ShowDialog();
            
        }

     
    }
}

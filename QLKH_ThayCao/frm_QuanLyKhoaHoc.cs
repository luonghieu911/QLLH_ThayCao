using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_ThayCao
{
    public partial class frm_QuanLyKhoaHoc : Form
    {
        int currentPageIndex = 1;
        int pageSize = 2; //Số lượng dòng hiển thị trên 1 trang
        int pageNumber = 0;
        int rows; //tổng số bản ghi    

        void pageTotal()
        {
            pageNumber = rows % pageSize != 0 ? rows / pageSize +1 : rows/pageSize;
            totalPage_lbl.Text = " / " + pageNumber.ToString();
            Page_cmb.Items.Clear();
            for (int i = 1; i <= pageNumber; i++)
            {
                Page_cmb.Items.Add(i + "");
            }
            Page_cmb.SelectedIndex = 0;
        }


        DatabaseDataContext db = new DatabaseDataContext();
        public frm_QuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        private void loadData_4_DSKhoaHoc_dgv()
        {
            var dskh = db.tbl_KhoaHocs.ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
            DSKhoaHoc_dgv.FirstDisplayedScrollingColumnIndex = DSKhoaHoc_dgv.ColumnCount - 1;
            SuaKhoaHoc_btn.Enabled = false;
            XoaKhoaHoc_btn.Enabled = false;
            rows = dskh.ToList().Count();
            pageSize_num.Value = pageSize;
            pageTotal();
        }
        private void frm_QuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            
            var dskh = db.tbl_KhoaHocs;
            DSKhoaHoc_dgv.DataSource = dskh;
            DSKhoaHoc_dgv.FirstDisplayedScrollingColumnIndex = DSKhoaHoc_dgv.ColumnCount -1;
            SuaKhoaHoc_btn.Enabled = false;
            XoaKhoaHoc_btn.Enabled = false;
            rows = dskh.ToList().Count();
            pageSize_num.Value = pageSize;
            pageTotal();
        }

        private void ThemKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút Thêm.
            try
            {
                tbl_KhoaHoc newObj = new tbl_KhoaHoc();
                //string MaKhoaHoc = MaKhoaHoc_txt.Text;
                //lấy dữ liệu từ các textbox
                if (MaKhoaHoc_txt.Text!="" && TenKhoaHoc_txt.Text!="")
                {
                    newObj.MaKhoaHoc = MaKhoaHoc_txt.Text;
                    newObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
                    newObj.ThoiGian = ThoiGian_txt.Text;
                    //int rs;
                    //var x = int.TryParse(GioiHanSinhVien_txt.Text, out rs);

                    //if (int.TryParse(GioiHanSinhVien_txt.Text, out rs))
                    //{
                    //    newObj.GioiHanSinhVien = rs;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Giới hạn sinh viên phải nhập kiểu số!");
                    //}
                    newObj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_num.Value);
                    newObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_num.Value);
                    newObj.KinhPhiDongGop = Convert.ToInt32(KinhPhiDongGop_num.Value);
                    newObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_num.Value);
                    newObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_num.Value);
                    db.tbl_KhoaHocs.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Khóa học thành công");
                    loadData_4_DSKhoaHoc_dgv();
                    ClearData_btn_Click(sender, e);
                   
                }
                else
                {
                    MessageBox.Show("Không được để trống mã khóa học và tên khóa học");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Khóa học không thành công");
            }
 
   
        }

        private void DSKhoaHoc_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSKhoaHoc_dgv.Rows[e.RowIndex];
                MaKhoaHoc_txt.Text = Convert.ToString(row.Cells["MaKhoaHoc"].Value);
                MaKhoaHoc_txt.ReadOnly = true;
                TenKhoaHoc_txt.Text = Convert.ToString(row.Cells["TenKhoaHoc"].Value);
                ThoiGian_txt.Text = Convert.ToString(row.Cells["ThoiGian"].Value);
                GioiHanGiangVien_num.Value = Convert.ToInt32(row.Cells["GioiHanGiangVien"].Value);
                GioiHanSinhVien_num.Value = Convert.ToInt32(row.Cells["GioiHanSinhVien"].Value);

                //đoạn code dưới đây bị lỗi khi cell KinhPhiDongGop null
                //KinhPhiDongGop_num.Text = row.Cells["KinhPhiDongGop"].Value.ToString();

                //Các cách khắc phục
                //Cách 1: Sử dụng if else
                //if (row.Cells["KinhPhiDongGop"].Value == null)
                //{
                //    KinhPhiDongGop_txt.Text = "";
                //}
                //else
                //{
                //    KinhPhiDongGop_txt.Text = row.Cells["KinhPhiDongGop"].Value.ToString();
                //}

                //KinhPhiDongGop_txt.Text = row.Cells["KinhPhiDongGop"].Value ? .ToString();
                //KinhPhiDongGop_txt.Text = row.Cells["KinhPhiDongGop"].Value ? .ToString() ?? "";
                //KinhPhiDongGop_txt.Text = (row.Cells["KinhPhiDongGop"].Value??"").ToString();

                KinhPhiDongGop_num.Value = Convert.ToInt32(row.Cells["KinhPhiDongGop"].Value);
                SoBuoiThucHanh_num.Value = Convert.ToInt32(row.Cells["SoBuoiThucHanh"].Value);
                SoBuoiLyThuyet_num.Value = Convert.ToInt32(row.Cells["SoBuoiLyThuyet"].Value);
                ThemKhoaHoc_btn.Enabled = false;
                SuaKhoaHoc_btn.Enabled = true;
                XoaKhoaHoc_btn.Enabled = true;
            }
        }

        private void SuaKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mkh = MaKhoaHoc_txt.Text;
                //code lưu trữ thông tin khóa học theo dữ liệu đã chỉnh sửa
                tbl_KhoaHoc editObj = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(mkh)).FirstOrDefault();
                editObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
                editObj.ThoiGian = ThoiGian_txt.Text;
                editObj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_num.Value);
                editObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_num.Value);
                editObj.KinhPhiDongGop = Convert.ToInt32(KinhPhiDongGop_num.Value);
                editObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_num.Value);
                editObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_num.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Khóa học không thành công");
            }
          
            db.SubmitChanges();
            loadData_4_DSKhoaHoc_dgv();
        }

        private void ClearData_btn_Click(object sender, EventArgs e)
        {
            MaKhoaHoc_txt.Text = "";
            MaKhoaHoc_txt.ReadOnly = false;
            TenKhoaHoc_txt.Text = "";
            ThoiGian_txt.Text = "";
            GioiHanSinhVien_num.Value = 0;
            GioiHanGiangVien_num.Value = 0;
            KinhPhiDongGop_num.Value = 0;
            SoBuoiLyThuyet_num.Value = 0;
            SoBuoiThucHanh_num.Value = 0;

            ThemKhoaHoc_btn.Enabled = true;
            XoaKhoaHoc_btn.Enabled = false;
            SuaKhoaHoc_btn.Enabled = false;
        }

        private void XoaKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút xóa
            try
            {
                var mkh = MaKhoaHoc_txt.Text;
                tbl_KhoaHoc delObj = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(mkh)).FirstOrDefault();
                db.tbl_KhoaHocs.DeleteOnSubmit(delObj);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Khóa học không thành công");
            }
            loadData_4_DSKhoaHoc_dgv();
            ClearData_btn_Click(sender, e);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pageSize =Convert.ToInt32(pageSize_num.Value);
            pageTotal();
        }

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dskh = db.tbl_KhoaHocs.Skip((currentPageIndex - 1) * pageSize).Take(pageSize).ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
        }

        private void PrePage_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(currentPageIndex == 1)
            {
                MessageBox.Show("Đây là trang đầu tiên");
                return;
            }
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            int targetPageIndex = currentPageIndex - 1;
            Page_cmb.Text = targetPageIndex.ToString();
            var dskh = db.tbl_KhoaHocs.Skip((targetPageIndex - 1) * pageSize).Take(pageSize).ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
        }

        private void NextPage_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPageIndex == pageNumber)
            {
                MessageBox.Show("Đây là trang cuối cùng");
                return;
            }
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            int targetPageIndex = currentPageIndex + 1;
            Page_cmb.Text = targetPageIndex.ToString();
            var dskh = db.tbl_KhoaHocs.Skip((targetPageIndex - 1) * pageSize).Take(pageSize).ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string search_value = Search_txt.Text.ToString();
            int search_type = searchType_cb.SelectedIndex;
            List<tbl_KhoaHoc> dskh= new List<tbl_KhoaHoc>();

            switch (search_type)
            {
                case 0:
                    dskh = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Contains(search_value)).ToList();
                    DSKhoaHoc_dgv.DataSource = dskh;
                    break;
                case 1:
                    dskh = db.tbl_KhoaHocs.Where(o => o.TenKhoaHoc.Contains(search_value)).ToList();
                    DSKhoaHoc_dgv.DataSource = dskh;
                    break;
                default:
                    break;
            }
          
        }
    }
}

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
        DatabaseDataContext db = new DatabaseDataContext();
        public frm_QuanLyKhoaHoc()
        {
            InitializeComponent();
        }


        private void loadData_4_DSKhoaHoc_dgv()
        {
            var dskh = db.tbl_KhoaHocs.ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
        }
        private void frm_QuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            
            var dskh = db.tbl_KhoaHocs;
            DSKhoaHoc_dgv.DataSource = dskh;
            DSKhoaHoc_dgv.FirstDisplayedScrollingColumnIndex = DSKhoaHoc_dgv.ColumnCount -1;
        }

        private void ThemKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút Thêm.
            try
            {
                tbl_KhoaHoc newObj = new tbl_KhoaHoc();
                //string MaKhoaHoc = MaKhoaHoc_txt.Text;
                //lấy dữ liệu từ các textbox
                newObj.MaKhoaHoc = MaKhoaHoc_txt.Text;
                newObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
                newObj.ThoiGian = ThoiGian_txt.Text;



                int rs;
                var x = int.TryParse(GioiHanSinhVien_txt.Text, out rs);

                if (int.TryParse(GioiHanSinhVien_txt.Text, out rs))
                {
                    newObj.GioiHanSinhVien = rs;
                }
                else
                {
                    MessageBox.Show("Giới hạn sinh viên phải nhập kiểu số!");
                }



                newObj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_txt.Text);
                newObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_txt.Text);
                newObj.KinhPhiDongGop = Convert.ToInt32(KinhPhiDongGop_txt.Text);
                newObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_txt.Text);
                newObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_txt.Text);
                db.tbl_KhoaHocs.InsertOnSubmit(newObj);
                db.SubmitChanges();
                MessageBox.Show("Thêm Khóa học thành công");
                loadData_4_DSKhoaHoc_dgv();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Khóa học không thành công");
            }
 
   
        }

        private void DSKhoaHoc_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DSKhoaHoc_dgv.Rows[e.RowIndex];
            MaKhoaHoc_txt.Text = row.Cells["MaKhoaHoc"].Value.ToString();
            MaKhoaHoc_txt.ReadOnly = true;
            TenKhoaHoc_txt.Text = row.Cells["TenKhoaHoc"].Value.ToString(); 
            ThoiGian_txt.Text = row.Cells["ThoiGian"].Value.ToString();
            GioiHanGiangVien_txt.Text = row.Cells["GioiHanGiangVien"].Value.ToString();
            GioiHanSinhVien_txt.Text = row.Cells["GioiHanSinhVien"].Value.ToString();

            //đoạn code dưới đây bị lỗi khi cell KinhPhiDongGop null
            KinhPhiDongGop_txt.Text = row.Cells["KinhPhiDongGop"].Value.ToString();

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

            KinhPhiDongGop_txt.Text = Convert.ToString(row.Cells["KinhPhiDongGop"].Value);

            SoBuoiThucHanh_txt.Text = row.Cells["SoBuoiThucHanh"].Value.ToString();
            SoBuoiLyThuyet_txt.Text = row.Cells["SoBuoiLyThuyet"].Value.ToString();

        }

        private void SuaKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mkh = MaKhoaHoc_txt.Text;
                //code lưu trữ thông tin khóa học theo dữ liệu đã chỉnh sửa
                tbl_KhoaHoc editObj = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(mkh)).FirstOrDefault();
                editObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
            }
            catch (Exception)
            {
                throw;
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
            GioiHanSinhVien_txt.Text = "";
            GioiHanGiangVien_txt.Text = "";
            KinhPhiDongGop_txt.Text = "";
            SoBuoiLyThuyet_txt.Text = "";
            SoBuoiThucHanh_txt.Text = "";
        }
    }
}

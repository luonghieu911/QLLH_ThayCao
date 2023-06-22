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
    public partial class frm_QuanLyGiangVien : Form
    {
        int currentPageIndex = 1;
        int pageSize = 10; //Số lượng dòng hiển thị trên 1 trang
        int pageNumber = 0;
        int rows; //tổng số bản ghi   
        private bool sortAscending = false;
        void pageTotal()
        {
            pageNumber = rows % pageSize != 0 ? rows / pageSize + 1 : rows / pageSize;
            totalPage_lbl.Text = " / " + pageNumber.ToString();
            Page_cmb.Items.Clear();
            for (int i = 1; i <= pageNumber; i++)
            {
                Page_cmb.Items.Add(i + "");
            }
            Page_cmb.SelectedIndex = 0;
        }
        DatabaseDataContext db = new DatabaseDataContext();
        public frm_QuanLyGiangVien()
        {
            InitializeComponent();
        }
        private void loadData_4_DSGiangVien_dgv()
        {
            var dskh = db.tbl_GiangViens.ToList();
            SuaGiangVien_btn.Visible = false;
            XoaGiangVien_btn.Visible = false;
            rows = dskh.ToList().Count();
            pageSize_num.Value = pageSize;
            pageTotal();
        }

        private void frm_QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            loadData_4_DSGiangVien_dgv();
            searchType_cb.SelectedIndex = 0;
        }

        private void ThemGiangVien_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút Thêm.
            try
            {
                tbl_GiangVien newObj = new tbl_GiangVien();
                //string MaKhoaHoc = MaKhoaHoc_txt.Text;
                //lấy dữ liệu từ các textbox
                if (MaGiangVien_txt.Text != "" && TenGiangVien_txt.Text != "")
                {
                    newObj.MaGV = MaGiangVien_txt.Text;
                    newObj.HoTen = TenGiangVien_txt.Text;
                    newObj.SDT = SDT_txt.Text;
                    newObj.Email = Email_txt.Text;
                    newObj.CCCD = CCCD_txt.Text;
                    newObj.DiaChi = DiaChi_txt.Text;                 
                    db.tbl_GiangViens.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Giảng viên thành công");
                    loadData_4_DSGiangVien_dgv();
                    ClearData_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không được để trống mã giảng viên và tên giảng viên");
                }
            }
            catch (Exception ex)
            {
                if (db.GetChangeSet().Inserts.Count > 0)
                {
                    foreach (tbl_GiangVien item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_GiangViens.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm giảng viên không thành công");
            }
        }

        private void ClearData_btn_Click(object sender, EventArgs e)
        {
            MaGiangVien_txt.Text = "";
            MaGiangVien_txt.ReadOnly = false;
            TenGiangVien_txt.Text = "";
            SDT_txt.Text = "";
            Email_txt.Text = "";
            CCCD_txt.Text = "";
            DiaChi_txt.Text = "";


            ThemGiangVien_btn.Visible = true;
            XoaGiangVien_btn.Visible = false;
            SuaGiangVien_btn.Visible = false;
        }

        private void SuaGiangVien_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mgv = MaGiangVien_txt.Text;
                //code lưu trữ thông tin khóa học theo dữ liệu đã chỉnh sửa
                tbl_GiangVien editObj = db.tbl_GiangViens.Where(o => o.MaGV.Equals(mgv)).FirstOrDefault();
                editObj.HoTen = TenGiangVien_txt.Text;
                editObj.SDT = SDT_txt.Text;
                editObj.Email = Email_txt.Text;
                editObj.CCCD = CCCD_txt.Text;
                editObj.DiaChi = DiaChi_txt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Khóa học không thành công");
            }

            db.SubmitChanges();
            loadData_4_DSGiangVien_dgv();
        }

        private void XoaGiangVien_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút xóa
            try
            {
                var mgv = MaGiangVien_txt.Text;
                tbl_GiangVien delObj = db.tbl_GiangViens.Where(o => o.MaGV.Equals(mgv)).FirstOrDefault();
                db.tbl_GiangViens.DeleteOnSubmit(delObj);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Giảng viên không thành công");
            }
            MessageBox.Show("Xóa Giảng viên thành công");
            loadData_4_DSGiangVien_dgv();
            ClearData_btn_Click(sender, e);
        }

        private void DSGiangVien_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSGiangVien_dgv.Rows[e.RowIndex];
                MaGiangVien_txt.Text = Convert.ToString(row.Cells["MaGV"].Value);
                MaGiangVien_txt.ReadOnly = true;
                TenGiangVien_txt.Text = Convert.ToString(row.Cells["HoTen"].Value);
                SDT_txt.Text = Convert.ToString(row.Cells["SDT"].Value);
                Email_txt.Text = Convert.ToString(row.Cells["Email"].Value);
                CCCD_txt.Text = Convert.ToString(row.Cells["CCCD"].Value);
                DiaChi_txt.Text = Convert.ToString(row.Cells["DiaChi"].Value);

                ThemGiangVien_btn.Visible = false;
                SuaGiangVien_btn.Visible = true;
                XoaGiangVien_btn.Visible = true;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt32(pageSize_num.Value);
            pageTotal();
        }

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dskh = db.tbl_GiangViens.Skip((currentPageIndex - 1) * pageSize).Take(pageSize).ToList();
            //DSGiangVien_dgv.DataSource = dskh;
            List<GiangVien_ett> list_giangVien_ett = new List<GiangVien_ett>();
            for (int i = 0; i < dskh.Count; i++)
            {
                GiangVien_ett giangVien_ett = new GiangVien_ett(dskh[i]);
                //giangVien_ett.STT = Convert.ToString(i + 1);
                giangVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSize + i + 1);
                list_giangVien_ett.Add(giangVien_ett);
            }
            DSGiangVien_dgv.DataSource = list_giangVien_ett;
        }

        private void PrePage_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPageIndex == 1)
            {
                MessageBox.Show("Đây là trang đầu tiên");
                return;
            }
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            int targetPageIndex = currentPageIndex - 1;
            Page_cmb.Text = targetPageIndex.ToString();
           
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
        }
    }
}

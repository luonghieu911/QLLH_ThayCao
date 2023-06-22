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
    public partial class frm_QuanLySinhVien : Form
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

        public frm_QuanLySinhVien()
        {
            InitializeComponent();
        }
        private void frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            loadData_4_DSSinhVien_dgv();
            searchType_cb.SelectedIndex = 0;
        }
        private void loadData_4_DSSinhVien_dgv()
        {
            var dssv = db.tbl_SinhViens.ToList();
            SuaSinhVien_btn.Visible = false;
            XoaSinhVien_btn.Visible = false;
            rows = dssv.ToList().Count();
            pageSize_num.Value = pageSize;
            pageTotal();
        }

        private void ClearData_btn_Click(object sender, EventArgs e)
        {
            MSSV_txt.Text = "";
            MSSV_txt.ReadOnly = false; 
            HoVaTen_txt.Text = "";
            LopQL_txt.Text = "";
            NgaySinh_dtp.Value = DateTime.Now;
            GioiTinh_cb.SelectedIndex = 0;
            SDT_txt.Text = "";
            Email_txt.Text = string.Empty;
          

            ThemSinhVien_btn.Visible = true;
            XoaSinhVien_btn.Visible = false;
            SuaSinhVien_btn.Visible = false;
        }  

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dssv = db.tbl_SinhViens.Skip((currentPageIndex - 1) * pageSize).Take(pageSize).ToList();
            //DSKhoaHoc_dgv.DataSource = dskh;
            List<SinhVien_ett> list_sinhVien_ett = new List<SinhVien_ett>();
            for (int i = 0; i < dssv.Count; i++)
            {
                SinhVien_ett sinhVien_ett = new SinhVien_ett(dssv[i]);
                //sinhVien_ett.STT = Convert.ToString(i + 1);
                sinhVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSize + i + 1);
                list_sinhVien_ett.Add(sinhVien_ett);
            }
            DSSinhVien_dgv.DataSource = list_sinhVien_ett;
        }

        private void pageSize_num_ValueChanged(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt32(pageSize_num.Value);
            pageTotal();
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
            //var dskh = db.tbl_KhoaHocs.Skip((targetPageIndex - 1) * pageSize).Take(pageSize).ToList();
            //DSKhoaHoc_dgv.DataSource = dskh;
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
            //var dskh = db.tbl_KhoaHocs.Skip((targetPageIndex - 1) * pageSize).Take(pageSize).ToList();
            //DSKhoaHoc_dgv.DataSource = dskh;
        }

        private void DSSinhVien_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSSinhVien_dgv.Rows[e.RowIndex];
                MSSV_txt.Text = Convert.ToString(row.Cells["MSSV"].Value);
                MSSV_txt.ReadOnly = true;
                HoVaTen_txt.Text = Convert.ToString(row.Cells["HoTen"].Value);
                LopQL_txt.Text = Convert.ToString(row.Cells["LopQL"].Value);
                NgaySinh_dtp.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                
                //dùng switch case
                if (Convert.ToString(row.Cells["GioiTinh"].Value) == "Nữ")
                {
                    GioiTinh_cb.SelectedIndex = 0;
                }
                else if (Convert.ToString(row.Cells["GioiTinh"].Value) == "Nam")
                {
                    GioiTinh_cb.SelectedIndex = 1;
                }
                SDT_txt.Text = Convert.ToString(row.Cells["SDT"].Value);
                Email_txt.Text = Convert.ToString(row.Cells["Email"].Value);
                ThemSinhVien_btn.Visible = false;
                SuaSinhVien_btn.Visible = true;
                XoaSinhVien_btn.Visible = true;
            }
        }
        private void ThemSinhVien_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút Thêm.
            try
            {
                tbl_SinhVien newObj = new tbl_SinhVien();
                //string MaKhoaHoc = MaKhoaHoc_txt.Text;
                //lấy dữ liệu từ các textbox
                if (MSSV_txt.Text != "" && HoVaTen_txt.Text != "")
                {
                    newObj.MSSV = MSSV_txt.Text;
                    newObj.HoTen = HoVaTen_txt.Text;
                    newObj.LopQL = LopQL_txt.Text;
                    newObj.NgaySinh = NgaySinh_dtp.Value;
                    if (GioiTinh_cb.SelectedIndex.ToString() == "0")
                    {
                        newObj.GioiTinh = false;
                    }
                    else if (GioiTinh_cb.SelectedIndex.ToString() == "1")
                    {
                        newObj.GioiTinh = true;
                    }
                    newObj.SDT = SDT_txt.Text;
                    newObj.Email = Email_txt.Text;
                    db.tbl_SinhViens.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Sinh viên thành công");
                    loadData_4_DSSinhVien_dgv();
                    //ClearData_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không được để trống MSSV và Họ tên sinh viên");
                }
            }
            catch (Exception ex)
            {
                if (db.GetChangeSet().Inserts.Count > 0)
                {
                    foreach (tbl_SinhVien item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_SinhViens.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm Sinh viên không thành công");
            }
        }

        private void XoaSinhVien_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút xóa
            try
            {
                var mssv = MSSV_txt.Text;
                tbl_SinhVien delObj = db.tbl_SinhViens.Where(o => o.MSSV.Equals(mssv)).FirstOrDefault();
                db.tbl_SinhViens.DeleteOnSubmit(delObj);
                db.SubmitChanges();              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Sinh viên không thành công");
            }
            MessageBox.Show("Xóa Sinh viên thành công");
            loadData_4_DSSinhVien_dgv();
            ClearData_btn_Click(sender, e);
        }

        private void SuaSinhVien_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mssv = MSSV_txt.Text;
                //code lưu trữ thông tin sinh viên theo dữ liệu đã chỉnh sửa
                tbl_SinhVien editObj = db.tbl_SinhViens.Where(o => o.MSSV.Equals(mssv)).FirstOrDefault();
                editObj.HoTen =HoVaTen_txt.Text; 
                editObj.LopQL = LopQL_txt.Text;
                if (GioiTinh_cb.SelectedIndex.ToString() == "0")
                {
                    editObj.GioiTinh = false;
                }
                else if (GioiTinh_cb.SelectedIndex.ToString() == "1")
                {
                    editObj.GioiTinh = true;
                }
                editObj.NgaySinh = NgaySinh_dtp.Value; ;
                editObj.SDT = SDT_txt.Text;
                editObj.Email = Email_txt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Khóa học không thành công");
            }
            MessageBox.Show("Sửa sinh viên thành công");
            db.SubmitChanges();
            loadData_4_DSSinhVien_dgv();
            SuaSinhVien_btn.Visible = true;
            XoaSinhVien_btn.Visible = true;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string search_value = Search_txt.Text.ToString();
            EnumSearchType search_type = (EnumSearchType)searchType_cb.SelectedIndex;
            List<tbl_SinhVien> dssv = new List<tbl_SinhVien>();
            List<SinhVien_ett> list_sinhVien_ett = new List<SinhVien_ett>();
            switch (search_type)
            {
                case EnumSearchType.Tatca:
                    dssv = db.tbl_SinhViens.ToList();
                    for (int i = 0; i < dssv.Count; i++)
                    {
                        SinhVien_ett sinhVien_ett = new SinhVien_ett(dssv[i]);
                        //sinhVien_ett.STT = Convert.ToString(i + 1);
                        sinhVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSize + i + 1);
                        list_sinhVien_ett.Add(sinhVien_ett);
                    }
                    DSSinhVien_dgv.DataSource = list_sinhVien_ett;
                    break;
                case EnumSearchType.Ma:
                    dssv = db.tbl_SinhViens.Where(o => o.MSSV.Contains(search_value)).ToList();
                    for (int i = 0; i < dssv.Count; i++)
                    {
                        SinhVien_ett sinhVien_ett = new SinhVien_ett(dssv[i]);
                        //sinhVien_ett.STT = Convert.ToString(i + 1);
                        sinhVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSize + i + 1);
                        list_sinhVien_ett.Add(sinhVien_ett);
                    }
                    DSSinhVien_dgv.DataSource = list_sinhVien_ett;

                    break;
                case EnumSearchType.Ten:
                    dssv = db.tbl_SinhViens.Where(o => o.HoTen.Contains(search_value)).ToList();
                    for (int i = 0; i < dssv.Count; i++)
                    {
                        SinhVien_ett sinhVien_ett = new SinhVien_ett(dssv[i]);
                        //sinhVien_ett.STT = Convert.ToString(i + 1);
                        sinhVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSize + i + 1);
                        list_sinhVien_ett.Add(sinhVien_ett);
                    }
                    DSSinhVien_dgv.DataSource = list_sinhVien_ett;
                    break;
                default:
                    break;
            }
        }
    }
}

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
    public partial class frm_QuanLyLopHoc : Form
    {
        int currentPageIndex = 1;
        int pageSize = 10; //Số lượng dòng hiển thị trên 1 trang
        int pageNumber = 0;
        int rows; //tổng số bản ghi   
        DatabaseDataContext db = new DatabaseDataContext();
        private bool sortAscending = false;

        public frm_QuanLyLopHoc()
        {
            InitializeComponent();
        }
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
        private void loadData_4_DSLopHoc_dgv()
        {
            var dslh = db.tbl_LopHocs.ToList();
            SuaLH_btn.Visible = false;
            XoaLH_btn.Visible = false;
            rows = dslh.ToList().Count();
            pageSize_num.Value = pageSize;
            pageTotal();
        }
        private void frm_QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            loadData_4_DSLopHoc_dgv();
        }

        private void ThemLH_btn_Click(object sender, EventArgs e)
        {
            frm_ThemLopHoc f = new frm_ThemLopHoc();
            //lấy ra form Main
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Name == "frm_Main")
                {
                    //lấy ra size của Main_Panel trong frm_Main, gán bằng size của frm_ThemMoiLH
                   var mainPanel = form.Controls[0];
                    f.TopLevel = false;
                    f.Width = mainPanel.Width;
                    f.Height = mainPanel.Height;
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(f);
                    f.Show();
                    break;
                }
            }          
        }

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dslh = db.tbl_LopHocs.Skip((currentPageIndex - 1) * pageSize).Take(pageSize).ToList();
            List<LopHoc_ett> list_lopHoc_ett = new List<LopHoc_ett>();
            for (int i = 0; i < dslh.Count; i++)
            {
                LopHoc_ett lopHoc_ett = new LopHoc_ett(dslh[i]);
                lopHoc_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSize + i + 1);
                list_lopHoc_ett.Add(lopHoc_ett);
            }
            DSLopHoc_dgv.DataSource = list_lopHoc_ett;
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
        private void DSLopHoc_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSLopHoc_dgv.Rows[e.RowIndex];
                MaLH_txt.Text = Convert.ToString(row.Cells["MaLH"].Value);
                TenLH_txt.Text = Convert.ToString(row.Cells["TenLH"].Value);
                ThoiGianBatDau_txt.Text = Convert.ToString(row.Cells["ThoiGianBatDau"].Value);
                ThoiGianKetThuc_txt.Text = Convert.ToString(row.Cells["ThoiGianKetThuc"].Value);
                KhoaHoc_txt.Text = Convert.ToString(row.Cells["MaKhoaHoc"].Value);
                MaLH_txt.ReadOnly = true;
                TenLH_txt.ReadOnly = true;
                ThoiGianBatDau_txt.ReadOnly = true;
                ThoiGianKetThuc_txt.ReadOnly = true;
                KhoaHoc_txt.ReadOnly = true;
                ThemLH_btn.Visible = false;
                SuaLH_btn.Visible = true;
                XoaLH_btn.Visible = true;
            }
        }
    }
}

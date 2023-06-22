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
    public partial class frm_ThemLopHoc : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public frm_ThemLopHoc()
        {
            InitializeComponent();
        }

        private void HoVaTen_lbl_Click(object sender, EventArgs e)
        {

        }

        private void GioiTinh_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ThemLH_btn_Click(object sender, EventArgs e)
        {
            //xử lý sự kiện click nút Thêm.
            try
            {
                tbl_LopHoc newObj = new tbl_LopHoc();
                if (MaLH_txt.Text != "" && TenLH_txt.Text != "")
                {
                    newObj.MaLH = MaLH_txt.Text;
                    newObj.TenLH = TenLH_txt.Text;
                    newObj.ThoiGianBatDau = ThoiGianBatDau_txt.Text;
                    newObj.ThoiGianKetThuc = ThoiGianKetThuc_txt.Text;
                    newObj.MaKhoaHoc = KhoaHoc_txt.Text;
                  
                    db.tbl_LopHocs.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Không được để trống mã lớp học và tên tên học");
                }
            }
            catch (Exception ex)
            {
                if (db.GetChangeSet().Inserts.Count > 0)
                {
                    foreach (tbl_KhoaHoc item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_KhoaHocs.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm Khóa học không thành công");
            }
        }
    }
}

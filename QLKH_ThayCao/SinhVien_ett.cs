using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_ThayCao
{
    class SinhVien_ett : tbl_SinhVien
    {
        public string STT { get; set; }

        public SinhVien_ett()
        {
            //
        }

        private void BindObject(tbl_SinhVien obj)
        {
            this.MSSV = obj.MSSV;
            this.HoTen = obj.HoTen;
            this.GioiTinh= obj.GioiTinh;
            this.NgaySinh = obj.NgaySinh;
            this.SDT = obj.SDT;
            this.Email = obj.Email;
           
        }
        public SinhVien_ett(tbl_SinhVien obj)
        {
            BindObject(obj);
        }

    }
}

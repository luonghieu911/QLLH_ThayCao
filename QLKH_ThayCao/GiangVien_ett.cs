using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_ThayCao
{
    class GiangVien_ett:tbl_GiangVien
    {
        public string STT { get; set; }

        public GiangVien_ett()
        {
            //
        }

        private void BindObject(tbl_GiangVien obj)
        {
            this.MaGV = obj.MaGV;
            this.HoTen = obj.HoTen;
            this.SDT = obj.SDT;
            this.Email = obj.Email;
            this.CCCD = obj.CCCD;
            this.DiaChi = obj.DiaChi;        
        }

        public GiangVien_ett(tbl_GiangVien obj)
        {
            BindObject(obj);
        }
    }
}

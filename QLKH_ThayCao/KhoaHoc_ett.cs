using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_ThayCao
{
    class KhoaHoc_ett : tbl_KhoaHoc
    {
        public string STT { get; set; }

        public KhoaHoc_ett()
        {
            //
        }

        private void BindObject(tbl_KhoaHoc obj)
        {
            this.MaKhoaHoc = obj.MaKhoaHoc;
            this.TenKhoaHoc = obj.TenKhoaHoc;
            this.ThoiGian = obj.ThoiGian;
            this.GioiHanSinhVien = obj.GioiHanSinhVien;
            this.GioiHanGiangVien = obj.GioiHanGiangVien;
            this.SoBuoiLyThuyet = obj.SoBuoiLyThuyet;
            this.SoBuoiThucHanh = obj.SoBuoiThucHanh;
            this.KinhPhiDongGop = obj.KinhPhiDongGop;
        }

        public KhoaHoc_ett(tbl_KhoaHoc obj)
        {
            BindObject(obj);
        }

    }
}

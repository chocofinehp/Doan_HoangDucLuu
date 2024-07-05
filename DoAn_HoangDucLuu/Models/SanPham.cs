using System.ComponentModel.DataAnnotations;

namespace DoAn_HoangDucLuu.Models
{
    public partial class SanPham
    {
        [Key]
        public int IDSP { get; set; }
        public string LoaiSP { get; set; }
        public string TenSP { get; set; }
        public long GiaSP { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public string? MoTa { get; set; }
        public string? AnhSP { get; set; }


    }
}

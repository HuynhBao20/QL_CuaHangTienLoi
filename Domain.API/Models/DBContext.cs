using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.API.Models
{
	public class DBContext
	{
	}
    public class ThongTinCuaHang
    {
        public string MACH { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string HoTen { get; set; }
    }
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayVL { get; set; }
        public string TenDN { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }

        // Navigation properties
        public ICollection<PhieuNhap> PhieuNhaps { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
    public class LoaiSP
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        // Navigation properties
        public ICollection<SanPham> SanPhams { get; set; }
    }
    public class PhieuNhap
    {
        public string MaPN { get; set; }
        public string MaSP { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SLTon { get; set; }
        public string MaNV { get; set; }
        public float GiaNhap { get; set; }
        public string DVT { get; set; }

        // Navigation properties
        public NhanVien NhanVien { get; set; }
        public SanPham SanPham { get; set; }
    }
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int MaLoai { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime NgayHH { get; set; }
        public float DonGia { get; set; }

        // Navigation properties
        public LoaiSP LoaiSP { get; set; }
        public ICollection<CT_HoaDon> CTHoaDons { get; set; }
        public ICollection<KhuyenMai> KhuyenMais { get; set; }
    }
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string LoaiKH { get; set; }

        // Navigation properties
        public ICollection<HoaDon> HoaDons { get; set; }
        public ICollection<TichDiem> TichDiems { get; set; }
    }
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public string TrangThai { get; set; }
        public float TienKD { get; set; }

        // Navigation properties
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public ICollection<CT_HoaDon> CTHoaDons { get; set; }
    }
    public class CT_HoaDon
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }

        // Navigation properties
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
    }
    public class TichDiem
    {
        public string MaKH { get; set; }
        public string MaHD { get; set; }
        public DateTime NgayTich { get; set; }

        // Navigation properties
        public KhachHang KhachHang { get; set; }
        public HoaDon HoaDon { get; set; }
    }
    public class KhuyenMai
    {
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public string MaSP { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayHH { get; set; }
        public int SLMua { get; set; }
        public string SPTang { get; set; }

        // Navigation properties
        public SanPham SanPhamMua { get; set; }
        public SanPham SanPhamTang { get; set; }
    }

}

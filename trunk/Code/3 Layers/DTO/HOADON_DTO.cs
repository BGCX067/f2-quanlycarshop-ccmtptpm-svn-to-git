using System;

namespace Layers.DTO
{
	public class HOADON_DTO
	{
		#region Fields

		private int m_Ma;
		private int m_MaKhachHang;
		private int m_MaNhanVien;
		private DateTime m_NgayLap;
		private bool m_KieuThanhToan;
		private decimal m_TongTien;
		private decimal m_TienTraMoiDot;
		private int m_SoLanTra;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HOADON_DTO class.
		/// </summary>
		public HOADON_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the HOADON_DTO class.
		/// </summary>
		public HOADON_DTO(int MaKhachHang, int MaNhanVien, DateTime NgayLap, bool KieuThanhToan, decimal TongTien, decimal TienTraMoiDot, int SoLanTra)
		{
			m_MaKhachHang = MaKhachHang;
			m_MaNhanVien = MaNhanVien;
			m_NgayLap = NgayLap;
			m_KieuThanhToan = KieuThanhToan;
			m_TongTien = TongTien;
			m_TienTraMoiDot = TienTraMoiDot;
			m_SoLanTra = SoLanTra;
		}

		/// <summary>
		/// Initializes a new instance of the HOADON_DTO class.
		/// </summary>
		public HOADON_DTO(int Ma, int MaKhachHang, int MaNhanVien, DateTime NgayLap, bool KieuThanhToan, decimal TongTien, decimal TienTraMoiDot, int SoLanTra)
		{
			m_Ma = Ma;
			m_MaKhachHang = MaKhachHang;
			m_MaNhanVien = MaNhanVien;
			m_NgayLap = NgayLap;
			m_KieuThanhToan = KieuThanhToan;
			m_TongTien = TongTien;
			m_TienTraMoiDot = TienTraMoiDot;
			m_SoLanTra = SoLanTra;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Ma value.
		/// </summary>
		public virtual int Ma
		{
			get { return m_Ma; }
			set { m_Ma = value; }
		}

		/// <summary>
		/// Gets or sets the MaKhachHang value.
		/// </summary>
		public virtual int MaKhachHang
		{
			get { return m_MaKhachHang; }
			set { m_MaKhachHang = value; }
		}

		/// <summary>
		/// Gets or sets the MaNhanVien value.
		/// </summary>
		public virtual int MaNhanVien
		{
			get { return m_MaNhanVien; }
			set { m_MaNhanVien = value; }
		}

		/// <summary>
		/// Gets or sets the NgayLap value.
		/// </summary>
		public virtual DateTime NgayLap
		{
			get { return m_NgayLap; }
			set { m_NgayLap = value; }
		}

		/// <summary>
		/// Gets or sets the KieuThanhToan value.
		/// </summary>
		public virtual bool KieuThanhToan
		{
			get { return m_KieuThanhToan; }
			set { m_KieuThanhToan = value; }
		}

		/// <summary>
		/// Gets or sets the TongTien value.
		/// </summary>
		public virtual decimal TongTien
		{
			get { return m_TongTien; }
			set { m_TongTien = value; }
		}

		/// <summary>
		/// Gets or sets the TienTraMoiDot value.
		/// </summary>
		public virtual decimal TienTraMoiDot
		{
			get { return m_TienTraMoiDot; }
			set { m_TienTraMoiDot = value; }
		}

		/// <summary>
		/// Gets or sets the SoLanTra value.
		/// </summary>
		public virtual int SoLanTra
		{
			get { return m_SoLanTra; }
			set { m_SoLanTra = value; }
		}

		#endregion
	}
}

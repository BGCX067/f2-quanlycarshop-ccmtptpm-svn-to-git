using System;

namespace Layers.DTO
{
	public class PHIEUNHAPXE_DTO
	{
		#region Fields

		private int m_Ma;
		private int m_MaDonDatHang;
		private DateTime m_NgayNhap;
		private int m_TongSoLuong;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PHIEUNHAPXE_DTO class.
		/// </summary>
		public PHIEUNHAPXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the PHIEUNHAPXE_DTO class.
		/// </summary>
		public PHIEUNHAPXE_DTO(int Ma, int MaDonDatHang, DateTime NgayNhap, int TongSoLuong)
		{
			m_Ma = Ma;
			m_MaDonDatHang = MaDonDatHang;
			m_NgayNhap = NgayNhap;
			m_TongSoLuong = TongSoLuong;
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
		/// Gets or sets the MaDonDatHang value.
		/// </summary>
		public virtual int MaDonDatHang
		{
			get { return m_MaDonDatHang; }
			set { m_MaDonDatHang = value; }
		}

		/// <summary>
		/// Gets or sets the NgayNhap value.
		/// </summary>
		public virtual DateTime NgayNhap
		{
			get { return m_NgayNhap; }
			set { m_NgayNhap = value; }
		}

		/// <summary>
		/// Gets or sets the TongSoLuong value.
		/// </summary>
		public virtual int TongSoLuong
		{
			get { return m_TongSoLuong; }
			set { m_TongSoLuong = value; }
		}

		#endregion
	}
}

using System;

namespace Layers.DTO
{
	public class PHIEUDATXE_DTO
	{
		#region Fields

		private int m_Ma;
		private int m_MaKhachHang;
		private int m_MaNhanVien;
		private DateTime m_NgayDat;
		private DateTime m_NgayHenLay;
		private decimal m_TongTien;
		private decimal m_TienTraTruoc;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PHIEUDATXE_DTO class.
		/// </summary>
		public PHIEUDATXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the PHIEUDATXE_DTO class.
		/// </summary>
		public PHIEUDATXE_DTO(int Ma, int MaKhachHang, int MaNhanVien, DateTime NgayDat, DateTime NgayHenLay, decimal TongTien, decimal TienTraTruoc)
		{
			m_Ma = Ma;
			m_MaKhachHang = MaKhachHang;
			m_MaNhanVien = MaNhanVien;
			m_NgayDat = NgayDat;
			m_NgayHenLay = NgayHenLay;
			m_TongTien = TongTien;
			m_TienTraTruoc = TienTraTruoc;
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
		/// Gets or sets the NgayDat value.
		/// </summary>
		public virtual DateTime NgayDat
		{
			get { return m_NgayDat; }
			set { m_NgayDat = value; }
		}

		/// <summary>
		/// Gets or sets the NgayHenLay value.
		/// </summary>
		public virtual DateTime NgayHenLay
		{
			get { return m_NgayHenLay; }
			set { m_NgayHenLay = value; }
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
		/// Gets or sets the TienTraTruoc value.
		/// </summary>
		public virtual decimal TienTraTruoc
		{
			get { return m_TienTraTruoc; }
			set { m_TienTraTruoc = value; }
		}

		#endregion
	}
}

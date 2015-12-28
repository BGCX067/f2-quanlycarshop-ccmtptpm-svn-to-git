using System;

namespace Layers.DTO
{
	public class BIENNHAN_DTO
	{
		#region Fields

		private int m_Ma;
		private int m_MaHoaDon;
		private DateTime m_NgayThanhToan;
		private int m_MaNhanVien;
		private decimal m_SoTien;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BIENNHAN_DTO class.
		/// </summary>
		public BIENNHAN_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the BIENNHAN_DTO class.
		/// </summary>
		public BIENNHAN_DTO(int Ma, int MaHoaDon, DateTime NgayThanhToan, int MaNhanVien, decimal SoTien)
		{
			m_Ma = Ma;
			m_MaHoaDon = MaHoaDon;
			m_NgayThanhToan = NgayThanhToan;
			m_MaNhanVien = MaNhanVien;
			m_SoTien = SoTien;
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
		/// Gets or sets the MaHoaDon value.
		/// </summary>
		public virtual int MaHoaDon
		{
			get { return m_MaHoaDon; }
			set { m_MaHoaDon = value; }
		}

		/// <summary>
		/// Gets or sets the NgayThanhToan value.
		/// </summary>
		public virtual DateTime NgayThanhToan
		{
			get { return m_NgayThanhToan; }
			set { m_NgayThanhToan = value; }
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
		/// Gets or sets the SoTien value.
		/// </summary>
		public virtual decimal SoTien
		{
			get { return m_SoTien; }
			set { m_SoTien = value; }
		}

		#endregion
	}
}

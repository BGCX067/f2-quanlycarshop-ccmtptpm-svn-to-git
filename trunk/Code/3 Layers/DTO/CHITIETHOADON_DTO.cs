using System;

namespace Layers.DTO
{
	public class CHITIETHOADON_DTO
	{
		#region Fields

		private int m_Ma;
		private int m_MaHoaDon;
		private int m_MaXe;
		private string m_MaMau;
		private int m_SoLuong;
		private decimal m_ThanhTien;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CHITIETHOADON_DTO class.
		/// </summary>
		public CHITIETHOADON_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CHITIETHOADON_DTO class.
		/// </summary>
		public CHITIETHOADON_DTO(int MaHoaDon, int MaXe, string MaMau, int SoLuong, decimal ThanhTien)
		{
			m_MaHoaDon = MaHoaDon;
			m_MaXe = MaXe;
			m_MaMau = MaMau;
			m_SoLuong = SoLuong;
			m_ThanhTien = ThanhTien;
		}

		/// <summary>
		/// Initializes a new instance of the CHITIETHOADON_DTO class.
		/// </summary>
		public CHITIETHOADON_DTO(int Ma, int MaHoaDon, int MaXe, string MaMau, int SoLuong, decimal ThanhTien)
		{
			m_Ma = Ma;
			m_MaHoaDon = MaHoaDon;
			m_MaXe = MaXe;
			m_MaMau = MaMau;
			m_SoLuong = SoLuong;
			m_ThanhTien = ThanhTien;
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
		/// Gets or sets the MaXe value.
		/// </summary>
		public virtual int MaXe
		{
			get { return m_MaXe; }
			set { m_MaXe = value; }
		}

		/// <summary>
		/// Gets or sets the MaMau value.
		/// </summary>
		public virtual string MaMau
		{
			get { return m_MaMau; }
			set { m_MaMau = value; }
		}

		/// <summary>
		/// Gets or sets the SoLuong value.
		/// </summary>
		public virtual int SoLuong
		{
			get { return m_SoLuong; }
			set { m_SoLuong = value; }
		}

		/// <summary>
		/// Gets or sets the ThanhTien value.
		/// </summary>
		public virtual decimal ThanhTien
		{
			get { return m_ThanhTien; }
			set { m_ThanhTien = value; }
		}

		#endregion
	}
}

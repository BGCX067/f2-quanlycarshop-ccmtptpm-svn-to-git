using System;

namespace Layers.DTO
{
	public class CTDONDATHANG_DTO
	{
		#region Fields

		private int m_MaDonDatHang;
		private int m_MaXe;
		private string m_MaMau;
		private int m_SoLuong;
		private decimal m_TongTien;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CTDONDATHANG_DTO class.
		/// </summary>
		public CTDONDATHANG_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CTDONDATHANG_DTO class.
		/// </summary>
		public CTDONDATHANG_DTO(int MaDonDatHang, int MaXe, string MaMau, int SoLuong, decimal TongTien)
		{
			m_MaDonDatHang = MaDonDatHang;
			m_MaXe = MaXe;
			m_MaMau = MaMau;
			m_SoLuong = SoLuong;
			m_TongTien = TongTien;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MaDonDatHang value.
		/// </summary>
		public virtual int MaDonDatHang
		{
			get { return m_MaDonDatHang; }
			set { m_MaDonDatHang = value; }
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
		/// Gets or sets the TongTien value.
		/// </summary>
		public virtual decimal TongTien
		{
			get { return m_TongTien; }
			set { m_TongTien = value; }
		}

		#endregion
	}
}

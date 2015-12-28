using System;

namespace Layers.DTO
{
	public class DONDATHANG_DTO
	{
		#region Fields

		private int m_Ma;
		private DateTime m_NgayDat;
		private decimal m_TongTien;
		private int m_TongSoLuong;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DONDATHANG_DTO class.
		/// </summary>
		public DONDATHANG_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the DONDATHANG_DTO class.
		/// </summary>
		public DONDATHANG_DTO(int Ma, DateTime NgayDat, decimal TongTien, int TongSoLuong)
		{
			m_Ma = Ma;
			m_NgayDat = NgayDat;
			m_TongTien = TongTien;
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
		/// Gets or sets the NgayDat value.
		/// </summary>
		public virtual DateTime NgayDat
		{
			get { return m_NgayDat; }
			set { m_NgayDat = value; }
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

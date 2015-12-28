using System;

namespace Layers.DTO
{
	public class PHIEUXUATXE_DTO
	{
		#region Fields

		private int m_Ma;
		private DateTime m_NgayXuat;
		private int m_MaNhanVien;
		private int m_TongSoLuong;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PHIEUXUATXE_DTO class.
		/// </summary>
		public PHIEUXUATXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the PHIEUXUATXE_DTO class.
		/// </summary>
		public PHIEUXUATXE_DTO(int Ma, DateTime NgayXuat, int MaNhanVien, int TongSoLuong)
		{
			m_Ma = Ma;
			m_NgayXuat = NgayXuat;
			m_MaNhanVien = MaNhanVien;
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
		/// Gets or sets the NgayXuat value.
		/// </summary>
		public virtual DateTime NgayXuat
		{
			get { return m_NgayXuat; }
			set { m_NgayXuat = value; }
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

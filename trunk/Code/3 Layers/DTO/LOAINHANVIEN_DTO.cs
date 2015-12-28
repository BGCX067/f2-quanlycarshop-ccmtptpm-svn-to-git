using System;

namespace Layers.DTO
{
	public class LOAINHANVIEN_DTO
	{
		#region Fields

		private int m_Ma;
		private string m_TenLoaiNhanVien;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LOAINHANVIEN_DTO class.
		/// </summary>
		public LOAINHANVIEN_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the LOAINHANVIEN_DTO class.
		/// </summary>
		public LOAINHANVIEN_DTO(int Ma, string TenLoaiNhanVien)
		{
			m_Ma = Ma;
			m_TenLoaiNhanVien = TenLoaiNhanVien;
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
		/// Gets or sets the TenLoaiNhanVien value.
		/// </summary>
		public virtual string TenLoaiNhanVien
		{
			get { return m_TenLoaiNhanVien; }
			set { m_TenLoaiNhanVien = value; }
		}

		#endregion
	}
}

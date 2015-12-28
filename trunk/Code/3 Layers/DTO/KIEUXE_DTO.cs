using System;

namespace Layers.DTO
{
	public class KIEUXE_DTO
	{
		#region Fields

		private int m_Ma;
		private int m_MaLoaiXe;
		private string m_TenKieuXe;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KIEUXE_DTO class.
		/// </summary>
		public KIEUXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the KIEUXE_DTO class.
		/// </summary>
		public KIEUXE_DTO(int Ma, int MaLoaiXe, string TenKieuXe)
		{
			m_Ma = Ma;
			m_MaLoaiXe = MaLoaiXe;
			m_TenKieuXe = TenKieuXe;
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
		/// Gets or sets the MaLoaiXe value.
		/// </summary>
		public virtual int MaLoaiXe
		{
			get { return m_MaLoaiXe; }
			set { m_MaLoaiXe = value; }
		}

		/// <summary>
		/// Gets or sets the TenKieuXe value.
		/// </summary>
		public virtual string TenKieuXe
		{
			get { return m_TenKieuXe; }
			set { m_TenKieuXe = value; }
		}

		#endregion
	}
}

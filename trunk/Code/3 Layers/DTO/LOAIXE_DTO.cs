using System;

namespace Layers.DTO
{
	public class LOAIXE_DTO
	{
		#region Fields

		private int m_Ma;
		private string m_TenLoaiXe;
		private string m_GhiChu;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LOAIXE_DTO class.
		/// </summary>
		public LOAIXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the LOAIXE_DTO class.
		/// </summary>
		public LOAIXE_DTO(int Ma, string TenLoaiXe, string GhiChu)
		{
			m_Ma = Ma;
			m_TenLoaiXe = TenLoaiXe;
			m_GhiChu = GhiChu;
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
		/// Gets or sets the TenLoaiXe value.
		/// </summary>
		public virtual string TenLoaiXe
		{
			get { return m_TenLoaiXe; }
			set { m_TenLoaiXe = value; }
		}

		/// <summary>
		/// Gets or sets the GhiChu value.
		/// </summary>
		public virtual string GhiChu
		{
			get { return m_GhiChu; }
			set { m_GhiChu = value; }
		}

		#endregion
	}
}

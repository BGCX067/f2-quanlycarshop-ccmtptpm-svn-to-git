using System;

namespace Layers.DTO
{
	public class HANGSANXUAT_DTO
	{
		#region Fields

		private int m_Ma;
		private string m_TenHangXe;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HANGSANXUAT_DTO class.
		/// </summary>
		public HANGSANXUAT_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the HANGSANXUAT_DTO class.
		/// </summary>
		public HANGSANXUAT_DTO(int Ma, string TenHangXe)
		{
			m_Ma = Ma;
			m_TenHangXe = TenHangXe;
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
		/// Gets or sets the TenHangXe value.
		/// </summary>
		public virtual string TenHangXe
		{
			get { return m_TenHangXe; }
			set { m_TenHangXe = value; }
		}

		#endregion
	}
}

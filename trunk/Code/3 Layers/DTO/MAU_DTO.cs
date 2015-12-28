using System;

namespace Layers.DTO
{
	public class MAU_DTO
	{
		#region Fields

		private string m_Ma;
		private string m_Mau;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MAU_DTO class.
		/// </summary>
		public MAU_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the MAU_DTO class.
		/// </summary>
		public MAU_DTO(string Ma, string Mau)
		{
			m_Ma = Ma;
			m_Mau = Mau;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Ma value.
		/// </summary>
		public virtual string Ma
		{
			get { return m_Ma; }
			set { m_Ma = value; }
		}

		/// <summary>
		/// Gets or sets the Mau value.
		/// </summary>
		public virtual string Mau
		{
			get { return m_Mau; }
			set { m_Mau = value; }
		}

		#endregion
	}
}

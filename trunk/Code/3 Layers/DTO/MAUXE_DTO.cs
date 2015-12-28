using System;

namespace Layers.DTO
{
	public class MAUXE_DTO
	{
		#region Fields

		private int m_MaXe;
		private string m_MaMau;
        private string m_Mau;
		private int m_SoLuong;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MAUXE_DTO class.
		/// </summary>
		public MAUXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the MAUXE_DTO class.
		/// </summary>
		public MAUXE_DTO(int MaXe, string MaMau, int SoLuong)
		{
			m_MaXe = MaXe;
			m_MaMau = MaMau;
			m_SoLuong = SoLuong;
		}

		#endregion

		#region Properties
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

        public string Mau
        {
            get { return m_Mau; }
            set { m_Mau = value; }
        }

		/// <summary>
		/// Gets or sets the SoLuong value.
		/// </summary>
		public virtual int SoLuong
		{
			get { return m_SoLuong; }
			set { m_SoLuong = value; }
		}

		#endregion
	}
}

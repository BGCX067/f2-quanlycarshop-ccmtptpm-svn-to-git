using System;

namespace Layers.DTO
{
	public class CTPHIEUNHAPXE_DTO
	{
		#region Fields

		private int m_MaPhieuNhapXe;
		private int m_MaXe;
		private string m_MaMau;
		private int m_SoLuong;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CTPHIEUNHAPXE_DTO class.
		/// </summary>
		public CTPHIEUNHAPXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CTPHIEUNHAPXE_DTO class.
		/// </summary>
		public CTPHIEUNHAPXE_DTO(int MaPhieuNhapXe, int MaXe, string MaMau, int SoLuong)
		{
			m_MaPhieuNhapXe = MaPhieuNhapXe;
			m_MaXe = MaXe;
			m_MaMau = MaMau;
			m_SoLuong = SoLuong;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MaPhieuNhapXe value.
		/// </summary>
		public virtual int MaPhieuNhapXe
		{
			get { return m_MaPhieuNhapXe; }
			set { m_MaPhieuNhapXe = value; }
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

		#endregion
	}
}

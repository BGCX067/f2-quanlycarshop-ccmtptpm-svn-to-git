using System;

namespace Layers.DTO
{
	public class CHITIETPHIEUXUATXE_DTO
	{
		#region Fields

		private int m_MaPhieuXuatXe;
		private int m_MaXe;
		private string m_MaMau;
		private int m_SoLuong;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CHITIETPHIEUXUATXE_DTO class.
		/// </summary>
		public CHITIETPHIEUXUATXE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CHITIETPHIEUXUATXE_DTO class.
		/// </summary>
		public CHITIETPHIEUXUATXE_DTO(int MaPhieuXuatXe, int MaXe, string MaMau, int SoLuong)
		{
			m_MaPhieuXuatXe = MaPhieuXuatXe;
			m_MaXe = MaXe;
			m_MaMau = MaMau;
			m_SoLuong = SoLuong;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MaPhieuXuatXe value.
		/// </summary>
		public virtual int MaPhieuXuatXe
		{
			get { return m_MaPhieuXuatXe; }
			set { m_MaPhieuXuatXe = value; }
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

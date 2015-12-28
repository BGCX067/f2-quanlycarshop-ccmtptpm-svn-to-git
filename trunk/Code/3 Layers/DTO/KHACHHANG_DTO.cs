using System;

namespace Layers.DTO
{
	public class KHACHHANG_DTO
	{
		#region Fields

		private int m_Ma;
		private string m_HoTen;
        private Boolean m_Phai;
		private string m_PhaiChu;
		private string m_DiaChi;
		private string m_DienThoai;
		private string m_Cmnd;
		private bool m_LoaiKhachHang;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KHACHHANG_DTO class.
		/// </summary>
		public KHACHHANG_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the KHACHHANG_DTO class.
		/// </summary>
		public KHACHHANG_DTO(int Ma, string HoTen, string Phai, string DiaChi, string DienThoai, string Cmnd, bool LoaiKhachHang)
		{
			m_Ma = Ma;
			m_HoTen = HoTen;
			m_PhaiChu = Phai;
			m_DiaChi = DiaChi;
			m_DienThoai = DienThoai;
			m_Cmnd = Cmnd;
			m_LoaiKhachHang = LoaiKhachHang;
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
		/// Gets or sets the HoTen value.
		/// </summary>
		public virtual string HoTen
		{
			get { return m_HoTen; }
			set { m_HoTen = value; }
		}

        public Boolean Phai
        {
            get { return m_Phai; }
            set { m_Phai = value; }
        }

		/// <summary>
		/// Gets or sets the Phai value.
		/// </summary>
		public virtual string PhaiChu
		{
			get { return m_PhaiChu; }
			set { m_PhaiChu = value; }
		}

		/// <summary>
		/// Gets or sets the DiaChi value.
		/// </summary>
		public virtual string DiaChi
		{
			get { return m_DiaChi; }
			set { m_DiaChi = value; }
		}

		/// <summary>
		/// Gets or sets the DienThoai value.
		/// </summary>
		public virtual string DienThoai
		{
			get { return m_DienThoai; }
			set { m_DienThoai = value; }
		}

		/// <summary>
		/// Gets or sets the Cmnd value.
		/// </summary>
		public virtual string Cmnd
		{
			get { return m_Cmnd; }
			set { m_Cmnd = value; }
		}

		/// <summary>
		/// Gets or sets the LoaiKhachHang value.
		/// </summary>
		public virtual bool LoaiKhachHang
		{
			get { return m_LoaiKhachHang; }
			set { m_LoaiKhachHang = value; }
		}

		#endregion
	}
}

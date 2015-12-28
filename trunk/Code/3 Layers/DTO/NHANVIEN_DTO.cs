using System;

namespace Layers.DTO
{
	public class NHANVIEN_DTO
	{
		#region Fields

		private int m_Ma;
		private string m_HoTen;
		private int m_MaLoaiNhanVien;
        private string m_TenLoaiNhanVien;
		private string m_Username;
		private string m_UserPassword;
		private bool m_Phai;
		private DateTime m_NgaySinh;
		private string m_DiaChi;
		private string m_DienThoai;
		private string m_Cmnd;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NHANVIEN_DTO class.
		/// </summary>
		public NHANVIEN_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the NHANVIEN_DTO class.
		/// </summary>
		public NHANVIEN_DTO(int Ma, string HoTen, int MaLoaiNhanVien, string Username, string UserPassword, bool Phai, DateTime NgaySinh, string DiaChi, string DienThoai, string Cmnd)
		{
			m_Ma = Ma;
			m_HoTen = HoTen;
			m_MaLoaiNhanVien = MaLoaiNhanVien;
			m_Username = Username;
			m_UserPassword = UserPassword;
			m_Phai = Phai;
			m_NgaySinh = NgaySinh;
			m_DiaChi = DiaChi;
			m_DienThoai = DienThoai;
			m_Cmnd = Cmnd;
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

		/// <summary>
		/// Gets or sets the MaLoaiNhanVien value.
		/// </summary>
		public virtual int MaLoaiNhanVien
		{
			get { return m_MaLoaiNhanVien; }
			set { m_MaLoaiNhanVien = value; }
		}

        public string TenLoaiNhanVien
        {
            get { return m_TenLoaiNhanVien; }
            set { m_TenLoaiNhanVien = value; }
        }

		/// <summary>
		/// Gets or sets the Username value.
		/// </summary>
		public virtual string Username
		{
			get { return m_Username; }
			set { m_Username = value; }
		}

		/// <summary>
		/// Gets or sets the UserPassword value.
		/// </summary>
		public virtual string UserPassword
		{
			get { return m_UserPassword; }
			set { m_UserPassword = value; }
		}

		/// <summary>
		/// Gets or sets the Phai value.
		/// </summary>
		public virtual bool Phai
		{
			get { return m_Phai; }
			set { m_Phai = value; }
		}

		/// <summary>
		/// Gets or sets the NgaySinh value.
		/// </summary>
		public virtual DateTime NgaySinh
		{
			get { return m_NgaySinh; }
			set { m_NgaySinh = value; }
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

		#endregion
	}
}

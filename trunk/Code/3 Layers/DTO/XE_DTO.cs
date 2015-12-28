using System;

namespace Layers.DTO
{
	public class XE_DTO
	{
        #region Fields

        private int m_Ma;
        private string m_TenXe;
        private int m_MaKieuXe;
        private string m_TenKieuXe;
        private int m_MaHangXe;
        private string m_TenHangXe;
        private int m_DoiXe;
        private decimal m_ChiSoNhienLieu;
        private int m_MaxSpeed;
        private string m_LoaiDiaHinh;
        private int m_SoChoNgoi;
        private decimal m_GiaTienBan;
        private decimal m_GiaTienMua;
        private int m_SoLuong;

        #endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the XE_DTO class.
		/// </summary>
		public XE_DTO()
		{
		}

		/// <summary>
		/// Initializes a new instance of the XE_DTO class.
		/// </summary>
        public XE_DTO(int Ma, string TenXe, int MaKieuXe, int MaHangXe, int DoiXe, decimal ChiSoNhienLieu, int MaxSpeed, string LoaiDiaHinh, int SoChoNgoi, decimal GiaTienBan, decimal GiaTienMua, int SoLuong)
        {
            m_Ma = Ma;
            m_TenXe = TenXe;
            m_MaKieuXe = MaKieuXe;
            m_MaHangXe = MaHangXe;
            m_DoiXe = DoiXe;
            m_ChiSoNhienLieu = ChiSoNhienLieu;
            m_MaxSpeed = MaxSpeed;
            m_LoaiDiaHinh = LoaiDiaHinh;
            m_SoChoNgoi = SoChoNgoi;
            m_GiaTienBan = GiaTienBan;
            m_GiaTienMua = GiaTienMua;
            m_SoLuong = SoLuong;
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
		/// Gets or sets the TenXe value.
		/// </summary>
		public virtual string TenXe
		{
			get { return m_TenXe; }
			set { m_TenXe = value; }
		}

		/// <summary>
		/// Gets or sets the MaKieuXe value.
		/// </summary>
		public virtual int MaKieuXe
		{
			get { return m_MaKieuXe; }
			set { m_MaKieuXe = value; }
		}

        public string TenKieuXe
        {
            get { return m_TenKieuXe; }
            set { m_TenKieuXe = value; }
        }

		/// <summary>
		/// Gets or sets the MaHangXe value.
		/// </summary>
		public virtual int MaHangXe
		{
			get { return m_MaHangXe; }
			set { m_MaHangXe = value; }
		}

        public string TenHangXe
        {
            get { return m_TenHangXe; }
            set { m_TenHangXe = value; }
        }

		/// <summary>
		/// Gets or sets the DoiXe value.
		/// </summary>
		public virtual int DoiXe
		{
			get { return m_DoiXe; }
			set { m_DoiXe = value; }
		}

		/// <summary>
		/// Gets or sets the ChiSoNhienLieu value.
		/// </summary>
		public virtual decimal ChiSoNhienLieu
		{
			get { return m_ChiSoNhienLieu; }
			set { m_ChiSoNhienLieu = value; }
		}

		/// <summary>
		/// Gets or sets the MaxSpeed value.
		/// </summary>
		public virtual int MaxSpeed
		{
			get { return m_MaxSpeed; }
			set { m_MaxSpeed = value; }
		}

		/// <summary>
		/// Gets or sets the LoaiDiaHinh value.
		/// </summary>
		public virtual string LoaiDiaHinh
		{
			get { return m_LoaiDiaHinh; }
			set { m_LoaiDiaHinh = value; }
		}

		/// <summary>
		/// Gets or sets the SoChoNgoi value.
		/// </summary>
		public virtual int SoChoNgoi
		{
			get { return m_SoChoNgoi; }
			set { m_SoChoNgoi = value; }
		}

		/// <summary>
		/// Gets or sets the GiaTienBan value.
		/// </summary>
		public virtual decimal GiaTienBan
		{
			get { return m_GiaTienBan; }
			set { m_GiaTienBan = value; }
		}

        /// <summary>
        /// Gets or sets the GiaTienMua value.
        /// </summary>
        public virtual decimal GiaTienMua
        {
            get { return m_GiaTienMua; }
            set { m_GiaTienMua = value; }
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

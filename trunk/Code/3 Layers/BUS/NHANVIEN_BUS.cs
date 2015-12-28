using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class NHANVIEN_BUS
	{
		#region Constructors

		public NHANVIEN_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the NHAN_VIEN table.
		/// </summary>
		public void Insert(NHANVIEN_DTO NhanVien)
		{
			ValidationUtility.ValidateArgument("NhanVien", NhanVien);
			new NHANVIEN_DAO().Insert(NhanVien);
		}

		/// <summary>
		/// Updates a record in the NHAN_VIEN table.
		/// </summary>
		public void Update(NHANVIEN_DTO NhanVien)
		{
			ValidationUtility.ValidateArgument("NhanVien", NhanVien);
			new NHANVIEN_DAO().Update(NhanVien);
		}

		/// <summary>
		/// Deletes a record from the NHAN_VIEN table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new NHANVIEN_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the NHAN_VIEN table by a foreign key.
		/// </summary>
		public void DeleteAllByMaLoaiNhanVien(int MaLoaiNhanVien)
		{
			new NHANVIEN_DAO().DeleteAllByMaLoaiNhanVien(MaLoaiNhanVien);
		}

		/// <summary>
		/// Selects a single record from the NHAN_VIEN table.
		/// </summary>
		public NHANVIEN_DTO Select(int Ma)
		{
			return new NHANVIEN_DAO().Select(Ma);
		}
        public NHANVIEN_DTO SelectByUserNamePassword(string UserName, string Password)
        {
            return new NHANVIEN_DAO().SelectByUserNamePassword(UserName, Password);
        }

        /// <summary>
        /// Selects a single record from the NHAN_VIEN table by MaHoaDon
        /// </summary>
        public NHANVIEN_DTO SelectByMaHoaDon(int MaHoaDon)
        {
            return new NHANVIEN_DAO().SelectByMaHoaDon(MaHoaDon);
        }

		/// <summary>
		/// Selects all records from the NHAN_VIEN table.
		/// </summary>
		public List<NHANVIEN_DTO> SelectAll()
		{
			return new NHANVIEN_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the NHAN_VIEN table by a foreign key.
		/// </summary>
		public List<NHANVIEN_DTO> SelectAllByMaLoaiNhanVien(int MaLoaiNhanVien)
		{
			return new NHANVIEN_DAO().SelectAllByMaLoaiNhanVien(MaLoaiNhanVien);
		}


		#endregion
	}
}

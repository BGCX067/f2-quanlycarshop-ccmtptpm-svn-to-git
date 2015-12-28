using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class KHACHHANG_BUS
	{
		#region Constructors

		public KHACHHANG_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the KHACH_HANG table.
		/// </summary>
		public void Insert(KHACHHANG_DTO KhachHang)
		{
			ValidationUtility.ValidateArgument("KhachHang", KhachHang);
			new KHACHHANG_DAO().Insert(KhachHang);
		}

		/// <summary>
		/// Updates a record in the KHACH_HANG table.
		/// </summary>
		public void Update(KHACHHANG_DTO KhachHang)
		{
			ValidationUtility.ValidateArgument("KhachHang", KhachHang);
			new KHACHHANG_DAO().Update(KhachHang);
		}

		/// <summary>
		/// Deletes a record from the KHACH_HANG table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new KHACHHANG_DAO().Delete(Ma);
		}

		/// <summary>
		/// Selects a single record from the KHACH_HANG table.
		/// </summary>
		public KHACHHANG_DTO Select(int Ma)
		{
			return new KHACHHANG_DAO().Select(Ma);
		}

        /// <summary>
        /// Selects a single record from the KHACH_HANG table by MaHoaDon
        /// </summary>
        public KHACHHANG_DTO SelectByMaHoaDon(int MaHoaDon)
        {
            return new KHACHHANG_DAO().SelectByMaHoaDon(MaHoaDon);
        }

        public KHACHHANG_DTO SelectByThongTin(string HoTen, string DiaChi, string CMND)
        {
            return new KHACHHANG_DAO().SelectByThongTin(HoTen, DiaChi, CMND);
        }

		/// <summary>
		/// Selects all records from the KHACH_HANG table.
		/// </summary>
		public List<KHACHHANG_DTO> SelectAll()
		{
			return new KHACHHANG_DAO().SelectAll();
		}


		#endregion
	}
}

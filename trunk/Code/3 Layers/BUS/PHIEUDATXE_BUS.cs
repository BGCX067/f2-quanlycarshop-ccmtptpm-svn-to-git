using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class PHIEUDATXE_BUS
	{
		#region Constructors

		public PHIEUDATXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the PHIEU_DAT_XE table.
		/// </summary>
		public void Insert(PHIEUDATXE_DTO PhieuDatXe)
		{
			ValidationUtility.ValidateArgument("PhieuDatXe", PhieuDatXe);
			new PHIEUDATXE_DAO().Insert(PhieuDatXe);
		}

		/// <summary>
		/// Updates a record in the PHIEU_DAT_XE table.
		/// </summary>
		public void Update(PHIEUDATXE_DTO PhieuDatXe)
		{
			ValidationUtility.ValidateArgument("PhieuDatXe", PhieuDatXe);
			new PHIEUDATXE_DAO().Update(PhieuDatXe);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_DAT_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new PHIEUDATXE_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaKhachHang(int MaKhachHang)
		{
			new PHIEUDATXE_DAO().DeleteAllByMaKhachHang(MaKhachHang);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			new PHIEUDATXE_DAO().DeleteAllByMaNhanVien(MaNhanVien);
		}

		/// <summary>
		/// Selects a single record from the PHIEU_DAT_XE table.
		/// </summary>
		public PHIEUDATXE_DTO Select(int Ma)
		{
			return new PHIEUDATXE_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the PHIEU_DAT_XE table.
		/// </summary>
		public List<PHIEUDATXE_DTO> SelectAll()
		{
			return new PHIEUDATXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<PHIEUDATXE_DTO> SelectAllByMaKhachHang(int MaKhachHang)
		{
			return new PHIEUDATXE_DAO().SelectAllByMaKhachHang(MaKhachHang);
		}

		/// <summary>
		/// Selects all records from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<PHIEUDATXE_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			return new PHIEUDATXE_DAO().SelectAllByMaNhanVien(MaNhanVien);
		}


		#endregion
	}
}

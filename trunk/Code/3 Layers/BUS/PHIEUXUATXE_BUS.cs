using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class PHIEUXUATXE_BUS
	{
		#region Constructors

		public PHIEUXUATXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the PHIEU_XUAT_XE table.
		/// </summary>
		public void Insert(PHIEUXUATXE_DTO PhieuXuatXe)
		{
			ValidationUtility.ValidateArgument("PhieuXuatXe", PhieuXuatXe);
			new PHIEUXUATXE_DAO().Insert(PhieuXuatXe);
		}

		/// <summary>
		/// Updates a record in the PHIEU_XUAT_XE table.
		/// </summary>
		public void Update(PHIEUXUATXE_DTO PhieuXuatXe)
		{
			ValidationUtility.ValidateArgument("PhieuXuatXe", PhieuXuatXe);
			new PHIEUXUATXE_DAO().Update(PhieuXuatXe);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_XUAT_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new PHIEUXUATXE_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			new PHIEUXUATXE_DAO().DeleteAllByMaNhanVien(MaNhanVien);
		}

		/// <summary>
		/// Selects a single record from the PHIEU_XUAT_XE table.
		/// </summary>
		public PHIEUXUATXE_DTO Select(int Ma)
		{
			return new PHIEUXUATXE_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the PHIEU_XUAT_XE table.
		/// </summary>
		public List<PHIEUXUATXE_DTO> SelectAll()
		{
			return new PHIEUXUATXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<PHIEUXUATXE_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			return new PHIEUXUATXE_DAO().SelectAllByMaNhanVien(MaNhanVien);
		}


		#endregion
	}
}

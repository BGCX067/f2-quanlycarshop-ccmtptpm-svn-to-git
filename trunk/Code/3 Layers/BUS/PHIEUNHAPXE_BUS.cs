using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class PHIEUNHAPXE_BUS
	{
		#region Constructors

		public PHIEUNHAPXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the PHIEU_NHAP_XE table.
		/// </summary>
		public void Insert(PHIEUNHAPXE_DTO PhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("PhieuNhapXe", PhieuNhapXe);
			new PHIEUNHAPXE_DAO().Insert(PhieuNhapXe);
		}

		/// <summary>
		/// Updates a record in the PHIEU_NHAP_XE table.
		/// </summary>
		public void Update(PHIEUNHAPXE_DTO PhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("PhieuNhapXe", PhieuNhapXe);
			new PHIEUNHAPXE_DAO().Update(PhieuNhapXe);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_NHAP_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new PHIEUNHAPXE_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaDonDatHang(int MaDonDatHang)
		{
			new PHIEUNHAPXE_DAO().DeleteAllByMaDonDatHang(MaDonDatHang);
		}

		/// <summary>
		/// Selects a single record from the PHIEU_NHAP_XE table.
		/// </summary>
		public PHIEUNHAPXE_DTO Select(int Ma)
		{
			return new PHIEUNHAPXE_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the PHIEU_NHAP_XE table.
		/// </summary>
		public List<PHIEUNHAPXE_DTO> SelectAll()
		{
			return new PHIEUNHAPXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<PHIEUNHAPXE_DTO> SelectAllByMaDonDatHang(int MaDonDatHang)
		{
			return new PHIEUNHAPXE_DAO().SelectAllByMaDonDatHang(MaDonDatHang);
		}


		#endregion
	}
}

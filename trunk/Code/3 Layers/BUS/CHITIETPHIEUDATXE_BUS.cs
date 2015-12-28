using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class CHITIETPHIEUDATXE_BUS
	{
		#region Constructors

		public CHITIETPHIEUDATXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public void Insert(CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe)
		{
			ValidationUtility.ValidateArgument("ChiTietPhieuDatXe", ChiTietPhieuDatXe);
			new CHITIETPHIEUDATXE_DAO().Insert(ChiTietPhieuDatXe);
		}

		/// <summary>
		/// Updates a record in the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public void Update(CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe)
		{
			ValidationUtility.ValidateArgument("ChiTietPhieuDatXe", ChiTietPhieuDatXe);
			new CHITIETPHIEUDATXE_DAO().Update(ChiTietPhieuDatXe);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new CHITIETPHIEUDATXE_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			new CHITIETPHIEUDATXE_DAO().DeleteAllByMaMau(MaMau);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaPhieuDat(int MaPhieuDat)
		{
			new CHITIETPHIEUDATXE_DAO().DeleteAllByMaPhieuDat(MaPhieuDat);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			new CHITIETPHIEUDATXE_DAO().DeleteAllByMaXe(MaXe);
		}

		/// <summary>
		/// Selects a single record from the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public CHITIETPHIEUDATXE_DTO Select(int Ma)
		{
			return new CHITIETPHIEUDATXE_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAll()
		{
			return new CHITIETPHIEUDATXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAllByMaMau(string MaMau)
		{
			return new CHITIETPHIEUDATXE_DAO().SelectAllByMaMau(MaMau);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAllByMaPhieuDat(int MaPhieuDat)
		{
			return new CHITIETPHIEUDATXE_DAO().SelectAllByMaPhieuDat(MaPhieuDat);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAllByMaXe(int MaXe)
		{
			return new CHITIETPHIEUDATXE_DAO().SelectAllByMaXe(MaXe);
		}


		#endregion
	}
}

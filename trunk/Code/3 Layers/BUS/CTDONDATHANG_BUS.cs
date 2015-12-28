using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class CTDONDATHANG_BUS
	{
		#region Constructors

		public CTDONDATHANG_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CT_DON_DAT_HANG table.
		/// </summary>
		public void Insert(CTDONDATHANG_DTO CtDonDatHang)
		{
			ValidationUtility.ValidateArgument("CtDonDatHang", CtDonDatHang);
			new CTDONDATHANG_DAO().Insert(CtDonDatHang);
		}

		/// <summary>
		/// Updates a record in the CT_DON_DAT_HANG table.
		/// </summary>
		public void Update(CTDONDATHANG_DTO CtDonDatHang)
		{
			ValidationUtility.ValidateArgument("CtDonDatHang", CtDonDatHang);
			new CTDONDATHANG_DAO().Update(CtDonDatHang);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by its primary key.
		/// </summary>
		public void Delete(int MaDonDatHang, int MaXe, string MaMau)
		{
			new CTDONDATHANG_DAO().Delete(MaDonDatHang, MaXe, MaMau);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public void DeleteAllByMaDonDatHang(int MaDonDatHang)
		{
			new CTDONDATHANG_DAO().DeleteAllByMaDonDatHang(MaDonDatHang);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			new CTDONDATHANG_DAO().DeleteAllByMaMau(MaMau);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			new CTDONDATHANG_DAO().DeleteAllByMaXe(MaXe);
		}

		/// <summary>
		/// Selects a single record from the CT_DON_DAT_HANG table.
		/// </summary>
		public CTDONDATHANG_DTO Select(int MaDonDatHang, int MaXe, string MaMau)
		{
			return new CTDONDATHANG_DAO().Select(MaDonDatHang, MaXe, MaMau);
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAll()
		{
			return new CTDONDATHANG_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAllByMaDonDatHang(int MaDonDatHang)
		{
			return new CTDONDATHANG_DAO().SelectAllByMaDonDatHang(MaDonDatHang);
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAllByMaMau(string MaMau)
		{
			return new CTDONDATHANG_DAO().SelectAllByMaMau(MaMau);
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAllByMaXe(int MaXe)
		{
			return new CTDONDATHANG_DAO().SelectAllByMaXe(MaXe);
		}


		#endregion
	}
}

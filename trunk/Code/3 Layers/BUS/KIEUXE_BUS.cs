using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class KIEUXE_BUS
	{
		#region Constructors

		public KIEUXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the KIEU_XE table.
		/// </summary>
		public void Insert(KIEUXE_DTO KieuXe)
		{
			ValidationUtility.ValidateArgument("KieuXe", KieuXe);
			new KIEUXE_DAO().Insert(KieuXe);
		}

		/// <summary>
		/// Updates a record in the KIEU_XE table.
		/// </summary>
		public void Update(KIEUXE_DTO KieuXe)
		{
			ValidationUtility.ValidateArgument("KieuXe", KieuXe);
			new KIEUXE_DAO().Update(KieuXe);
		}

		/// <summary>
		/// Deletes a record from the KIEU_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new KIEUXE_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the KIEU_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaLoaiXe(int MaLoaiXe)
		{
			new KIEUXE_DAO().DeleteAllByMaLoaiXe(MaLoaiXe);
		}

		/// <summary>
		/// Selects a single record from the KIEU_XE table.
		/// </summary>
		public KIEUXE_DTO Select(int Ma)
		{
			return new KIEUXE_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the KIEU_XE table.
		/// </summary>
		public List<KIEUXE_DTO> SelectAll()
		{
			return new KIEUXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the KIEU_XE table by a foreign key.
		/// </summary>
		public List<KIEUXE_DTO> SelectAllByMaLoaiXe(int MaLoaiXe)
		{
			return new KIEUXE_DAO().SelectAllByMaLoaiXe(MaLoaiXe);
		}


		#endregion
	}
}

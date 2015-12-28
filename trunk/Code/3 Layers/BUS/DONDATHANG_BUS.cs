using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class DONDATHANG_BUS
	{
		#region Constructors

		public DONDATHANG_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the DON_DAT_HANG table.
		/// </summary>
		public void Insert(DONDATHANG_DTO DonDatHang)
		{
			ValidationUtility.ValidateArgument("DonDatHang", DonDatHang);
			new DONDATHANG_DAO().Insert(DonDatHang);
		}

		/// <summary>
		/// Updates a record in the DON_DAT_HANG table.
		/// </summary>
		public void Update(DONDATHANG_DTO DonDatHang)
		{
			ValidationUtility.ValidateArgument("DonDatHang", DonDatHang);
			new DONDATHANG_DAO().Update(DonDatHang);
		}

		/// <summary>
		/// Deletes a record from the DON_DAT_HANG table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new DONDATHANG_DAO().Delete(Ma);
		}

		/// <summary>
		/// Selects a single record from the DON_DAT_HANG table.
		/// </summary>
		public DONDATHANG_DTO Select(int Ma)
		{
			return new DONDATHANG_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the DON_DAT_HANG table.
		/// </summary>
		public List<DONDATHANG_DTO> SelectAll()
		{
			return new DONDATHANG_DAO().SelectAll();
		}


		#endregion
	}
}

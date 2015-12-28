using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class HANGSANXUAT_BUS
	{
		#region Constructors

		public HANGSANXUAT_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the HANG_SAN_XUAT table.
		/// </summary>
		public void Insert(HANGSANXUAT_DTO HangSanXuat)
		{
			ValidationUtility.ValidateArgument("HangSanXuat", HangSanXuat);
			new HANGSANXUAT_DAO().Insert(HangSanXuat);
		}

		/// <summary>
		/// Updates a record in the HANG_SAN_XUAT table.
		/// </summary>
		public void Update(HANGSANXUAT_DTO HangSanXuat)
		{
			ValidationUtility.ValidateArgument("HangSanXuat", HangSanXuat);
			new HANGSANXUAT_DAO().Update(HangSanXuat);
		}

		/// <summary>
		/// Deletes a record from the HANG_SAN_XUAT table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new HANGSANXUAT_DAO().Delete(Ma);
		}

		/// <summary>
		/// Selects a single record from the HANG_SAN_XUAT table.
		/// </summary>
		public HANGSANXUAT_DTO Select(int Ma)
		{
			return new HANGSANXUAT_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the HANG_SAN_XUAT table.
		/// </summary>
		public List<HANGSANXUAT_DTO> SelectAll()
		{
			return new HANGSANXUAT_DAO().SelectAll();
		}


		#endregion
	}
}

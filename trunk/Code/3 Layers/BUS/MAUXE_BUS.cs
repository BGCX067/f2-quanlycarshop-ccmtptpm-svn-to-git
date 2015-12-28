using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class MAUXE_BUS
	{
		#region Constructors

		public MAUXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the MAU_XE table.
		/// </summary>
		public void Insert(MAUXE_DTO MauXe)
		{
			ValidationUtility.ValidateArgument("MauXe", MauXe);
			new MAUXE_DAO().Insert(MauXe);
		}

		/// <summary>
		/// Updates a record in the MAU_XE table.
		/// </summary>
		public void Update(MAUXE_DTO MauXe)
		{
			ValidationUtility.ValidateArgument("MauXe", MauXe);
			new MAUXE_DAO().Update(MauXe);
		}

		/// <summary>
		/// Deletes a record from the MAU_XE table by its primary key.
		/// </summary>
		public void Delete(int MaXe, string MaMau)
		{
			new MAUXE_DAO().Delete(MaXe, MaMau);
		}

		/// <summary>
		/// Deletes a record from the MAU_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			new MAUXE_DAO().DeleteAllByMaMau(MaMau);
		}

		/// <summary>
		/// Deletes a record from the MAU_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			new MAUXE_DAO().DeleteAllByMaXe(MaXe);
		}

		/// <summary>
		/// Selects a single record from the MAU_XE table.
		/// </summary>
		public MAUXE_DTO Select(int MaXe, string MaMau)
		{
			return new MAUXE_DAO().Select(MaXe, MaMau);
		}

		/// <summary>
		/// Selects all records from the MAU_XE table.
		/// </summary>
		public List<MAUXE_DTO> SelectAll()
		{
			return new MAUXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the MAU_XE table by a foreign key.
		/// </summary>
		public List<MAUXE_DTO> SelectAllByMaMau(string MaMau)
		{
			return new MAUXE_DAO().SelectAllByMaMau(MaMau);
		}

		/// <summary>
		/// Selects all records from the MAU_XE table by a foreign key.
		/// </summary>
		public List<MAUXE_DTO> SelectAllByMaXe(int MaXe)
		{
			return new MAUXE_DAO().SelectAllByMaXe(MaXe);
		}


		#endregion
	}
}

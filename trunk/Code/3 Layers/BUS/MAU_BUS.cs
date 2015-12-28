using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class MAU_BUS
	{
		#region Constructors

		public MAU_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the MAU table.
		/// </summary>
		public void Insert(MAU_DTO Mau)
		{
			ValidationUtility.ValidateArgument("Mau", Mau);
			new MAU_DAO().Insert(Mau);
		}

		/// <summary>
		/// Updates a record in the MAU table.
		/// </summary>
		public void Update(MAU_DTO Mau)
		{
			ValidationUtility.ValidateArgument("Mau", Mau);
			new MAU_DAO().Update(Mau);
		}

		/// <summary>
		/// Deletes a record from the MAU table by its primary key.
		/// </summary>
		public void Delete(string Ma)
		{
			new MAU_DAO().Delete(Ma);
		}

		/// <summary>
		/// Selects a single record from the MAU table.
		/// </summary>
		public MAU_DTO Select(string Ma)
		{
			return new MAU_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the MAU table.
		/// </summary>
		public List<MAU_DTO> SelectAll()
		{
			return new MAU_DAO().SelectAll();
		}


		#endregion
	}
}

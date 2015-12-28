using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class LOAIXE_BUS
	{
		#region Constructors

		public LOAIXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the LOAI_XE table.
		/// </summary>
		public void Insert(LOAIXE_DTO LoaiXe)
		{
			ValidationUtility.ValidateArgument("LoaiXe", LoaiXe);
			new LOAIXE_DAO().Insert(LoaiXe);
		}

		/// <summary>
		/// Updates a record in the LOAI_XE table.
		/// </summary>
		public void Update(LOAIXE_DTO LoaiXe)
		{
			ValidationUtility.ValidateArgument("LoaiXe", LoaiXe);
			new LOAIXE_DAO().Update(LoaiXe);
		}

		/// <summary>
		/// Deletes a record from the LOAI_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new LOAIXE_DAO().Delete(Ma);
		}

		/// <summary>
		/// Selects a single record from the LOAI_XE table.
		/// </summary>
		public LOAIXE_DTO Select(int Ma)
		{
			return new LOAIXE_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the LOAI_XE table.
		/// </summary>
		public List<LOAIXE_DTO> SelectAll()
		{
			return new LOAIXE_DAO().SelectAll();
		}


		#endregion
	}
}

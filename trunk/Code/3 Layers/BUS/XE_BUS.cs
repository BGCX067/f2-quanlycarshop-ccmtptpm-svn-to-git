using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class XE_BUS
	{
		#region Constructors

		public XE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the XE table.
		/// </summary>
		public void Insert(XE_DTO Xe)
		{
			ValidationUtility.ValidateArgument("Xe", Xe);
			new XE_DAO().Insert(Xe);
		}

		/// <summary>
		/// Updates a record in the XE table.
		/// </summary>
		public void Update(XE_DTO Xe)
		{
			ValidationUtility.ValidateArgument("Xe", Xe);
			new XE_DAO().Update(Xe);
		}

		/// <summary>
		/// Deletes a record from the XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new XE_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaHangXe(int MaHangXe)
		{
			new XE_DAO().DeleteAllByMaHangXe(MaHangXe);
		}

		/// <summary>
		/// Deletes a record from the XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaKieuXe(int MaKieuXe)
		{
			new XE_DAO().DeleteAllByMaKieuXe(MaKieuXe);
		}

		/// <summary>
		/// Selects a single record from the XE table.
		/// </summary>
		public XE_DTO Select(int Ma)
		{
			return new XE_DAO().Select(Ma);
		}

        public XE_DTO SelectByTenXe(string TenXe)
        {
            return new XE_DAO().SelectByTenXe(TenXe);
        }

        public XE_DTO SelectByMaHoaDon(int MaHoaDon)
        {
            return new XE_BUS().SelectByMaHoaDon(MaHoaDon);
        }

		/// <summary>
		/// Selects all records from the XE table.
		/// </summary>
		public List<XE_DTO> SelectAll()
		{
			return new XE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the XE table by a foreign key.
		/// </summary>
		public List<XE_DTO> SelectAllByMaHangXe(int MaHangXe)
		{
			return new XE_DAO().SelectAllByMaHangXe(MaHangXe);
		}

		/// <summary>
		/// Selects all records from the XE table by a foreign key.
		/// </summary>
		public List<XE_DTO> SelectAllByMaKieuXe(int MaKieuXe)
		{
			return new XE_DAO().SelectAllByMaKieuXe(MaKieuXe);
		}


		#endregion
	}
}

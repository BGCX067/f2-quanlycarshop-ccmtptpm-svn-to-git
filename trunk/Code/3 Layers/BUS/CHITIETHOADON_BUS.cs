using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class CHITIETHOADON_BUS
	{
		#region Constructors

		public CHITIETHOADON_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CHI_TIET_HOA_DON table.
		/// </summary>
		public void Insert(CHITIETHOADON_DTO ChiTietHoaDon)
		{
			ValidationUtility.ValidateArgument("ChiTietHoaDon", ChiTietHoaDon);
			new CHITIETHOADON_DAO().Insert(ChiTietHoaDon);
		}

		/// <summary>
		/// Updates a record in the CHI_TIET_HOA_DON table.
		/// </summary>
		public void Update(CHITIETHOADON_DTO ChiTietHoaDon)
		{
			ValidationUtility.ValidateArgument("ChiTietHoaDon", ChiTietHoaDon);
			new CHITIETHOADON_DAO().Update(ChiTietHoaDon);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_HOA_DON table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new CHITIETHOADON_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaHoaDon(int MaHoaDon)
		{
			new CHITIETHOADON_DAO().DeleteAllByMaHoaDon(MaHoaDon);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			new CHITIETHOADON_DAO().DeleteAllByMaXe(MaXe);
		}

		/// <summary>
		/// Selects a single record from the CHI_TIET_HOA_DON table.
		/// </summary>
		public CHITIETHOADON_DTO Select(int Ma)
		{
			return new CHITIETHOADON_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_HOA_DON table.
		/// </summary>
		public List<CHITIETHOADON_DTO> SelectAll()
		{
			return new CHITIETHOADON_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public List<CHITIETHOADON_DTO> SelectAllByMaHoaDon(int MaHoaDon)
		{
			return new CHITIETHOADON_DAO().SelectAllByMaHoaDon(MaHoaDon);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public List<CHITIETHOADON_DTO> SelectAllByMaXe(int MaXe)
		{
			return new CHITIETHOADON_DAO().SelectAllByMaXe(MaXe);
		}


		#endregion
	}
}

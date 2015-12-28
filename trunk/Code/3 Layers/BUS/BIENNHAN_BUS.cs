using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class BIENNHAN_BUS
	{
		#region Constructors

		public BIENNHAN_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the BIEN_NHAN table.
		/// </summary>
		public void Insert(BIENNHAN_DTO BienNhan)
		{
			ValidationUtility.ValidateArgument("BienNhan", BienNhan);
			new BIENNHAN_DAO().Insert(BienNhan);
		}

		/// <summary>
		/// Updates a record in the BIEN_NHAN table.
		/// </summary>
		public void Update(BIENNHAN_DTO BienNhan)
		{
			ValidationUtility.ValidateArgument("BienNhan", BienNhan);
			new BIENNHAN_DAO().Update(BienNhan);
		}

		/// <summary>
		/// Deletes a record from the BIEN_NHAN table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new BIENNHAN_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public void DeleteAllByMaHoaDon(int MaHoaDon)
		{
			new BIENNHAN_DAO().DeleteAllByMaHoaDon(MaHoaDon);
		}

		/// <summary>
		/// Deletes a record from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			new BIENNHAN_DAO().DeleteAllByMaNhanVien(MaNhanVien);
		}

		/// <summary>
		/// Selects a single record from the BIEN_NHAN table.
		/// </summary>
		public BIENNHAN_DTO Select(int Ma)
		{
			return new BIENNHAN_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the BIEN_NHAN table.
		/// </summary>
		public List<BIENNHAN_DTO> SelectAll()
		{
			return new BIENNHAN_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public List<BIENNHAN_DTO> SelectAllByMaHoaDon(int MaHoaDon)
		{
			return new BIENNHAN_DAO().SelectAllByMaHoaDon(MaHoaDon);
		}

		/// <summary>
		/// Selects all records from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public List<BIENNHAN_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			return new BIENNHAN_DAO().SelectAllByMaNhanVien(MaNhanVien);
		}


		#endregion
	}
}

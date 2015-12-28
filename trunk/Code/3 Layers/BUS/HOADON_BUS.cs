using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class HOADON_BUS
	{
		#region Constructors

		public HOADON_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the HOA_DON table.
		/// </summary>
		public void Insert(HOADON_DTO HoaDon)
		{
			ValidationUtility.ValidateArgument("HoaDon", HoaDon);
			new HOADON_DAO().Insert(HoaDon);
		}

		/// <summary>
		/// Updates a record in the HOA_DON table.
		/// </summary>
		public void Update(HOADON_DTO HoaDon)
		{
			ValidationUtility.ValidateArgument("HoaDon", HoaDon);
			new HOADON_DAO().Update(HoaDon);
		}

		/// <summary>
		/// Deletes a record from the HOA_DON table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new HOADON_DAO().Delete(Ma);
		}

		/// <summary>
		/// Deletes a record from the HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaKhachHang(int MaKhachHang)
		{
			new HOADON_DAO().DeleteAllByMaKhachHang(MaKhachHang);
		}

		/// <summary>
		/// Deletes a record from the HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			new HOADON_DAO().DeleteAllByMaNhanVien(MaNhanVien);
		}

		/// <summary>
		/// Selects a single record from the HOA_DON table.
		/// </summary>
		public HOADON_DTO Select(int Ma)
		{
			return new HOADON_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the HOA_DON table.
		/// </summary>
		public List<HOADON_DTO> SelectAll()
		{
			return new HOADON_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the HOA_DON table by a foreign key.
		/// </summary>
		public List<HOADON_DTO> SelectAllByMaKhachHang(int MaKhachHang)
		{
			return new HOADON_DAO().SelectAllByMaKhachHang(MaKhachHang);
		}

		/// <summary>
		/// Selects all records from the HOA_DON table by a foreign key.
		/// </summary>
		public List<HOADON_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			return new HOADON_DAO().SelectAllByMaNhanVien(MaNhanVien);
		}


		#endregion
	}
}

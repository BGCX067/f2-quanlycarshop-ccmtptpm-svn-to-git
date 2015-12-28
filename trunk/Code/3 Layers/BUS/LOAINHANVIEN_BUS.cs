using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class LOAINHANVIEN_BUS
	{
		#region Constructors

		public LOAINHANVIEN_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the LOAI_NHAN_VIEN table.
		/// </summary>
		public void Insert(LOAINHANVIEN_DTO LoaiNhanVien)
		{
			ValidationUtility.ValidateArgument("LoaiNhanVien", LoaiNhanVien);
			new LOAINHANVIEN_DAO().Insert(LoaiNhanVien);
		}

		/// <summary>
		/// Updates a record in the LOAI_NHAN_VIEN table.
		/// </summary>
		public void Update(LOAINHANVIEN_DTO LoaiNhanVien)
		{
			ValidationUtility.ValidateArgument("LoaiNhanVien", LoaiNhanVien);
			new LOAINHANVIEN_DAO().Update(LoaiNhanVien);
		}

		/// <summary>
		/// Deletes a record from the LOAI_NHAN_VIEN table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			new LOAINHANVIEN_DAO().Delete(Ma);
		}

		/// <summary>
		/// Selects a single record from the LOAI_NHAN_VIEN table.
		/// </summary>
		public LOAINHANVIEN_DTO Select(int Ma)
		{
			return new LOAINHANVIEN_DAO().Select(Ma);
		}

		/// <summary>
		/// Selects all records from the LOAI_NHAN_VIEN table.
		/// </summary>
		public List<LOAINHANVIEN_DTO> SelectAll()
		{
			return new LOAINHANVIEN_DAO().SelectAll();
		}


		#endregion
	}
}

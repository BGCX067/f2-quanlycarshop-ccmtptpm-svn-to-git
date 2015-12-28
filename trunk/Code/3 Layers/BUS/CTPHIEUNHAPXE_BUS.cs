using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class CTPHIEUNHAPXE_BUS
	{
		#region Constructors

		public CTPHIEUNHAPXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public void Insert(CTPHIEUNHAPXE_DTO CtPhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("CtPhieuNhapXe", CtPhieuNhapXe);
			new CTPHIEUNHAPXE_DAO().Insert(CtPhieuNhapXe);
		}

		/// <summary>
		/// Updates a record in the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public void Update(CTPHIEUNHAPXE_DTO CtPhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("CtPhieuNhapXe", CtPhieuNhapXe);
			new CTPHIEUNHAPXE_DAO().Update(CtPhieuNhapXe);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by its primary key.
		/// </summary>
		public void Delete(int MaPhieuNhapXe, int MaXe, string MaMau)
		{
			new CTPHIEUNHAPXE_DAO().Delete(MaPhieuNhapXe, MaXe, MaMau);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			new CTPHIEUNHAPXE_DAO().DeleteAllByMaMau(MaMau);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaPhieuNhapXe(int MaPhieuNhapXe)
		{
			new CTPHIEUNHAPXE_DAO().DeleteAllByMaPhieuNhapXe(MaPhieuNhapXe);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			new CTPHIEUNHAPXE_DAO().DeleteAllByMaXe(MaXe);
		}

		/// <summary>
		/// Selects a single record from the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public CTPHIEUNHAPXE_DTO Select(int MaPhieuNhapXe, int MaXe, string MaMau)
		{
			return new CTPHIEUNHAPXE_DAO().Select(MaPhieuNhapXe, MaXe, MaMau);
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAll()
		{
			return new CTPHIEUNHAPXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAllByMaMau(string MaMau)
		{
			return new CTPHIEUNHAPXE_DAO().SelectAllByMaMau(MaMau);
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAllByMaPhieuNhapXe(int MaPhieuNhapXe)
		{
			return new CTPHIEUNHAPXE_DAO().SelectAllByMaPhieuNhapXe(MaPhieuNhapXe);
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAllByMaXe(int MaXe)
		{
			return new CTPHIEUNHAPXE_DAO().SelectAllByMaXe(MaXe);
		}


		#endregion
	}
}

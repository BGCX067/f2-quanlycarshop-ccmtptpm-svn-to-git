using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Utilities;

using Layers.DTO;
using Layers.DAO;

namespace Layers.BUS
{
	public class CHITIETPHIEUXUATXE_BUS
	{
		#region Constructors

		public CHITIETPHIEUXUATXE_BUS()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CHI_TIET_PHIEU_XUAT_XE table.
		/// </summary>
		public void Insert(CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe)
		{
			ValidationUtility.ValidateArgument("ChiTietPhieuXuatXe", ChiTietPhieuXuatXe);
			new CHITIETPHIEUXUATXE_DAO().Insert(ChiTietPhieuXuatXe);
		}

		/// <summary>
		/// Updates a record in the CHI_TIET_PHIEU_XUAT_XE table.
		/// </summary>
		public void Update(CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe)
		{
			ValidationUtility.ValidateArgument("ChiTietPhieuXuatXe", ChiTietPhieuXuatXe);
			new CHITIETPHIEUXUATXE_DAO().Update(ChiTietPhieuXuatXe);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by its primary key.
		/// </summary>
		public void Delete(int MaPhieuXuatXe, int MaXe, string MaMau)
		{
			new CHITIETPHIEUXUATXE_DAO().Delete(MaPhieuXuatXe, MaXe, MaMau);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			new CHITIETPHIEUXUATXE_DAO().DeleteAllByMaMau(MaMau);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaPhieuXuatXe(int MaPhieuXuatXe)
		{
			new CHITIETPHIEUXUATXE_DAO().DeleteAllByMaPhieuXuatXe(MaPhieuXuatXe);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			new CHITIETPHIEUXUATXE_DAO().DeleteAllByMaXe(MaXe);
		}

		/// <summary>
		/// Selects a single record from the CHI_TIET_PHIEU_XUAT_XE table.
		/// </summary>
		public CHITIETPHIEUXUATXE_DTO Select(int MaPhieuXuatXe, int MaXe, string MaMau)
		{
			return new CHITIETPHIEUXUATXE_DAO().Select(MaPhieuXuatXe, MaXe, MaMau);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAll()
		{
			return new CHITIETPHIEUXUATXE_DAO().SelectAll();
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAllByMaMau(string MaMau)
		{
			return new CHITIETPHIEUXUATXE_DAO().SelectAllByMaMau(MaMau);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAllByMaPhieuXuatXe(int MaPhieuXuatXe)
		{
			return new CHITIETPHIEUXUATXE_DAO().SelectAllByMaPhieuXuatXe(MaPhieuXuatXe);
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAllByMaXe(int MaXe)
		{
			return new CHITIETPHIEUXUATXE_DAO().SelectAllByMaXe(MaXe);
		}


		#endregion
	}
}

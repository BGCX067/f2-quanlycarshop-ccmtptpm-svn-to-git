using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class PHIEUXUATXE_DAO: AbstractDAO
	{
		#region Constructors

		public PHIEUXUATXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the PHIEU_XUAT_XE table.
		/// </summary>
		public void Insert(PHIEUXUATXE_DTO PhieuXuatXe)
		{
			ValidationUtility.ValidateArgument("PhieuXuatXe", PhieuXuatXe);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@NGAY_XUAT", PhieuXuatXe.NgayXuat),
				new SqlParameter("@MA_NHAN_VIEN", PhieuXuatXe.MaNhanVien),
				new SqlParameter("@TONG_SO_LUONG", PhieuXuatXe.TongSoLuong)
			};

            PhieuXuatXe.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuXuatXe_Insert", parameters);
        }

		/// <summary>
		/// Updates a record in the PHIEU_XUAT_XE table.
		/// </summary>
		public void Update(PHIEUXUATXE_DTO PhieuXuatXe)
		{
			ValidationUtility.ValidateArgument("PhieuXuatXe", PhieuXuatXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", PhieuXuatXe.Ma),
				new SqlParameter("@NGAY_XUAT", PhieuXuatXe.NgayXuat),
				new SqlParameter("@MA_NHAN_VIEN", PhieuXuatXe.MaNhanVien),
				new SqlParameter("@TONG_SO_LUONG", PhieuXuatXe.TongSoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuXuatXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_XUAT_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuXuatXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuXuatXeDeleteAllByMaNhanVien", parameters);
		}

		/// <summary>
		/// Selects a single record from the PHIEU_XUAT_XE table.
		/// </summary>
		public PHIEUXUATXE_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuXuatXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakePHIEUXUATXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the PHIEU_XUAT_XE table.
		/// </summary>
		public List<PHIEUXUATXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuXuatXe_SelectAll"))
			{
				List<PHIEUXUATXE_DTO> PhieuXuatXeList = new List<PHIEUXUATXE_DTO>();
				while (dataReader.Read())
				{
					PHIEUXUATXE_DTO PhieuXuatXe = MakePHIEUXUATXE_DTO(dataReader);
					PhieuXuatXeList.Add(PhieuXuatXe);
				}

				return PhieuXuatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<PHIEUXUATXE_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuXuatXeSelectAllByMaNhanVien", parameters))
			{
				List<PHIEUXUATXE_DTO> PhieuXuatXeList = new List<PHIEUXUATXE_DTO>();
				while (dataReader.Read())
				{
					PHIEUXUATXE_DTO PhieuXuatXe = MakePHIEUXUATXE_DTO(dataReader);
					PhieuXuatXeList.Add(PhieuXuatXe);
				}

				return PhieuXuatXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the PHIEU_XUAT_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private PHIEUXUATXE_DTO MakePHIEUXUATXE_DTO(SqlDataReader dataReader)
		{
			PHIEUXUATXE_DTO PhieuXuatXe = new PHIEUXUATXE_DTO();
			PhieuXuatXe.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			PhieuXuatXe.NgayXuat = SqlClientUtility.GetDateTime(dataReader, "NGAY_XUAT", DateTime.Now);
			PhieuXuatXe.MaNhanVien = SqlClientUtility.GetInt32(dataReader, "MA_NHAN_VIEN", 0);
			PhieuXuatXe.TongSoLuong = SqlClientUtility.GetInt32(dataReader, "TONG_SO_LUONG", 0);

			return PhieuXuatXe;
		}

		#endregion
	}
}

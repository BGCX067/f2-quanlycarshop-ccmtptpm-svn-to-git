using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class CHITIETPHIEUXUATXE_DAO: AbstractDAO
	{
		#region Constructors

		public CHITIETPHIEUXUATXE_DAO()
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

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_XUAT_XE", ChiTietPhieuXuatXe.MaPhieuXuatXe),
				new SqlParameter("@MA_XE", ChiTietPhieuXuatXe.MaXe),
				new SqlParameter("@MA_MAU", ChiTietPhieuXuatXe.MaMau),
				new SqlParameter("@SO_LUONG", ChiTietPhieuXuatXe.SoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXe_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the CHI_TIET_PHIEU_XUAT_XE table.
		/// </summary>
		public void Update(CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe)
		{
			ValidationUtility.ValidateArgument("ChiTietPhieuXuatXe", ChiTietPhieuXuatXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_XUAT_XE", ChiTietPhieuXuatXe.MaPhieuXuatXe),
				new SqlParameter("@MA_XE", ChiTietPhieuXuatXe.MaXe),
				new SqlParameter("@MA_MAU", ChiTietPhieuXuatXe.MaMau),
				new SqlParameter("@SO_LUONG", ChiTietPhieuXuatXe.SoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by its primary key.
		/// </summary>
		public void Delete(int MaPhieuXuatXe, int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_XUAT_XE", MaPhieuXuatXe),
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXeDeleteAllByMaMau", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaPhieuXuatXe(int MaPhieuXuatXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_XUAT_XE", MaPhieuXuatXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXeDeleteAllByMaPhieuXuatXe", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXeDeleteAllByMaXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the CHI_TIET_PHIEU_XUAT_XE table.
		/// </summary>
		public CHITIETPHIEUXUATXE_DTO Select(int MaPhieuXuatXe, int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_XUAT_XE", MaPhieuXuatXe),
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCHITIETPHIEUXUATXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXe_SelectAll"))
			{
				List<CHITIETPHIEUXUATXE_DTO> ChiTietPhieuXuatXeList = new List<CHITIETPHIEUXUATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe = MakeCHITIETPHIEUXUATXE_DTO(dataReader);
					ChiTietPhieuXuatXeList.Add(ChiTietPhieuXuatXe);
				}

				return ChiTietPhieuXuatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXeSelectAllByMaMau", parameters))
			{
				List<CHITIETPHIEUXUATXE_DTO> ChiTietPhieuXuatXeList = new List<CHITIETPHIEUXUATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe = MakeCHITIETPHIEUXUATXE_DTO(dataReader);
					ChiTietPhieuXuatXeList.Add(ChiTietPhieuXuatXe);
				}

				return ChiTietPhieuXuatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAllByMaPhieuXuatXe(int MaPhieuXuatXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_XUAT_XE", MaPhieuXuatXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXeSelectAllByMaPhieuXuatXe", parameters))
			{
				List<CHITIETPHIEUXUATXE_DTO> ChiTietPhieuXuatXeList = new List<CHITIETPHIEUXUATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe = MakeCHITIETPHIEUXUATXE_DTO(dataReader);
					ChiTietPhieuXuatXeList.Add(ChiTietPhieuXuatXe);
				}

				return ChiTietPhieuXuatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_XUAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUXUATXE_DTO> SelectAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuXuatXeSelectAllByMaXe", parameters))
			{
				List<CHITIETPHIEUXUATXE_DTO> ChiTietPhieuXuatXeList = new List<CHITIETPHIEUXUATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe = MakeCHITIETPHIEUXUATXE_DTO(dataReader);
					ChiTietPhieuXuatXeList.Add(ChiTietPhieuXuatXe);
				}

				return ChiTietPhieuXuatXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the CHI_TIET_PHIEU_XUAT_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private CHITIETPHIEUXUATXE_DTO MakeCHITIETPHIEUXUATXE_DTO(SqlDataReader dataReader)
		{
			CHITIETPHIEUXUATXE_DTO ChiTietPhieuXuatXe = new CHITIETPHIEUXUATXE_DTO();
			ChiTietPhieuXuatXe.MaPhieuXuatXe = SqlClientUtility.GetInt32(dataReader, "MA_PHIEU_XUAT_XE", 0);
			ChiTietPhieuXuatXe.MaXe = SqlClientUtility.GetInt32(dataReader, "MA_XE", 0);
			ChiTietPhieuXuatXe.MaMau = SqlClientUtility.GetString(dataReader, "MA_MAU", String.Empty);
			ChiTietPhieuXuatXe.SoLuong = SqlClientUtility.GetInt32(dataReader, "SO_LUONG", 0);

			return ChiTietPhieuXuatXe;
		}

		#endregion
	}
}

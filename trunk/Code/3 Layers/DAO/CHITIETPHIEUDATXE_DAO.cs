using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class CHITIETPHIEUDATXE_DAO: AbstractDAO
	{
		#region Constructors

		public CHITIETPHIEUDATXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public void Insert(CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe)
		{
			ValidationUtility.ValidateArgument("ChiTietPhieuDatXe", ChiTietPhieuDatXe);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_DAT", ChiTietPhieuDatXe.MaPhieuDat),
				new SqlParameter("@MA_XE", ChiTietPhieuDatXe.MaXe),
				new SqlParameter("@MA_MAU", ChiTietPhieuDatXe.MaMau),
				new SqlParameter("@SO_LUONG", ChiTietPhieuDatXe.SoLuong),
				new SqlParameter("@TONG_TIEN", ChiTietPhieuDatXe.TongTien)
			};

            ChiTietPhieuDatXe.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXe_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public void Update(CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe)
		{
			ValidationUtility.ValidateArgument("ChiTietPhieuDatXe", ChiTietPhieuDatXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", ChiTietPhieuDatXe.Ma),
				new SqlParameter("@MA_PHIEU_DAT", ChiTietPhieuDatXe.MaPhieuDat),
				new SqlParameter("@MA_XE", ChiTietPhieuDatXe.MaXe),
				new SqlParameter("@MA_MAU", ChiTietPhieuDatXe.MaMau),
				new SqlParameter("@SO_LUONG", ChiTietPhieuDatXe.SoLuong),
				new SqlParameter("@TONG_TIEN", ChiTietPhieuDatXe.TongTien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXeDeleteAllByMaMau", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaPhieuDat(int MaPhieuDat)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_DAT", MaPhieuDat)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXeDeleteAllByMaPhieuDat", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXeDeleteAllByMaXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public CHITIETPHIEUDATXE_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCHITIETPHIEUDATXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXe_SelectAll"))
			{
				List<CHITIETPHIEUDATXE_DTO> ChiTietPhieuDatXeList = new List<CHITIETPHIEUDATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe = MakeCHITIETPHIEUDATXE_DTO(dataReader);
					ChiTietPhieuDatXeList.Add(ChiTietPhieuDatXe);
				}

				return ChiTietPhieuDatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXeSelectAllByMaMau", parameters))
			{
				List<CHITIETPHIEUDATXE_DTO> ChiTietPhieuDatXeList = new List<CHITIETPHIEUDATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe = MakeCHITIETPHIEUDATXE_DTO(dataReader);
					ChiTietPhieuDatXeList.Add(ChiTietPhieuDatXe);
				}

				return ChiTietPhieuDatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAllByMaPhieuDat(int MaPhieuDat)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_DAT", MaPhieuDat)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXeSelectAllByMaPhieuDat", parameters))
			{
				List<CHITIETPHIEUDATXE_DTO> ChiTietPhieuDatXeList = new List<CHITIETPHIEUDATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe = MakeCHITIETPHIEUDATXE_DTO(dataReader);
					ChiTietPhieuDatXeList.Add(ChiTietPhieuDatXe);
				}

				return ChiTietPhieuDatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<CHITIETPHIEUDATXE_DTO> SelectAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietPhieuDatXeSelectAllByMaXe", parameters))
			{
				List<CHITIETPHIEUDATXE_DTO> ChiTietPhieuDatXeList = new List<CHITIETPHIEUDATXE_DTO>();
				while (dataReader.Read())
				{
					CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe = MakeCHITIETPHIEUDATXE_DTO(dataReader);
					ChiTietPhieuDatXeList.Add(ChiTietPhieuDatXe);
				}

				return ChiTietPhieuDatXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the CHI_TIET_PHIEU_DAT_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private CHITIETPHIEUDATXE_DTO MakeCHITIETPHIEUDATXE_DTO(SqlDataReader dataReader)
		{
			CHITIETPHIEUDATXE_DTO ChiTietPhieuDatXe = new CHITIETPHIEUDATXE_DTO();
			ChiTietPhieuDatXe.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			ChiTietPhieuDatXe.MaPhieuDat = SqlClientUtility.GetInt32(dataReader, "MA_PHIEU_DAT", 0);
			ChiTietPhieuDatXe.MaXe = SqlClientUtility.GetInt32(dataReader, "MA_XE", 0);
			ChiTietPhieuDatXe.MaMau = SqlClientUtility.GetString(dataReader, "MA_MAU", String.Empty);
			ChiTietPhieuDatXe.SoLuong = SqlClientUtility.GetInt32(dataReader, "SO_LUONG", 0);
			ChiTietPhieuDatXe.TongTien = SqlClientUtility.GetDecimal(dataReader, "TONG_TIEN", Decimal.Zero);

			return ChiTietPhieuDatXe;
		}

		#endregion
	}
}

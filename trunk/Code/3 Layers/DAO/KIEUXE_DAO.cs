using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class KIEUXE_DAO: AbstractDAO
	{
		#region Constructors

		public KIEUXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the KIEU_XE table.
		/// </summary>
		public void Insert(KIEUXE_DTO KieuXe)
		{
			ValidationUtility.ValidateArgument("KieuXe", KieuXe);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_LOAI_XE", KieuXe.MaLoaiXe),
				new SqlParameter("@TEN_KIEU_XE", KieuXe.TenKieuXe)
			};

            KieuXe.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_KieuXe_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the KIEU_XE table.
		/// </summary>
		public void Update(KIEUXE_DTO KieuXe)
		{
			ValidationUtility.ValidateArgument("KieuXe", KieuXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", KieuXe.Ma),
				new SqlParameter("@MA_LOAI_XE", KieuXe.MaLoaiXe),
				new SqlParameter("@TEN_KIEU_XE", KieuXe.TenKieuXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_KieuXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the KIEU_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_KieuXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the KIEU_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaLoaiXe(int MaLoaiXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_LOAI_XE", MaLoaiXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_KieuXeDeleteAllByMaLoaiXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the KIEU_XE table.
		/// </summary>
		public KIEUXE_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_KieuXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeKIEUXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the KIEU_XE table.
		/// </summary>
		public List<KIEUXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_KieuXe_SelectAll"))
			{
				List<KIEUXE_DTO> KieuXeList = new List<KIEUXE_DTO>();
				while (dataReader.Read())
				{
					KIEUXE_DTO KieuXe = MakeKIEUXE_DTO(dataReader);
					KieuXeList.Add(KieuXe);
				}

				return KieuXeList;
			}
		}

		/// <summary>
		/// Selects all records from the KIEU_XE table by a foreign key.
		/// </summary>
		public List<KIEUXE_DTO> SelectAllByMaLoaiXe(int MaLoaiXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_LOAI_XE", MaLoaiXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_KieuXeSelectAllByMaLoaiXe", parameters))
			{
				List<KIEUXE_DTO> KieuXeList = new List<KIEUXE_DTO>();
				while (dataReader.Read())
				{
					KIEUXE_DTO KieuXe = MakeKIEUXE_DTO(dataReader);
					KieuXeList.Add(KieuXe);
				}

				return KieuXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the KIEU_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private KIEUXE_DTO MakeKIEUXE_DTO(SqlDataReader dataReader)
		{
			KIEUXE_DTO KieuXe = new KIEUXE_DTO();
			KieuXe.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			KieuXe.MaLoaiXe = SqlClientUtility.GetInt32(dataReader, "MA_LOAI_XE", 0);
			KieuXe.TenKieuXe = SqlClientUtility.GetString(dataReader, "TEN_KIEU_XE", String.Empty);

			return KieuXe;
		}

		#endregion
	}
}

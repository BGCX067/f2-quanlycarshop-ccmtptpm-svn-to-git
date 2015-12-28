using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class LOAIXE_DAO: AbstractDAO
	{
		#region Constructors

		public LOAIXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the LOAI_XE table.
		/// </summary>
		public void Insert(LOAIXE_DTO LoaiXe)
		{
			ValidationUtility.ValidateArgument("LoaiXe", LoaiXe);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TEN_LOAI_XE", LoaiXe.TenLoaiXe),
				new SqlParameter("@GHI_CHU", LoaiXe.GhiChu)
			};

            LoaiXe.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiXe_Insert", parameters);
        }

		/// <summary>
		/// Updates a record in the LOAI_XE table.
		/// </summary>
		public void Update(LOAIXE_DTO LoaiXe)
		{
			ValidationUtility.ValidateArgument("LoaiXe", LoaiXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", LoaiXe.Ma),
				new SqlParameter("@TEN_LOAI_XE", LoaiXe.TenLoaiXe),
				new SqlParameter("@GHI_CHU", LoaiXe.GhiChu)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the LOAI_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiXe_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the LOAI_XE table.
		/// </summary>
		public LOAIXE_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeLOAIXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the LOAI_XE table.
		/// </summary>
		public List<LOAIXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiXe_SelectAll"))
			{
				List<LOAIXE_DTO> LoaiXeList = new List<LOAIXE_DTO>();
				while (dataReader.Read())
				{
					LOAIXE_DTO LoaiXe = MakeLOAIXE_DTO(dataReader);
					LoaiXeList.Add(LoaiXe);
				}

				return LoaiXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the LOAI_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private LOAIXE_DTO MakeLOAIXE_DTO(SqlDataReader dataReader)
		{
			LOAIXE_DTO LoaiXe = new LOAIXE_DTO();
			LoaiXe.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			LoaiXe.TenLoaiXe = SqlClientUtility.GetString(dataReader, "TEN_LOAI_XE", String.Empty);
			LoaiXe.GhiChu = SqlClientUtility.GetString(dataReader, "GHI_CHU", String.Empty);

			return LoaiXe;
		}

		#endregion
	}
}

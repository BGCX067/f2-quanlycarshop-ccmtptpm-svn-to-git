using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class MAUXE_DAO: AbstractDAO
	{
		#region Constructors

		public MAUXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the MAU_XE table.
		/// </summary>
		public void Insert(MAUXE_DTO MauXe)
		{
			ValidationUtility.ValidateArgument("MauXe", MauXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MauXe.MaXe),
				new SqlParameter("@MA_MAU", MauXe.MaMau),
				new SqlParameter("@SO_LUONG", MauXe.SoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXe_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the MAU_XE table.
		/// </summary>
		public void Update(MAUXE_DTO MauXe)
		{
			ValidationUtility.ValidateArgument("MauXe", MauXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MauXe.MaXe),
				new SqlParameter("@MA_MAU", MauXe.MaMau),
				new SqlParameter("@SO_LUONG", MauXe.SoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the MAU_XE table by its primary key.
		/// </summary>
		public void Delete(int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the MAU_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXeDeleteAllByMaMau", parameters);
		}

		/// <summary>
		/// Deletes a record from the MAU_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXeDeleteAllByMaXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the MAU_XE table.
		/// </summary>
		public MAUXE_DTO Select(int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeMAUXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the MAU_XE table.
		/// </summary>
		public List<MAUXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXe_SelectAll"))
			{
				List<MAUXE_DTO> MauXeList = new List<MAUXE_DTO>();
				while (dataReader.Read())
				{
					MAUXE_DTO MauXe = MakeMAUXE_DTO(dataReader);
					MauXeList.Add(MauXe);
				}

				return MauXeList;
			}
		}

		/// <summary>
		/// Selects all records from the MAU_XE table by a foreign key.
		/// </summary>
		public List<MAUXE_DTO> SelectAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXe_SelectAllByMaMau", parameters))
			{
				List<MAUXE_DTO> MauXeList = new List<MAUXE_DTO>();
				while (dataReader.Read())
				{
					MAUXE_DTO MauXe = MakeMAUXE_DTO(dataReader);
					MauXeList.Add(MauXe);
				}

				return MauXeList;
			}
		}

		/// <summary>
		/// Selects all records from the MAU_XE table by a foreign key.
		/// </summary>
		public List<MAUXE_DTO> SelectAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_MauXe_SelectAllByMa_Xe", parameters))
			{
				List<MAUXE_DTO> MauXeList = new List<MAUXE_DTO>();
				while (dataReader.Read())
				{
					MAUXE_DTO MauXe = MakeMAUXE_DTO(dataReader);
					MauXeList.Add(MauXe);
				}

				return MauXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the MAU_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private MAUXE_DTO MakeMAUXE_DTO(SqlDataReader dataReader)
		{
			MAUXE_DTO MauXe = new MAUXE_DTO();
			MauXe.MaXe = SqlClientUtility.GetInt32(dataReader, "MA_XE", 0);
			MauXe.MaMau = SqlClientUtility.GetString(dataReader, "MA_MAU", String.Empty);
            MauXe.Mau = SqlClientUtility.GetString(dataReader, "MAU", string.Empty);
			MauXe.SoLuong = SqlClientUtility.GetInt32(dataReader, "SO_LUONG", 0);

			return MauXe;
		}

		#endregion
	}
}

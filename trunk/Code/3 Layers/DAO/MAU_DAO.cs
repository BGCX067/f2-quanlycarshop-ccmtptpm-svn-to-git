using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class MAU_DAO: AbstractDAO
	{
		#region Constructors

		public MAU_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the MAU table.
		/// </summary>
		public void Insert(MAU_DTO Mau)
		{
			ValidationUtility.ValidateArgument("Mau", Mau);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Mau.Ma),
				new SqlParameter("@MAU", Mau.Mau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_Mau_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the MAU table.
		/// </summary>
		public void Update(MAU_DTO Mau)
		{
			ValidationUtility.ValidateArgument("Mau", Mau);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Mau.Ma),
				new SqlParameter("@MAU", Mau.Mau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_Mau_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the MAU table by its primary key.
		/// </summary>
		public void Delete(string Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_Mau_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the MAU table.
		/// </summary>
		public MAU_DTO Select(string Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_Mau_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeMAU_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the MAU table.
		/// </summary>
		public List<MAU_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_Mau_SelectAll"))
			{
				List<MAU_DTO> MauList = new List<MAU_DTO>();
				while (dataReader.Read())
				{
					MAU_DTO Mau = MakeMAU_DTO(dataReader);
					MauList.Add(Mau);
				}

				return MauList;
			}
		}

		/// <summary>
		/// Creates a new instance of the MAU class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private MAU_DTO MakeMAU_DTO(SqlDataReader dataReader)
		{
			MAU_DTO Mau = new MAU_DTO();
			Mau.Ma = SqlClientUtility.GetString(dataReader, "MA", String.Empty);
			Mau.Mau = SqlClientUtility.GetString(dataReader, "MAU", String.Empty);

			return Mau;
		}

		#endregion
	}
}

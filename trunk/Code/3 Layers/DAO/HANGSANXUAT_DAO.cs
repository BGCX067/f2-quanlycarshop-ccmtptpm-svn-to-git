using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class HANGSANXUAT_DAO: AbstractDAO
	{
		#region Constructors

		public HANGSANXUAT_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the HANG_SAN_XUAT table.
		/// </summary>
		public void Insert(HANGSANXUAT_DTO HangSanXuat)
		{
			ValidationUtility.ValidateArgument("HangSanXuat", HangSanXuat);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TEN_HANG_XE", HangSanXuat.TenHangXe)
			};

            HangSanXuat.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_HangSanXuat_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the HANG_SAN_XUAT table.
		/// </summary>
		public void Update(HANGSANXUAT_DTO HangSanXuat)
		{
			ValidationUtility.ValidateArgument("HangSanXuat", HangSanXuat);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", HangSanXuat.Ma),
				new SqlParameter("@TEN_HANG_XE", HangSanXuat.TenHangXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_HangSanXuat_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the HANG_SAN_XUAT table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_HangSanXuat_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the HANG_SAN_XUAT table.
		/// </summary>
		public HANGSANXUAT_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_HangSanXuat_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeHANGSANXUAT_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the HANG_SAN_XUAT table.
		/// </summary>
		public List<HANGSANXUAT_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_HangSanXuat_SelectAll"))
			{
				List<HANGSANXUAT_DTO> HangSanXuatList = new List<HANGSANXUAT_DTO>();
				while (dataReader.Read())
				{
					HANGSANXUAT_DTO HangSanXuat = MakeHANGSANXUAT_DTO(dataReader);
					HangSanXuatList.Add(HangSanXuat);
				}

				return HangSanXuatList;
			}
		}

		/// <summary>
		/// Creates a new instance of the HANG_SAN_XUAT class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private HANGSANXUAT_DTO MakeHANGSANXUAT_DTO(SqlDataReader dataReader)
		{
			HANGSANXUAT_DTO HangSanXuat = new HANGSANXUAT_DTO();
			HangSanXuat.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			HangSanXuat.TenHangXe = SqlClientUtility.GetString(dataReader, "TEN_HANG_XE", String.Empty);

			return HangSanXuat;
		}

		#endregion
	}
}

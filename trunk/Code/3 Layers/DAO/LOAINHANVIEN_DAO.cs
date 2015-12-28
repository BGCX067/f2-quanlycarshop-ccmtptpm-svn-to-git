using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class LOAINHANVIEN_DAO: AbstractDAO
	{
		#region Constructors

		public LOAINHANVIEN_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the LOAI_NHAN_VIEN table.
		/// </summary>
		public void Insert(LOAINHANVIEN_DTO LoaiNhanVien)
		{
			ValidationUtility.ValidateArgument("LoaiNhanVien", LoaiNhanVien);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", LoaiNhanVien.Ma),
				new SqlParameter("@TEN_LOAI_NHAN_VIEN", LoaiNhanVien.TenLoaiNhanVien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiNhanVien_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the LOAI_NHAN_VIEN table.
		/// </summary>
		public void Update(LOAINHANVIEN_DTO LoaiNhanVien)
		{
			ValidationUtility.ValidateArgument("LoaiNhanVien", LoaiNhanVien);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", LoaiNhanVien.Ma),
				new SqlParameter("@TEN_LOAI_NHAN_VIEN", LoaiNhanVien.TenLoaiNhanVien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiNhanVien_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the LOAI_NHAN_VIEN table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiNhanVien_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the LOAI_NHAN_VIEN table.
		/// </summary>
		public LOAINHANVIEN_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiNhanVien_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeLOAINHANVIEN_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the LOAI_NHAN_VIEN table.
		/// </summary>
		public List<LOAINHANVIEN_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_LoaiNhanVien_SelectAll"))
			{
				List<LOAINHANVIEN_DTO> LoaiNhanVienList = new List<LOAINHANVIEN_DTO>();
				while (dataReader.Read())
				{
					LOAINHANVIEN_DTO LoaiNhanVien = MakeLOAINHANVIEN_DTO(dataReader);
					LoaiNhanVienList.Add(LoaiNhanVien);
				}

				return LoaiNhanVienList;
			}
		}

		/// <summary>
		/// Creates a new instance of the LOAI_NHAN_VIEN class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private LOAINHANVIEN_DTO MakeLOAINHANVIEN_DTO(SqlDataReader dataReader)
		{
			LOAINHANVIEN_DTO LoaiNhanVien = new LOAINHANVIEN_DTO();
			LoaiNhanVien.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			LoaiNhanVien.TenLoaiNhanVien = SqlClientUtility.GetString(dataReader, "TEN_LOAI_NHAN_VIEN", String.Empty);

			return LoaiNhanVien;
		}

		#endregion
	}
}

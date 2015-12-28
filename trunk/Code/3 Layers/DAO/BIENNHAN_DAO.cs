using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class BIENNHAN_DAO: AbstractDAO
	{
		#region Constructors

		public BIENNHAN_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the BIEN_NHAN table.
		/// </summary>
		public void Insert(BIENNHAN_DTO BienNhan)
		{
			ValidationUtility.ValidateArgument("BienNhan", BienNhan);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", BienNhan.MaHoaDon),
				new SqlParameter("@NGAY_THANH_TOAN", BienNhan.NgayThanhToan),
				new SqlParameter("@MA_NHAN_VIEN", BienNhan.MaNhanVien),
				new SqlParameter("@SO_TIEN", BienNhan.SoTien)
			};

            BienNhan.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhan_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the BIEN_NHAN table.
		/// </summary>
		public void Update(BIENNHAN_DTO BienNhan)
		{
			ValidationUtility.ValidateArgument("BienNhan", BienNhan);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", BienNhan.Ma),
				new SqlParameter("@MA_HOA_DON", BienNhan.MaHoaDon),
				new SqlParameter("@NGAY_THANH_TOAN", BienNhan.NgayThanhToan),
				new SqlParameter("@MA_NHAN_VIEN", BienNhan.MaNhanVien),
				new SqlParameter("@SO_TIEN", BienNhan.SoTien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhan_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the BIEN_NHAN table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhan_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public void DeleteAllByMaHoaDon(int MaHoaDon)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", MaHoaDon)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhanDeleteAllByMaHoaDon", parameters);
		}

		/// <summary>
		/// Deletes a record from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhanDeleteAllByMaNhanVien", parameters);
		}

		/// <summary>
		/// Selects a single record from the BIEN_NHAN table.
		/// </summary>
		public BIENNHAN_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhan_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeBIENNHAN_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the BIEN_NHAN table.
		/// </summary>
		public List<BIENNHAN_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhan_SelectAll"))
			{
				List<BIENNHAN_DTO> BienNhanList = new List<BIENNHAN_DTO>();
				while (dataReader.Read())
				{
					BIENNHAN_DTO BienNhan = MakeBIENNHAN_DTO(dataReader);
					BienNhanList.Add(BienNhan);
				}

				return BienNhanList;
			}
		}

		/// <summary>
		/// Selects all records from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public List<BIENNHAN_DTO> SelectAllByMaHoaDon(int MaHoaDon)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", MaHoaDon)
			};

            using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_BIENNHAN_SelectAllByMA_HOA_DON", parameters))
			{
				List<BIENNHAN_DTO> BienNhanList = new List<BIENNHAN_DTO>();
				while (dataReader.Read())
				{
					BIENNHAN_DTO BienNhan = MakeBIENNHAN_DTO(dataReader);
					BienNhanList.Add(BienNhan);
				}

				return BienNhanList;
			}
		}

		/// <summary>
		/// Selects all records from the BIEN_NHAN table by a foreign key.
		/// </summary>
		public List<BIENNHAN_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_BienNhanSelectAllByMaNhanVien", parameters))
			{
				List<BIENNHAN_DTO> BienNhanList = new List<BIENNHAN_DTO>();
				while (dataReader.Read())
				{
					BIENNHAN_DTO BienNhan = MakeBIENNHAN_DTO(dataReader);
					BienNhanList.Add(BienNhan);
				}

				return BienNhanList;
			}
		}

		/// <summary>
		/// Creates a new instance of the BIEN_NHAN class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private BIENNHAN_DTO MakeBIENNHAN_DTO(SqlDataReader dataReader)
		{
			BIENNHAN_DTO BienNhan = new BIENNHAN_DTO();
			BienNhan.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			BienNhan.MaHoaDon = SqlClientUtility.GetInt32(dataReader, "MA_HOA_DON", 0);
			BienNhan.NgayThanhToan = SqlClientUtility.GetDateTime(dataReader, "NGAY_THANH_TOAN", DateTime.Now);
			BienNhan.MaNhanVien = SqlClientUtility.GetInt32(dataReader, "MA_NHAN_VIEN", 0);
			BienNhan.SoTien = SqlClientUtility.GetDecimal(dataReader, "SO_TIEN", Decimal.Zero);

			return BienNhan;
		}

		#endregion
	}
}

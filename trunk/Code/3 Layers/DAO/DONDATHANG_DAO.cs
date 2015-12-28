using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class DONDATHANG_DAO: AbstractDAO
	{
		#region Constructors

		public DONDATHANG_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the DON_DAT_HANG table.
		/// </summary>
		public void Insert(DONDATHANG_DTO DonDatHang)
		{
			ValidationUtility.ValidateArgument("DonDatHang", DonDatHang);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@NGAY_DAT", DonDatHang.NgayDat),
				new SqlParameter("@TONG_TIEN", DonDatHang.TongTien),
				new SqlParameter("@TONG_SO_LUONG", DonDatHang.TongSoLuong)
			};

            DonDatHang.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_DonDatHang_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the DON_DAT_HANG table.
		/// </summary>
		public void Update(DONDATHANG_DTO DonDatHang)
		{
			ValidationUtility.ValidateArgument("DonDatHang", DonDatHang);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", DonDatHang.Ma),
				new SqlParameter("@NGAY_DAT", DonDatHang.NgayDat),
				new SqlParameter("@TONG_TIEN", DonDatHang.TongTien),
				new SqlParameter("@TONG_SO_LUONG", DonDatHang.TongSoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_DonDatHang_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the DON_DAT_HANG table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_DonDatHang_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the DON_DAT_HANG table.
		/// </summary>
		public DONDATHANG_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_DonDatHang_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeDONDATHANG_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the DON_DAT_HANG table.
		/// </summary>
		public List<DONDATHANG_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_DonDatHang_SelectAll"))
			{
				List<DONDATHANG_DTO> DonDatHangList = new List<DONDATHANG_DTO>();
				while (dataReader.Read())
				{
					DONDATHANG_DTO DonDatHang = MakeDONDATHANG_DTO(dataReader);
					DonDatHangList.Add(DonDatHang);
				}

				return DonDatHangList;
			}
		}

		/// <summary>
		/// Creates a new instance of the DON_DAT_HANG class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private DONDATHANG_DTO MakeDONDATHANG_DTO(SqlDataReader dataReader)
		{
			DONDATHANG_DTO DonDatHang = new DONDATHANG_DTO();
			DonDatHang.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			DonDatHang.NgayDat = SqlClientUtility.GetDateTime(dataReader, "NGAY_DAT", DateTime.Now);
			DonDatHang.TongTien = SqlClientUtility.GetDecimal(dataReader, "TONG_TIEN", Decimal.Zero);
			DonDatHang.TongSoLuong = SqlClientUtility.GetInt32(dataReader, "TONG_SO_LUONG", 0);

			return DonDatHang;
		}

		#endregion
	}
}

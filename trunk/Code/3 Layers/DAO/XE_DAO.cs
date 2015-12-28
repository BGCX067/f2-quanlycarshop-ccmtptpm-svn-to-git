using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class XE_DAO: AbstractDAO
	{
		#region Constructors

		public XE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the XE table.
		/// </summary>
		public void Insert(XE_DTO Xe)
		{
			ValidationUtility.ValidateArgument("Xe", Xe);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TEN_XE", Xe.TenXe),
				new SqlParameter("@MA_KIEU_XE", Xe.MaKieuXe),
				new SqlParameter("@MA_HANG_XE", Xe.MaHangXe),
				new SqlParameter("@DOI_XE", Xe.DoiXe),
				new SqlParameter("@CHI_SO_NHIEN_LIEU", Xe.ChiSoNhienLieu),
				new SqlParameter("@MAX_SPEED", Xe.MaxSpeed),
				new SqlParameter("@LOAI_DIA_HINH", Xe.LoaiDiaHinh),
				new SqlParameter("@SO_CHO_NGOI", Xe.SoChoNgoi),
				new SqlParameter("@GIA_TIEN_BAN", Xe.GiaTienBan),
                new SqlParameter("@GIA_TIEN_MUA", Xe.GiaTienMua),
				new SqlParameter("@SO_LUONG", Xe.SoLuong)
			};

            Xe.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_Xe_Insert", parameters);
        }

		/// <summary>
		/// Updates a record in the XE table.
		/// </summary>
		public void Update(XE_DTO Xe)
		{
			ValidationUtility.ValidateArgument("Xe", Xe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Xe.Ma),
				new SqlParameter("@TEN_XE", Xe.TenXe),
				new SqlParameter("@MA_KIEU_XE", Xe.MaKieuXe),
				new SqlParameter("@MA_HANG_XE", Xe.MaHangXe),
				new SqlParameter("@DOI_XE", Xe.DoiXe),
				new SqlParameter("@CHI_SO_NHIEN_LIEU", Xe.ChiSoNhienLieu),
				new SqlParameter("@MAX_SPEED", Xe.MaxSpeed),
				new SqlParameter("@LOAI_DIA_HINH", Xe.LoaiDiaHinh),
				new SqlParameter("@SO_CHO_NGOI", Xe.SoChoNgoi),
				new SqlParameter("@GIA_TIEN_BAN", Xe.GiaTienBan),
                new SqlParameter("@GIA_TIEN_MUA", Xe.GiaTienMua),
				new SqlParameter("@SO_LUONG", Xe.SoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_Xe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_Xe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaHangXe(int MaHangXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HANG_XE", MaHangXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_XeDeleteAllByMaHangXe", parameters);
		}

		/// <summary>
		/// Deletes a record from the XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaKieuXe(int MaKieuXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KIEU_XE", MaKieuXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_XeDeleteAllByMaKieuXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the XE table.
		/// </summary>
		public XE_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_Xe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

        public XE_DTO SelectByTenXe(string TenXe)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TEN_XE", TenXe)
			};

            using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_Xe_SelectByTenXe", parameters))
            {
                if (dataReader.Read())
                {
                    return MakeXE_DTO(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

		/// <summary>
		/// Selects all records from the XE table.
		/// </summary>
		public List<XE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_Xe_SelectAll"))
			{
				List<XE_DTO> XeList = new List<XE_DTO>();
				while (dataReader.Read())
				{
					XE_DTO Xe = MakeXE_DTO(dataReader);
					XeList.Add(Xe);
				}

				return XeList;
			}
		}

		/// <summary>
		/// Selects all records from the XE table by a foreign key.
		/// </summary>
		public List<XE_DTO> SelectAllByMaHangXe(int MaHangXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HANG_XE", MaHangXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_XeSelectAllByMaHangXe", parameters))
			{
				List<XE_DTO> XeList = new List<XE_DTO>();
				while (dataReader.Read())
				{
					XE_DTO Xe = MakeXE_DTO(dataReader);
					XeList.Add(Xe);
				}

				return XeList;
			}
		}

		/// <summary>
		/// Selects all records from the XE table by a foreign key.
		/// </summary>
		public List<XE_DTO> SelectAllByMaKieuXe(int MaKieuXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KIEU_XE", MaKieuXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_XeSelectAllByMaKieuXe", parameters))
			{
				List<XE_DTO> XeList = new List<XE_DTO>();
				while (dataReader.Read())
				{
					XE_DTO Xe = MakeXE_DTO(dataReader);
					XeList.Add(Xe);
				}

				return XeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private XE_DTO MakeXE_DTO(SqlDataReader dataReader)
		{
			XE_DTO Xe = new XE_DTO();
			Xe.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			Xe.TenXe = SqlClientUtility.GetString(dataReader, "TEN_XE", String.Empty);
			Xe.MaKieuXe = SqlClientUtility.GetInt32(dataReader, "MA_KIEU_XE", 0);
			Xe.MaHangXe = SqlClientUtility.GetInt32(dataReader, "MA_HANG_XE", 0);
            Xe.TenHangXe = SqlClientUtility.GetString(dataReader, "TEN_HANG_XE", String.Empty);
			Xe.DoiXe = SqlClientUtility.GetInt32(dataReader, "DOI_XE", 0);
            Xe.TenKieuXe = SqlClientUtility.GetString(dataReader, "TEN_KIEU_XE", String.Empty);
			Xe.ChiSoNhienLieu = SqlClientUtility.GetDecimal(dataReader, "CHI_SO_NHIEN_LIEU", Decimal.Zero);
			Xe.MaxSpeed = SqlClientUtility.GetInt32(dataReader, "MAX_SPEED", 0);
			Xe.LoaiDiaHinh = SqlClientUtility.GetString(dataReader, "LOAI_DIA_HINH", String.Empty);
			Xe.SoChoNgoi = SqlClientUtility.GetInt32(dataReader, "SO_CHO_NGOI", 0);
			Xe.GiaTienBan = SqlClientUtility.GetDecimal(dataReader, "GIA_TIEN_BAN", Decimal.Zero);
            Xe.GiaTienMua = SqlClientUtility.GetDecimal(dataReader, "GIA_TIEN_MUA", Decimal.Zero);
			Xe.SoLuong = SqlClientUtility.GetInt32(dataReader, "SO_LUONG", 0);

			return Xe;
		}

		#endregion
	}
}

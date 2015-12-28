using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class CTDONDATHANG_DAO: AbstractDAO
	{
		#region Constructors

		public CTDONDATHANG_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CT_DON_DAT_HANG table.
		/// </summary>
		public void Insert(CTDONDATHANG_DTO CtDonDatHang)
		{
			ValidationUtility.ValidateArgument("CtDonDatHang", CtDonDatHang);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", CtDonDatHang.MaDonDatHang),
				new SqlParameter("@MA_XE", CtDonDatHang.MaXe),
				new SqlParameter("@MA_MAU", CtDonDatHang.MaMau),
				new SqlParameter("@SO_LUONG", CtDonDatHang.SoLuong),
				new SqlParameter("@TONG_TIEN", CtDonDatHang.TongTien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHang_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the CT_DON_DAT_HANG table.
		/// </summary>
		public void Update(CTDONDATHANG_DTO CtDonDatHang)
		{
			ValidationUtility.ValidateArgument("CtDonDatHang", CtDonDatHang);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", CtDonDatHang.MaDonDatHang),
				new SqlParameter("@MA_XE", CtDonDatHang.MaXe),
				new SqlParameter("@MA_MAU", CtDonDatHang.MaMau),
				new SqlParameter("@SO_LUONG", CtDonDatHang.SoLuong),
				new SqlParameter("@TONG_TIEN", CtDonDatHang.TongTien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHang_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by its primary key.
		/// </summary>
		public void Delete(int MaDonDatHang, int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", MaDonDatHang),
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHang_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public void DeleteAllByMaDonDatHang(int MaDonDatHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", MaDonDatHang)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHangDeleteAllByMaDonDatHang", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHangDeleteAllByMaMau", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHangDeleteAllByMaXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the CT_DON_DAT_HANG table.
		/// </summary>
		public CTDONDATHANG_DTO Select(int MaDonDatHang, int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", MaDonDatHang),
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHang_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCTDONDATHANG_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHang_SelectAll"))
			{
				List<CTDONDATHANG_DTO> CtDonDatHangList = new List<CTDONDATHANG_DTO>();
				while (dataReader.Read())
				{
					CTDONDATHANG_DTO CtDonDatHang = MakeCTDONDATHANG_DTO(dataReader);
					CtDonDatHangList.Add(CtDonDatHang);
				}

				return CtDonDatHangList;
			}
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAllByMaDonDatHang(int MaDonDatHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", MaDonDatHang)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHangSelectAllByMaDonDatHang", parameters))
			{
				List<CTDONDATHANG_DTO> CtDonDatHangList = new List<CTDONDATHANG_DTO>();
				while (dataReader.Read())
				{
					CTDONDATHANG_DTO CtDonDatHang = MakeCTDONDATHANG_DTO(dataReader);
					CtDonDatHangList.Add(CtDonDatHang);
				}

				return CtDonDatHangList;
			}
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHangSelectAllByMaMau", parameters))
			{
				List<CTDONDATHANG_DTO> CtDonDatHangList = new List<CTDONDATHANG_DTO>();
				while (dataReader.Read())
				{
					CTDONDATHANG_DTO CtDonDatHang = MakeCTDONDATHANG_DTO(dataReader);
					CtDonDatHangList.Add(CtDonDatHang);
				}

				return CtDonDatHangList;
			}
		}

		/// <summary>
		/// Selects all records from the CT_DON_DAT_HANG table by a foreign key.
		/// </summary>
		public List<CTDONDATHANG_DTO> SelectAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtDonDatHangSelectAllByMaXe", parameters))
			{
				List<CTDONDATHANG_DTO> CtDonDatHangList = new List<CTDONDATHANG_DTO>();
				while (dataReader.Read())
				{
					CTDONDATHANG_DTO CtDonDatHang = MakeCTDONDATHANG_DTO(dataReader);
					CtDonDatHangList.Add(CtDonDatHang);
				}

				return CtDonDatHangList;
			}
		}

		/// <summary>
		/// Creates a new instance of the CT_DON_DAT_HANG class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private CTDONDATHANG_DTO MakeCTDONDATHANG_DTO(SqlDataReader dataReader)
		{
			CTDONDATHANG_DTO CtDonDatHang = new CTDONDATHANG_DTO();
			CtDonDatHang.MaDonDatHang = SqlClientUtility.GetInt32(dataReader, "MA_DON_DAT_HANG", 0);
			CtDonDatHang.MaXe = SqlClientUtility.GetInt32(dataReader, "MA_XE", 0);
			CtDonDatHang.MaMau = SqlClientUtility.GetString(dataReader, "MA_MAU", String.Empty);
			CtDonDatHang.SoLuong = SqlClientUtility.GetInt32(dataReader, "SO_LUONG", 0);
			CtDonDatHang.TongTien = SqlClientUtility.GetDecimal(dataReader, "TONG_TIEN", Decimal.Zero);

			return CtDonDatHang;
		}

		#endregion
	}
}

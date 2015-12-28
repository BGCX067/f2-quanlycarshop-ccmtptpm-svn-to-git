using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class CHITIETHOADON_DAO: AbstractDAO
	{
		#region Constructors

		public CHITIETHOADON_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CHI_TIET_HOA_DON table.
		/// </summary>
		public void Insert(CHITIETHOADON_DTO ChiTietHoaDon)
		{
			ValidationUtility.ValidateArgument("ChiTietHoaDon", ChiTietHoaDon);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", ChiTietHoaDon.MaHoaDon),
				new SqlParameter("@MA_XE", ChiTietHoaDon.MaXe),
				new SqlParameter("@MA_MAU", ChiTietHoaDon.MaMau),
				new SqlParameter("@SO_LUONG", ChiTietHoaDon.SoLuong),
				new SqlParameter("@THANH_TIEN", ChiTietHoaDon.ThanhTien)
			};

			ChiTietHoaDon.Ma = (int) SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDon_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the CHI_TIET_HOA_DON table.
		/// </summary>
		public void Update(CHITIETHOADON_DTO ChiTietHoaDon)
		{
			ValidationUtility.ValidateArgument("ChiTietHoaDon", ChiTietHoaDon);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", ChiTietHoaDon.Ma),
				new SqlParameter("@MA_HOA_DON", ChiTietHoaDon.MaHoaDon),
				new SqlParameter("@MA_XE", ChiTietHoaDon.MaXe),
				new SqlParameter("@MA_MAU", ChiTietHoaDon.MaMau),
				new SqlParameter("@SO_LUONG", ChiTietHoaDon.SoLuong),
				new SqlParameter("@THANH_TIEN", ChiTietHoaDon.ThanhTien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDon_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_HOA_DON table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDon_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaHoaDon(int MaHoaDon)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", MaHoaDon)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDonDeleteAllByMaHoaDon", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDonDeleteAllByMaMau", parameters);
		}

		/// <summary>
		/// Deletes a record from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDonDeleteAllByMaXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the CHI_TIET_HOA_DON table.
		/// </summary>
		public CHITIETHOADON_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDon_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCHITIETHOADON_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_HOA_DON table.
		/// </summary>
		public List<CHITIETHOADON_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDon_SelectAll"))
			{
				List<CHITIETHOADON_DTO> ChiTietHoaDonList = new List<CHITIETHOADON_DTO>();
				while (dataReader.Read())
				{
					CHITIETHOADON_DTO ChiTietHoaDon = MakeCHITIETHOADON_DTO(dataReader);
					ChiTietHoaDonList.Add(ChiTietHoaDon);
				}

				return ChiTietHoaDonList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public List<CHITIETHOADON_DTO> SelectAllByMaHoaDon(int MaHoaDon)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", MaHoaDon)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDonSelectAllByMaHoaDon", parameters))
			{
				List<CHITIETHOADON_DTO> ChiTietHoaDonList = new List<CHITIETHOADON_DTO>();
				while (dataReader.Read())
				{
					CHITIETHOADON_DTO ChiTietHoaDon = MakeCHITIETHOADON_DTO(dataReader);
					ChiTietHoaDonList.Add(ChiTietHoaDon);
				}

				return ChiTietHoaDonList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public List<CHITIETHOADON_DTO> SelectAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDonSelectAllByMaMau", parameters))
			{
				List<CHITIETHOADON_DTO> ChiTietHoaDonList = new List<CHITIETHOADON_DTO>();
				while (dataReader.Read())
				{
					CHITIETHOADON_DTO ChiTietHoaDon = MakeCHITIETHOADON_DTO(dataReader);
					ChiTietHoaDonList.Add(ChiTietHoaDon);
				}

				return ChiTietHoaDonList;
			}
		}

		/// <summary>
		/// Selects all records from the CHI_TIET_HOA_DON table by a foreign key.
		/// </summary>
		public List<CHITIETHOADON_DTO> SelectAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_ChiTietHoaDonSelectAllByMaXe", parameters))
			{
				List<CHITIETHOADON_DTO> ChiTietHoaDonList = new List<CHITIETHOADON_DTO>();
				while (dataReader.Read())
				{
					CHITIETHOADON_DTO ChiTietHoaDon = MakeCHITIETHOADON_DTO(dataReader);
					ChiTietHoaDonList.Add(ChiTietHoaDon);
				}

				return ChiTietHoaDonList;
			}
		}

		/// <summary>
		/// Creates a new instance of the CHI_TIET_HOA_DON class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private CHITIETHOADON_DTO MakeCHITIETHOADON_DTO(SqlDataReader dataReader)
		{
			CHITIETHOADON_DTO ChiTietHoaDon = new CHITIETHOADON_DTO();
			ChiTietHoaDon.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			ChiTietHoaDon.MaHoaDon = SqlClientUtility.GetInt32(dataReader, "MA_HOA_DON", 0);
			ChiTietHoaDon.MaXe = SqlClientUtility.GetInt32(dataReader, "MA_XE", 0);
			ChiTietHoaDon.MaMau = SqlClientUtility.GetString(dataReader, "MA_MAU", String.Empty);
			ChiTietHoaDon.SoLuong = SqlClientUtility.GetInt32(dataReader, "SO_LUONG", 0);
			ChiTietHoaDon.ThanhTien = SqlClientUtility.GetDecimal(dataReader, "THANH_TIEN", Decimal.Zero);

			return ChiTietHoaDon;
		}

		#endregion
	}
}

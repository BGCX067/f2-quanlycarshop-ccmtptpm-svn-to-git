using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class HOADON_DAO: AbstractDAO
	{
		#region Constructors

		public HOADON_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the HOA_DON table.
		/// </summary>
		public void Insert(HOADON_DTO HoaDon)
		{
			ValidationUtility.ValidateArgument("HoaDon", HoaDon);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KHACH_HANG", HoaDon.MaKhachHang),
				new SqlParameter("@MA_NHAN_VIEN", HoaDon.MaNhanVien),
				new SqlParameter("@NGAY_LAP", HoaDon.NgayLap),
				new SqlParameter("@KIEU_THANH_TOAN", HoaDon.KieuThanhToan),
				new SqlParameter("@TONG_TIEN", HoaDon.TongTien),
				new SqlParameter("@TIEN_TRA_MOI_DOT", HoaDon.TienTraMoiDot),
				new SqlParameter("@SO_LAN_TRA", HoaDon.SoLanTra)
			};

			HoaDon.Ma = (int) SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDon_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the HOA_DON table.
		/// </summary>
		public void Update(HOADON_DTO HoaDon)
		{
			ValidationUtility.ValidateArgument("HoaDon", HoaDon);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", HoaDon.Ma),
				new SqlParameter("@MA_KHACH_HANG", HoaDon.MaKhachHang),
				new SqlParameter("@MA_NHAN_VIEN", HoaDon.MaNhanVien),
				new SqlParameter("@NGAY_LAP", HoaDon.NgayLap),
				new SqlParameter("@KIEU_THANH_TOAN", HoaDon.KieuThanhToan),
				new SqlParameter("@TONG_TIEN", HoaDon.TongTien),
				new SqlParameter("@TIEN_TRA_MOI_DOT", HoaDon.TienTraMoiDot),
				new SqlParameter("@SO_LAN_TRA", HoaDon.SoLanTra)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDon_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the HOA_DON table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDon_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaKhachHang(int MaKhachHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KHACH_HANG", MaKhachHang)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDonDeleteAllByMaKhachHang", parameters);
		}

		/// <summary>
		/// Deletes a record from the HOA_DON table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDonDeleteAllByMaNhanVien", parameters);
		}

		/// <summary>
		/// Selects a single record from the HOA_DON table.
		/// </summary>
		public HOADON_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDon_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeHOADON_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the HOA_DON table.
		/// </summary>
		public List<HOADON_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDon_SelectAll"))
			{
				List<HOADON_DTO> HoaDonList = new List<HOADON_DTO>();
				while (dataReader.Read())
				{
					HOADON_DTO HoaDon = MakeHOADON_DTO(dataReader);
					HoaDonList.Add(HoaDon);
				}

				return HoaDonList;
			}
		}

		/// <summary>
		/// Selects all records from the HOA_DON table by a foreign key.
		/// </summary>
		public List<HOADON_DTO> SelectAllByMaKhachHang(int MaKhachHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KHACH_HANG", MaKhachHang)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDonSelectAllByMaKhachHang", parameters))
			{
				List<HOADON_DTO> HoaDonList = new List<HOADON_DTO>();
				while (dataReader.Read())
				{
					HOADON_DTO HoaDon = MakeHOADON_DTO(dataReader);
					HoaDonList.Add(HoaDon);
				}

				return HoaDonList;
			}
		}

		/// <summary>
		/// Selects all records from the HOA_DON table by a foreign key.
		/// </summary>
		public List<HOADON_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_HoaDonSelectAllByMaNhanVien", parameters))
			{
				List<HOADON_DTO> HoaDonList = new List<HOADON_DTO>();
				while (dataReader.Read())
				{
					HOADON_DTO HoaDon = MakeHOADON_DTO(dataReader);
					HoaDonList.Add(HoaDon);
				}

				return HoaDonList;
			}
		}

		/// <summary>
		/// Creates a new instance of the HOA_DON class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private HOADON_DTO MakeHOADON_DTO(SqlDataReader dataReader)
		{
			HOADON_DTO HoaDon = new HOADON_DTO();
			HoaDon.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			HoaDon.MaKhachHang = SqlClientUtility.GetInt32(dataReader, "MA_KHACH_HANG", 0);
			HoaDon.MaNhanVien = SqlClientUtility.GetInt32(dataReader, "MA_NHAN_VIEN", 0);
			HoaDon.NgayLap = SqlClientUtility.GetDateTime(dataReader, "NGAY_LAP", DateTime.Now);
			HoaDon.KieuThanhToan = SqlClientUtility.GetBoolean(dataReader, "KIEU_THANH_TOAN", false);
			HoaDon.TongTien = SqlClientUtility.GetDecimal(dataReader, "TONG_TIEN", Decimal.Zero);
			HoaDon.TienTraMoiDot = SqlClientUtility.GetDecimal(dataReader, "TIEN_TRA_MOI_DOT", Decimal.Zero);
			HoaDon.SoLanTra = SqlClientUtility.GetInt32(dataReader, "SO_LAN_TRA", 0);

			return HoaDon;
		}

		#endregion
	}
}

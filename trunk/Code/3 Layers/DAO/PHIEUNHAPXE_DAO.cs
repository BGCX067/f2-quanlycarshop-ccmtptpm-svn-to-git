using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class PHIEUNHAPXE_DAO: AbstractDAO
	{
		#region Constructors

		public PHIEUNHAPXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the PHIEU_NHAP_XE table.
		/// </summary>
		public void Insert(PHIEUNHAPXE_DTO PhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("PhieuNhapXe", PhieuNhapXe);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", PhieuNhapXe.MaDonDatHang),
				new SqlParameter("@NGAY_NHAP", PhieuNhapXe.NgayNhap),
				new SqlParameter("@TONG_SO_LUONG", PhieuNhapXe.TongSoLuong)
			};

            PhieuNhapXe.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuNhapXe_Insert", parameters);
        }

		/// <summary>
		/// Updates a record in the PHIEU_NHAP_XE table.
		/// </summary>
		public void Update(PHIEUNHAPXE_DTO PhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("PhieuNhapXe", PhieuNhapXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", PhieuNhapXe.Ma),
				new SqlParameter("@MA_DON_DAT_HANG", PhieuNhapXe.MaDonDatHang),
				new SqlParameter("@NGAY_NHAP", PhieuNhapXe.NgayNhap),
				new SqlParameter("@TONG_SO_LUONG", PhieuNhapXe.TongSoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuNhapXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_NHAP_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuNhapXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaDonDatHang(int MaDonDatHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", MaDonDatHang)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuNhapXeDeleteAllByMaDonDatHang", parameters);
		}

		/// <summary>
		/// Selects a single record from the PHIEU_NHAP_XE table.
		/// </summary>
		public PHIEUNHAPXE_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuNhapXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakePHIEUNHAPXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the PHIEU_NHAP_XE table.
		/// </summary>
		public List<PHIEUNHAPXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuNhapXe_SelectAll"))
			{
				List<PHIEUNHAPXE_DTO> PhieuNhapXeList = new List<PHIEUNHAPXE_DTO>();
				while (dataReader.Read())
				{
					PHIEUNHAPXE_DTO PhieuNhapXe = MakePHIEUNHAPXE_DTO(dataReader);
					PhieuNhapXeList.Add(PhieuNhapXe);
				}

				return PhieuNhapXeList;
			}
		}

		/// <summary>
		/// Selects all records from the PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<PHIEUNHAPXE_DTO> SelectAllByMaDonDatHang(int MaDonDatHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_DON_DAT_HANG", MaDonDatHang)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuNhapXeSelectAllByMaDonDatHang", parameters))
			{
				List<PHIEUNHAPXE_DTO> PhieuNhapXeList = new List<PHIEUNHAPXE_DTO>();
				while (dataReader.Read())
				{
					PHIEUNHAPXE_DTO PhieuNhapXe = MakePHIEUNHAPXE_DTO(dataReader);
					PhieuNhapXeList.Add(PhieuNhapXe);
				}

				return PhieuNhapXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the PHIEU_NHAP_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private PHIEUNHAPXE_DTO MakePHIEUNHAPXE_DTO(SqlDataReader dataReader)
		{
			PHIEUNHAPXE_DTO PhieuNhapXe = new PHIEUNHAPXE_DTO();
			PhieuNhapXe.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			PhieuNhapXe.MaDonDatHang = SqlClientUtility.GetInt32(dataReader, "MA_DON_DAT_HANG", 0);
			PhieuNhapXe.NgayNhap = SqlClientUtility.GetDateTime(dataReader, "NGAY_NHAP", DateTime.Now);
			PhieuNhapXe.TongSoLuong = SqlClientUtility.GetInt32(dataReader, "TONG_SO_LUONG", 0);

			return PhieuNhapXe;
		}

		#endregion
	}
}

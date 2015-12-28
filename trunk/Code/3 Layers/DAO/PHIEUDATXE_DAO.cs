using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class PHIEUDATXE_DAO: AbstractDAO
	{
		#region Constructors

		public PHIEUDATXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the PHIEU_DAT_XE table.
		/// </summary>
		public void Insert(PHIEUDATXE_DTO PhieuDatXe)
		{
			ValidationUtility.ValidateArgument("PhieuDatXe", PhieuDatXe);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KHACH_HANG", PhieuDatXe.MaKhachHang),
				new SqlParameter("@MA_NHAN_VIEN", PhieuDatXe.MaNhanVien),
				new SqlParameter("@NGAY_DAT", PhieuDatXe.NgayDat),
				new SqlParameter("@NGAY_HEN_LAY", PhieuDatXe.NgayHenLay),
				new SqlParameter("@TONG_TIEN", PhieuDatXe.TongTien),
				new SqlParameter("@TIEN_TRA_TRUOC", PhieuDatXe.TienTraTruoc)
			};

            PhieuDatXe.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXe_Insert", parameters);
        }

		/// <summary>
		/// Updates a record in the PHIEU_DAT_XE table.
		/// </summary>
		public void Update(PHIEUDATXE_DTO PhieuDatXe)
		{
			ValidationUtility.ValidateArgument("PhieuDatXe", PhieuDatXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", PhieuDatXe.Ma),
				new SqlParameter("@MA_KHACH_HANG", PhieuDatXe.MaKhachHang),
				new SqlParameter("@MA_NHAN_VIEN", PhieuDatXe.MaNhanVien),
				new SqlParameter("@NGAY_DAT", PhieuDatXe.NgayDat),
				new SqlParameter("@NGAY_HEN_LAY", PhieuDatXe.NgayHenLay),
				new SqlParameter("@TONG_TIEN", PhieuDatXe.TongTien),
				new SqlParameter("@TIEN_TRA_TRUOC", PhieuDatXe.TienTraTruoc)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_DAT_XE table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaKhachHang(int MaKhachHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KHACH_HANG", MaKhachHang)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXeDeleteAllByMaKhachHang", parameters);
		}

		/// <summary>
		/// Deletes a record from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXeDeleteAllByMaNhanVien", parameters);
		}

		/// <summary>
		/// Selects a single record from the PHIEU_DAT_XE table.
		/// </summary>
		public PHIEUDATXE_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakePHIEUDATXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the PHIEU_DAT_XE table.
		/// </summary>
		public List<PHIEUDATXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXe_SelectAll"))
			{
				List<PHIEUDATXE_DTO> PhieuDatXeList = new List<PHIEUDATXE_DTO>();
				while (dataReader.Read())
				{
					PHIEUDATXE_DTO PhieuDatXe = MakePHIEUDATXE_DTO(dataReader);
					PhieuDatXeList.Add(PhieuDatXe);
				}

				return PhieuDatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<PHIEUDATXE_DTO> SelectAllByMaKhachHang(int MaKhachHang)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_KHACH_HANG", MaKhachHang)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXeSelectAllByMaKhachHang", parameters))
			{
				List<PHIEUDATXE_DTO> PhieuDatXeList = new List<PHIEUDATXE_DTO>();
				while (dataReader.Read())
				{
					PHIEUDATXE_DTO PhieuDatXe = MakePHIEUDATXE_DTO(dataReader);
					PhieuDatXeList.Add(PhieuDatXe);
				}

				return PhieuDatXeList;
			}
		}

		/// <summary>
		/// Selects all records from the PHIEU_DAT_XE table by a foreign key.
		/// </summary>
		public List<PHIEUDATXE_DTO> SelectAllByMaNhanVien(int MaNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_NHAN_VIEN", MaNhanVien)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_PhieuDatXeSelectAllByMaNhanVien", parameters))
			{
				List<PHIEUDATXE_DTO> PhieuDatXeList = new List<PHIEUDATXE_DTO>();
				while (dataReader.Read())
				{
					PHIEUDATXE_DTO PhieuDatXe = MakePHIEUDATXE_DTO(dataReader);
					PhieuDatXeList.Add(PhieuDatXe);
				}

				return PhieuDatXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the PHIEU_DAT_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private PHIEUDATXE_DTO MakePHIEUDATXE_DTO(SqlDataReader dataReader)
		{
			PHIEUDATXE_DTO PhieuDatXe = new PHIEUDATXE_DTO();
			PhieuDatXe.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			PhieuDatXe.MaKhachHang = SqlClientUtility.GetInt32(dataReader, "MA_KHACH_HANG", 0);
			PhieuDatXe.MaNhanVien = SqlClientUtility.GetInt32(dataReader, "MA_NHAN_VIEN", 0);
			PhieuDatXe.NgayDat = SqlClientUtility.GetDateTime(dataReader, "NGAY_DAT", DateTime.Now);
			PhieuDatXe.NgayHenLay = SqlClientUtility.GetDateTime(dataReader, "NGAY_HEN_LAY", DateTime.Now);
			PhieuDatXe.TongTien = SqlClientUtility.GetDecimal(dataReader, "TONG_TIEN", Decimal.Zero);
			PhieuDatXe.TienTraTruoc = SqlClientUtility.GetDecimal(dataReader, "TIEN_TRA_TRUOC", Decimal.Zero);

			return PhieuDatXe;
		}

		#endregion
	}
}

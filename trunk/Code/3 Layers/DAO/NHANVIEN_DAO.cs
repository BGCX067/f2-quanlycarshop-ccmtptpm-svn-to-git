using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class NHANVIEN_DAO: AbstractDAO
	{
		#region Constructors

		public NHANVIEN_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the NHAN_VIEN table.
		/// </summary>
		public void Insert(NHANVIEN_DTO NhanVien)
		{
			ValidationUtility.ValidateArgument("NhanVien", NhanVien);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@HO_TEN", NhanVien.HoTen),
				new SqlParameter("@MA_LOAI_NHAN_VIEN", NhanVien.MaLoaiNhanVien),
				new SqlParameter("@USERNAME", NhanVien.Username),
				new SqlParameter("@USER_PASSWORD", NhanVien.UserPassword),
				new SqlParameter("@PHAI", NhanVien.Phai),
				new SqlParameter("@NGAY_SINH", NhanVien.NgaySinh),
				new SqlParameter("@DIA_CHI", NhanVien.DiaChi),
				new SqlParameter("@DIEN_THOAI", NhanVien.DienThoai),
				new SqlParameter("@CMND", NhanVien.Cmnd)
			};

            NhanVien.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVien_Insert", parameters);
        }

		/// <summary>
		/// Updates a record in the NHAN_VIEN table.
		/// </summary>
		public void Update(NHANVIEN_DTO NhanVien)
		{
			ValidationUtility.ValidateArgument("NhanVien", NhanVien);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", NhanVien.Ma),
				new SqlParameter("@HO_TEN", NhanVien.HoTen),
				new SqlParameter("@MA_LOAI_NHAN_VIEN", NhanVien.MaLoaiNhanVien),
				new SqlParameter("@USERNAME", NhanVien.Username),
				new SqlParameter("@USER_PASSWORD", NhanVien.UserPassword),
				new SqlParameter("@PHAI", NhanVien.Phai),
				new SqlParameter("@NGAY_SINH", NhanVien.NgaySinh),
				new SqlParameter("@DIA_CHI", NhanVien.DiaChi),
				new SqlParameter("@DIEN_THOAI", NhanVien.DienThoai),
				new SqlParameter("@CMND", NhanVien.Cmnd)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVien_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the NHAN_VIEN table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVien_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the NHAN_VIEN table by a foreign key.
		/// </summary>
		public void DeleteAllByMaLoaiNhanVien(int MaLoaiNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_LOAI_NHAN_VIEN", MaLoaiNhanVien)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVienDeleteAllByMaLoaiNhanVien", parameters);
		}

		/// <summary>
		/// Selects a single record from the NHAN_VIEN table.
		/// </summary>
		public NHANVIEN_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVien_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeNHANVIEN_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

        /// <summary>
        /// Selects a single record from the NHAN_VIEN table by MaHoaDon
        /// </summary>
        public NHANVIEN_DTO SelectByMaHoaDon(int MaHoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", MaHoaDon)
			};

            using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVien_SelectBy_MA_HOA_DON", parameters))
            {
                if (dataReader.Read())
                {
                    return MakeNHANVIEN_DTO(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

        public NHANVIEN_DTO SelectByUserNamePassword(string UserName, string Password)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@USERNAME", UserName),
                new SqlParameter("@PASSWORD", Password),
			};

            using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVien_SelectByUserNamePassword", parameters))
            {
                if (dataReader.Read())
                {
                    return MakeNHANVIEN_DTO(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

		/// <summary>
		/// Selects all records from the NHAN_VIEN table.
		/// </summary>
		public List<NHANVIEN_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVien_SelectAll"))
			{
				List<NHANVIEN_DTO> NhanVienList = new List<NHANVIEN_DTO>();
				while (dataReader.Read())
				{
					NHANVIEN_DTO NhanVien = MakeNHANVIEN_DTO(dataReader);
					NhanVienList.Add(NhanVien);
				}

				return NhanVienList;
			}
		}

		/// <summary>
		/// Selects all records from the NHAN_VIEN table by a foreign key.
		/// </summary>
		public List<NHANVIEN_DTO> SelectAllByMaLoaiNhanVien(int MaLoaiNhanVien)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_LOAI_NHAN_VIEN", MaLoaiNhanVien)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_NhanVienSelectAllByMaLoaiNhanVien", parameters))
			{
				List<NHANVIEN_DTO> NhanVienList = new List<NHANVIEN_DTO>();
				while (dataReader.Read())
				{
					NHANVIEN_DTO NhanVien = MakeNHANVIEN_DTO(dataReader);
					NhanVienList.Add(NhanVien);
				}

				return NhanVienList;
			}
		}

		/// <summary>
		/// Creates a new instance of the NHAN_VIEN class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private NHANVIEN_DTO MakeNHANVIEN_DTO(SqlDataReader dataReader)
		{
			NHANVIEN_DTO NhanVien = new NHANVIEN_DTO();
			NhanVien.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			NhanVien.HoTen = SqlClientUtility.GetString(dataReader, "HO_TEN", String.Empty);
			NhanVien.MaLoaiNhanVien = SqlClientUtility.GetInt32(dataReader, "MA_LOAI_NHAN_VIEN", 0);
            NhanVien.TenLoaiNhanVien = SqlClientUtility.GetString(dataReader, "TEN_LOAI_NHAN_VIEN", string.Empty);
			NhanVien.Username = SqlClientUtility.GetString(dataReader, "USERNAME", String.Empty);
			NhanVien.UserPassword = SqlClientUtility.GetString(dataReader, "USER_PASSWORD", String.Empty);
			NhanVien.Phai = SqlClientUtility.GetBoolean(dataReader, "PHAI", false);
			NhanVien.NgaySinh = SqlClientUtility.GetDateTime(dataReader, "NGAY_SINH", DateTime.Now);
			NhanVien.DiaChi = SqlClientUtility.GetString(dataReader, "DIA_CHI", String.Empty);
			NhanVien.DienThoai = SqlClientUtility.GetString(dataReader, "DIEN_THOAI", String.Empty);
			NhanVien.Cmnd = SqlClientUtility.GetString(dataReader, "CMND", String.Empty);

			return NhanVien;
		}

		#endregion
	}
}

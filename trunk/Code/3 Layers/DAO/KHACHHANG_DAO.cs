using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class KHACHHANG_DAO: AbstractDAO
	{
		#region Constructors

		public KHACHHANG_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the KHACH_HANG table.
		/// </summary>
		public void Insert(KHACHHANG_DTO KhachHang)
		{
			ValidationUtility.ValidateArgument("KhachHang", KhachHang);

            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@HO_TEN", KhachHang.HoTen),
				new SqlParameter("@PHAI", KhachHang.Phai),
				new SqlParameter("@DIA_CHI", KhachHang.DiaChi),
				new SqlParameter("@DIEN_THOAI", KhachHang.DienThoai),
				new SqlParameter("@CMND", KhachHang.Cmnd),
				new SqlParameter("@LOAI_KHACH_HANG", KhachHang.LoaiKhachHang)
			};

            KhachHang.Ma = (int)SqlClientUtility.ExecuteScalar(m_ConnectionString, CommandType.StoredProcedure, "PROC_KhachHang_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the KHACH_HANG table.
		/// </summary>
		public void Update(KHACHHANG_DTO KhachHang)
		{
			ValidationUtility.ValidateArgument("KhachHang", KhachHang);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", KhachHang.Ma),
				new SqlParameter("@HO_TEN", KhachHang.HoTen),
				new SqlParameter("@PHAI", KhachHang.Phai),
				new SqlParameter("@DIA_CHI", KhachHang.DiaChi),
				new SqlParameter("@DIEN_THOAI", KhachHang.DienThoai),
				new SqlParameter("@CMND", KhachHang.Cmnd),
				new SqlParameter("@LOAI_KHACH_HANG", KhachHang.LoaiKhachHang)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_KhachHang_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the KHACH_HANG table by its primary key.
		/// </summary>
		public void Delete(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_KhachHang_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the KHACH_HANG table.
		/// </summary>
		public KHACHHANG_DTO Select(int Ma)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA", Ma)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_KhachHang_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeKHACHHANG_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

        /// <summary>
        /// Selects a single record from the KHACH_HANG table by MaHoaDon
        /// </summary>
        public KHACHHANG_DTO SelectByMaHoaDon(int MaHoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_HOA_DON", MaHoaDon)
			};

            using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_KhachHang_SelectBy_MA_HOA_DON", parameters))
            {
                if (dataReader.Read())
                {
                    return MakeKHACHHANG_DTO(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

        public KHACHHANG_DTO SelectByThongTin(string HoTen, string DiaChi, string CMND)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Ho_TEN", HoTen),
                new SqlParameter("@DIA_CHI", DiaChi),
                new SqlParameter("@CMND", CMND)
			};

            using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_KhachHang_SelectByThongTin", parameters))
            {
                if (dataReader.Read())
                {
                    return MakeKHACHHANG_DTO(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

		/// <summary>
		/// Selects all records from the KHACH_HANG table.
		/// </summary>
		public List<KHACHHANG_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_KhachHang_SelectAll"))
			{
				List<KHACHHANG_DTO> KhachHangList = new List<KHACHHANG_DTO>();
				while (dataReader.Read())
				{
					KHACHHANG_DTO KhachHang = MakeKHACHHANG_DTO(dataReader);
					KhachHangList.Add(KhachHang);
				}

				return KhachHangList;
			}
		}

		/// <summary>
		/// Creates a new instance of the KHACH_HANG class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private KHACHHANG_DTO MakeKHACHHANG_DTO(SqlDataReader dataReader)
		{
			KHACHHANG_DTO KhachHang = new KHACHHANG_DTO();
			KhachHang.Ma = SqlClientUtility.GetInt32(dataReader, "MA", 0);
			KhachHang.HoTen = SqlClientUtility.GetString(dataReader, "HO_TEN", String.Empty);
            KhachHang.Phai = SqlClientUtility.GetBoolean(dataReader, "PHAI", false);
            if (KhachHang.Phai)
                KhachHang.PhaiChu = "Nam";
            else
                KhachHang.PhaiChu = "Nữ";
			KhachHang.DiaChi = SqlClientUtility.GetString(dataReader, "DIA_CHI", String.Empty);
			KhachHang.DienThoai = SqlClientUtility.GetString(dataReader, "DIEN_THOAI", String.Empty);
			KhachHang.Cmnd = SqlClientUtility.GetString(dataReader, "CMND", String.Empty);
			KhachHang.LoaiKhachHang = SqlClientUtility.GetBoolean(dataReader, "LOAI_KHACH_HANG", false);

			return KhachHang;
		}

		#endregion
	}
}

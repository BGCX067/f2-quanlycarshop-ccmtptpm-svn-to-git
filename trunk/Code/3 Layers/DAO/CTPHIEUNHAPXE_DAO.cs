using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SharpCore.Data;
using SharpCore.Utilities;

using Layers.DTO;

namespace Layers.DAO
{
	public class CTPHIEUNHAPXE_DAO: AbstractDAO
	{
		#region Constructors

		public CTPHIEUNHAPXE_DAO()
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public void Insert(CTPHIEUNHAPXE_DTO CtPhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("CtPhieuNhapXe", CtPhieuNhapXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_NHAP_XE", CtPhieuNhapXe.MaPhieuNhapXe),
				new SqlParameter("@MA_XE", CtPhieuNhapXe.MaXe),
				new SqlParameter("@MA_MAU", CtPhieuNhapXe.MaMau),
				new SqlParameter("@SO_LUONG", CtPhieuNhapXe.SoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXe_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public void Update(CTPHIEUNHAPXE_DTO CtPhieuNhapXe)
		{
			ValidationUtility.ValidateArgument("CtPhieuNhapXe", CtPhieuNhapXe);

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_NHAP_XE", CtPhieuNhapXe.MaPhieuNhapXe),
				new SqlParameter("@MA_XE", CtPhieuNhapXe.MaXe),
				new SqlParameter("@MA_MAU", CtPhieuNhapXe.MaMau),
				new SqlParameter("@SO_LUONG", CtPhieuNhapXe.SoLuong)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXe_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by its primary key.
		/// </summary>
		public void Delete(int MaPhieuNhapXe, int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_NHAP_XE", MaPhieuNhapXe),
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXe_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXeDeleteAllByMaMau", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaPhieuNhapXe(int MaPhieuNhapXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_NHAP_XE", MaPhieuNhapXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXeDeleteAllByMaPhieuNhapXe", parameters);
		}

		/// <summary>
		/// Deletes a record from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public void DeleteAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			SqlClientUtility.ExecuteNonQuery(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXeDeleteAllByMaXe", parameters);
		}

		/// <summary>
		/// Selects a single record from the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public CTPHIEUNHAPXE_DTO Select(int MaPhieuNhapXe, int MaXe, string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_NHAP_XE", MaPhieuNhapXe),
				new SqlParameter("@MA_XE", MaXe),
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXe_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCTPHIEUNHAPXE_DTO(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXe_SelectAll"))
			{
				List<CTPHIEUNHAPXE_DTO> CtPhieuNhapXeList = new List<CTPHIEUNHAPXE_DTO>();
				while (dataReader.Read())
				{
					CTPHIEUNHAPXE_DTO CtPhieuNhapXe = MakeCTPHIEUNHAPXE_DTO(dataReader);
					CtPhieuNhapXeList.Add(CtPhieuNhapXe);
				}

				return CtPhieuNhapXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAllByMaMau(string MaMau)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_MAU", MaMau)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXeSelectAllByMaMau", parameters))
			{
				List<CTPHIEUNHAPXE_DTO> CtPhieuNhapXeList = new List<CTPHIEUNHAPXE_DTO>();
				while (dataReader.Read())
				{
					CTPHIEUNHAPXE_DTO CtPhieuNhapXe = MakeCTPHIEUNHAPXE_DTO(dataReader);
					CtPhieuNhapXeList.Add(CtPhieuNhapXe);
				}

				return CtPhieuNhapXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAllByMaPhieuNhapXe(int MaPhieuNhapXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_PHIEU_NHAP_XE", MaPhieuNhapXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXeSelectAllByMaPhieuNhapXe", parameters))
			{
				List<CTPHIEUNHAPXE_DTO> CtPhieuNhapXeList = new List<CTPHIEUNHAPXE_DTO>();
				while (dataReader.Read())
				{
					CTPHIEUNHAPXE_DTO CtPhieuNhapXe = MakeCTPHIEUNHAPXE_DTO(dataReader);
					CtPhieuNhapXeList.Add(CtPhieuNhapXe);
				}

				return CtPhieuNhapXeList;
			}
		}

		/// <summary>
		/// Selects all records from the CT_PHIEU_NHAP_XE table by a foreign key.
		/// </summary>
		public List<CTPHIEUNHAPXE_DTO> SelectAllByMaXe(int MaXe)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MA_XE", MaXe)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(m_ConnectionString, CommandType.StoredProcedure, "PROC_CtPhieuNhapXeSelectAllByMaXe", parameters))
			{
				List<CTPHIEUNHAPXE_DTO> CtPhieuNhapXeList = new List<CTPHIEUNHAPXE_DTO>();
				while (dataReader.Read())
				{
					CTPHIEUNHAPXE_DTO CtPhieuNhapXe = MakeCTPHIEUNHAPXE_DTO(dataReader);
					CtPhieuNhapXeList.Add(CtPhieuNhapXe);
				}

				return CtPhieuNhapXeList;
			}
		}

		/// <summary>
		/// Creates a new instance of the CT_PHIEU_NHAP_XE class and populates it with data from the specified SqlDataReader.
		/// </summary>
		private CTPHIEUNHAPXE_DTO MakeCTPHIEUNHAPXE_DTO(SqlDataReader dataReader)
		{
			CTPHIEUNHAPXE_DTO CtPhieuNhapXe = new CTPHIEUNHAPXE_DTO();
			CtPhieuNhapXe.MaPhieuNhapXe = SqlClientUtility.GetInt32(dataReader, "MA_PHIEU_NHAP_XE", 0);
			CtPhieuNhapXe.MaXe = SqlClientUtility.GetInt32(dataReader, "MA_XE", 0);
			CtPhieuNhapXe.MaMau = SqlClientUtility.GetString(dataReader, "MA_MAU", String.Empty);
			CtPhieuNhapXe.SoLuong = SqlClientUtility.GetInt32(dataReader, "SO_LUONG", 0);

			return CtPhieuNhapXe;
		}

		#endregion
	}
}

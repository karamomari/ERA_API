using ERAAPI.Data;
using ERAAPI.DTO.UnitDTO;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ERAAPI.Repositories.Implementations
{
    public class UnitRepository : IUnitRepository
    {
        private readonly string _connectionString;

        public UnitRepository(EraPosDbNewLastContext context)
        {
            _connectionString = context.Database.GetDbConnection().ConnectionString;
        }

        public async Task<IEnumerable<UnitListDTO>> GetAllUnits()
        {
            var units = new List<UnitListDTO>();
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_UnitViewAll", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                units.Add(new UnitListDTO
                {
                    UnitId = (decimal)reader["unitId"],
                    UnitName = reader["Unit Name"].ToString(),
                    NoOfDecimalPlaces = (int)reader["No of Decimal Place"],
                    FormalName = reader["Formal Name"].ToString(),
                    Narration = reader["Narration"].ToString()
                });
            }

            return units;
        }

        public async Task<IEnumerable<UnitByProductDTO>> GetUnitsByProduct()
        {
            var list = new List<UnitByProductDTO>();
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_UnitByProductViewAll", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new UnitByProductDTO
                {
                    ProductId = (decimal)reader["productId"],
                    UnitConversionId = (decimal)reader["unitconversionId"],
                    UnitId = (decimal)reader["unitId"],
                    UnitName = reader["unitName"].ToString()
                });
            }

            return list;
        }


        public async Task<Unit> GetUnitByIdAsync(decimal id)
        {
            Unit unit = null;

            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_UnitViewById", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = id;

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                unit = new Unit
                {
                    UnitId = (decimal)reader["unitId"],
                    UnitName = reader["unitName"].ToString(),
                    Narration = reader["narration"].ToString(),
                    NoOfDecimalPlaces = reader["noOfDecimalplaces"] == DBNull.Value ? 0 : Convert.ToInt32(reader["noOfDecimalplaces"]),
                    FormalName = reader["formalName"].ToString(),
                    ExtraDate = reader["extraDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["extraDate"],
                    Extra1 = reader["extra1"].ToString(),
                    Extra2 = reader["extra2"].ToString(),
                    CreatedBy = reader["createdBy"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["createdBy"]),
                    CreatedDate = reader["createdDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["createdDate"],
                    ModifiedBy = reader["modifiedBy"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["modifiedBy"]),
                    ModifiedDate = reader["modifiedDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["modifiedDate"]
                };
            }

            return unit;
        }


        public async Task<decimal> SaveOrUpdateUnitAsync(Unit unit)
        {
            decimal unitId = 0;

            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_UnitSaveAndUpdate", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@unitId", SqlDbType.Decimal).Value = unit.UnitId;
            cmd.Parameters.Add("@unitName", SqlDbType.VarChar).Value = unit.UnitName;
            cmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = unit.Narration ?? "";
            cmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Int).Value = unit.NoOfDecimalPlaces;
            cmd.Parameters.Add("@formalName", SqlDbType.VarChar).Value = unit.FormalName ?? "";
            cmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = unit.Extra1 ?? "";
            cmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = unit.Extra2 ?? "";
            cmd.Parameters.Add("@extraDate", SqlDbType.DateTime).Value = unit.ExtraDate;
            cmd.Parameters.Add("@createdBy", SqlDbType.Decimal).Value = unit.CreatedBy;
            cmd.Parameters.Add("@createdDate", SqlDbType.DateTime).Value = unit.CreatedDate;
            cmd.Parameters.Add("@modifiedBy", SqlDbType.Decimal).Value = unit.ModifiedBy;
            cmd.Parameters.Add("@modifiedDate", SqlDbType.DateTime).Value = unit.ModifiedDate;

            await sqlcon.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();

            if (result != null)
                unitId = Convert.ToDecimal(result);

            return unitId;
        }


        public async Task<decimal> UnitCheckReferencesDeleteAsync(decimal id)
        {
            decimal decReturnValue = 0;

            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_UnitCheckReferencesDelete", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = id;

            await sqlcon.OpenAsync();
            decReturnValue = await cmd.ExecuteNonQueryAsync(); // يرجع عدد الصفوف المتأثرة

            return decReturnValue;
        }
    }

}

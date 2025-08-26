using ERAAPI.Data;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ERAAPI.Repositories.Implementations
{
    public class TaxRepository : ITaxRepository
    {
      
        private readonly string _connectionString;

        public TaxRepository(EraPosDbNewLastContext context)
        {
            _connectionString = context.Database.GetDbConnection().ConnectionString;
        }


        public async Task<List<Tax>> GetAllProductTaxesAsync()
        {
            var list = new List<Tax>();
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductTaxViewAll", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(new Tax
                {
                    TaxId = reader["taxId"] != DBNull.Value ? Convert.ToDecimal(reader["taxId"]) : 0,
                    TaxName = reader["taxName"]?.ToString() ?? string.Empty,
                    TaxType = reader["taxType"]?.ToString() ?? string.Empty,
                    ApplicableOn = reader["applicableOn"]?.ToString() ?? string.Empty,
                    Rate = reader["taxRate"] != DBNull.Value ? Convert.ToDecimal(reader["taxRate"]) : 0
                });
            }

            return list;
        }

        public async Task<bool> TaxNameExistsAsync(string taxName, decimal taxId)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_TaxNameCheckExistence", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = taxName;
            cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = taxId;

            await sqlcon.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToDecimal(result) > 0;
        }

        public async Task<decimal> SaveOrUpdateTaxAsync(Tax tax)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_TaxSaveAndUpdate", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@taxId", SqlDbType.Decimal).Value = tax.TaxId;
            cmd.Parameters.Add("@taxName", SqlDbType.VarChar).Value = tax.TaxName;
            cmd.Parameters.Add("@taxType", SqlDbType.VarChar).Value = tax.TaxType;
            cmd.Parameters.Add("@applicableOn", SqlDbType.VarChar).Value = tax.ApplicableOn;
            cmd.Parameters.Add("@rate", SqlDbType.Decimal).Value = tax.Rate;
            cmd.Parameters.Add("@calculatingMode", SqlDbType.VarChar).Value = tax.CalculatingMode;
            cmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = tax.Narration;
            cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = tax.IsActive;
            cmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = tax.Extra1;
            cmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = tax.Extra2;
            cmd.Parameters.Add("@extraDate", SqlDbType.DateTime).Value = tax.ExtraDate;
            cmd.Parameters.Add("@createdBy", SqlDbType.Decimal).Value = tax.CreatedBy;
            cmd.Parameters.Add("@createdDate", SqlDbType.DateTime).Value = tax.CreatedDate;
            cmd.Parameters.Add("@modifiedBy", SqlDbType.Decimal).Value = tax.ModifiedBy;
            cmd.Parameters.Add("@modifiedDate", SqlDbType.DateTime).Value = tax.ModifiedDate;

            await sqlcon.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return result != null ? Convert.ToDecimal(result) : 0;
        }
    }
}

using ERAAPI.Data;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ERAAPI.Repositories.Implementations
{
    public class ProductGroupRepository :IProductGroupRepository
    {
        private readonly string _connectionString;

        public ProductGroupRepository(EraPosDbNewLastContext context)
        {
            _connectionString = context.Database.GetDbConnection().ConnectionString;
        }


        public async Task<bool> CheckNameExistenceAsync(string name, decimal id)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductGroupNameCheckExistence", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);

            if (sqlcon.State == ConnectionState.Closed)
                await sqlcon.OpenAsync();

            var result = await cmd.ExecuteScalarAsync();
            var count = result != null ? Convert.ToDecimal(result) : 0;
            return count > 0;
        }

        public async Task<decimal> SaveAndUpdateAsync(ProductGroup entity)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductGroupSaveAndUpdate", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@groupId", entity.GroupId);
            cmd.Parameters.AddWithValue("@groupName", entity.GroupName);
            cmd.Parameters.AddWithValue("@groupUnder", entity.GroupUnder);
            cmd.Parameters.AddWithValue("@narration", entity.Narration ?? "");
            cmd.Parameters.AddWithValue("@extra1", entity.Extra1 ?? "");
            cmd.Parameters.AddWithValue("@extra2", entity.Extra2 ?? "");
            cmd.Parameters.AddWithValue("@extraDate", entity.ExtraDate);
            cmd.Parameters.AddWithValue("@createdBy", entity.CreatedBy);
            cmd.Parameters.AddWithValue("@createdDate", entity.CreatedDate);
            cmd.Parameters.AddWithValue("@modifiedBy", entity.ModifiedBy);
            cmd.Parameters.AddWithValue("@modifiedDate", entity.ModifiedDate);

            if (sqlcon.State == ConnectionState.Closed)
                await sqlcon.OpenAsync();

            var obj = await cmd.ExecuteScalarAsync();
            return obj != null ? Convert.ToDecimal(obj) : 0;
        }

        public async Task<int> CheckReferencesDeleteAsync(decimal id)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductGroupCheckReferencesDelete", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            await sqlcon.OpenAsync();
            var affectedRows = await cmd.ExecuteNonQueryAsync();

            return affectedRows;
        }


        public async Task<ProductGroup?> GetByIdAsync(decimal id)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductGroupViewById", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            ProductGroup? item = null;

            if (await reader.ReadAsync())
            {
                item = new ProductGroup
                {
                    GroupId = reader.GetFieldValue<decimal>(reader.GetOrdinal("groupId")),
                    GroupName = reader.GetFieldValue<string>(reader.GetOrdinal("groupName")),
                    GroupUnder = reader.GetFieldValue<decimal>(reader.GetOrdinal("groupUnder")),
                    Narration = reader.GetFieldValue<string>(reader.GetOrdinal("narration")),
                    ExtraDate = reader.GetFieldValue<DateTime>(reader.GetOrdinal("extraDate")),
                    Extra1 = reader.GetFieldValue<string>(reader.GetOrdinal("extra1")),
                    Extra2 = reader.GetFieldValue<string>(reader.GetOrdinal("extra2")),
                    CreatedBy = reader.GetFieldValue<decimal>(reader.GetOrdinal("createdBy")),
                    CreatedDate = reader.GetFieldValue<DateTime>(reader.GetOrdinal("createdDate")),
                    ModifiedBy = reader.GetFieldValue<decimal>(reader.GetOrdinal("modifiedBy")),
                    ModifiedDate = reader.GetFieldValue<DateTime>(reader.GetOrdinal("modifiedDate")),
                };
            }

            return item;
        }



        public async Task<IEnumerable<ProductGroup>> GetAllPOSAsync()
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("sp1_ProductGroupViewAllPOS", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            var items = new List<ProductGroup>();
            while (await reader.ReadAsync())
            {
                items.Add(new ProductGroup
                {
                    GroupId = reader.GetFieldValue<decimal>(reader.GetOrdinal("groupId")),
                    GroupName = reader.GetFieldValue<string>(reader.GetOrdinal("groupName")),
                    GroupUnder = reader.GetFieldValue<decimal>(reader.GetOrdinal("groupUnder")),
                    GroupUnderName = reader.GetFieldValue<string>(reader.GetOrdinal("groupUnderName")),
                    Narration = reader.GetFieldValue<string>(reader.GetOrdinal("narration")),
                    ExtraDate = reader.GetFieldValue<DateTime>(reader.GetOrdinal("extraDate")),
                    Extra1 = reader.GetFieldValue<string>(reader.GetOrdinal("extra1")),
                    Extra2 = reader.GetFieldValue<string>(reader.GetOrdinal("extra2")),
                });
            }

            return items;
        }



    }
}

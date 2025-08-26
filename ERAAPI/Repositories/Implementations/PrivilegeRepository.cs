using ERAAPI.Data;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace ERAAPI.Repositories.Implementations
{
    public class PrivilegeRepository : IPrivilegeRepository
    {
        private readonly string _connectionString;

        public PrivilegeRepository(EraPosDbNewLastContext context)
        {
            _connectionString = context.Database.GetDbConnection().ConnectionString;
        }

        public async Task<List<Privilege>> PrivilegeViewAllAsync()
        {
            var list = new List<Privilege>();

            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("PrivilegeViewAll", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(new Privilege
                {
                    PrivilegeId = reader["PrivilegeId"] != DBNull.Value ? Convert.ToDecimal(reader["PrivilegeId"]) : 0,
                    RoleId = reader["RoleId"] != DBNull.Value ? Convert.ToDecimal(reader["RoleId"]) : 0,
                    FormName = reader["formName"] != DBNull.Value ? reader["formName"].ToString()! : string.Empty,
                    Action = reader["action"] != DBNull.Value ? reader["action"].ToString()! : string.Empty,
                    ExtraDate = reader["extraDate"] != DBNull.Value ? Convert.ToDateTime(reader["extraDate"]) : (DateTime?)null
                });

            }

            return list;
        }


    }
}

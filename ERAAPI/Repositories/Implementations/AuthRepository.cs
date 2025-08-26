using ERAAPI.Data;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ERAAPI.Repositories.Implementations
{
    public class AuthRepository : IAuthRepository
    {
        private readonly string _connectionString;

        public AuthRepository(EraPosDbNewLastContext context)
        {
            _connectionString = context.Database.GetDbConnection().ConnectionString;
        }
        public TblUser? GetUserByUserNameAndPassword(string username, string password)
        {
            using (SqlConnection sqlcon = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("GetUserInfoByUserNameAndPassword", sqlcon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", username);
                cmd.Parameters.AddWithValue("@password", password);

                sqlcon.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new TblUser
                        {
                            UserId = Convert.ToDecimal(reader["UserId"]),
                            UserName = reader["UserName"] as string,
                            Password = reader["Password"] as string,
                            Active = reader["Active"] as bool?,
                            RoleId = Convert.ToDecimal(reader["RoleId"]),
                            EmployeeId = reader["EmployeeId"] as decimal?,
                            ManagerId = reader["ManagerId"] as decimal?,
                            BankId = reader["BankId"] as decimal?,
                            GodownId = reader["GodownId"] as decimal?,
                            Narration = reader["Narration"] as string,
                            ExtraDate = reader["ExtraDate"] as DateTime?,
                            Extra1 = reader["Extra1"] as string,
                            Extra2 = reader["Extra2"] as string,
                            CreatedBy = reader["CreatedBy"] as decimal?,
                            CreatedDate = reader["CreatedDate"] as DateTime?,
                            ModifiedBy = reader["ModifiedBy"] as decimal?,
                            ModifiedDate = reader["ModifiedDate"] as DateTime?
                        };
                    }
                }
            }

            return null;
        }




    }
}

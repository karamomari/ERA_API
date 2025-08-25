using ERAAPI.Data;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ERAAPI.Repositories.Implementations
{
    public class UserRepositorycs : IUser
    {
        private readonly string _connectionString;

        public UserRepositorycs(EraPosDbNewLastContext context)
        {
            _connectionString = context.Database.GetDbConnection().ConnectionString;
        }

        public decimal UserSaveAndUpdate(UserInfo info)
        {
            decimal userId = 0;

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(_connectionString))
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("newsp_UserSaveAndUpdate", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@userId", SqlDbType.Decimal).Value = info.UserId;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = info.UserName;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = info.Password;
                        cmd.Parameters.Add("@active", SqlDbType.Bit).Value = info.Active;
                        cmd.Parameters.Add("@roleId", SqlDbType.Decimal).Value = info.RoleId;
                        cmd.Parameters.Add("@employeeId", SqlDbType.Decimal).Value = info.EmployeeId;
                        cmd.Parameters.Add("@managerId", SqlDbType.Decimal).Value = info.ManagerId;
                        cmd.Parameters.Add("@bankId", SqlDbType.Decimal).Value = info.BankId;
                        cmd.Parameters.Add("@godownId", SqlDbType.Decimal).Value = info.GodownId;
                        cmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = info.Narration ?? string.Empty;
                        cmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = info.Extra1 ?? string.Empty;
                        cmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = info.Extra2 ?? string.Empty;
                        cmd.Parameters.Add("@extraDate", SqlDbType.DateTime).Value = info.ExtraDate;
                        cmd.Parameters.Add("@createdBy", SqlDbType.Decimal).Value = info.CreatedBy;
                        cmd.Parameters.Add("@createdDate", SqlDbType.DateTime).Value = info.CreatedDate;
                        cmd.Parameters.Add("@modifiedBy", SqlDbType.Decimal).Value = info.ModifiedBy;
                        cmd.Parameters.Add("@modifiedDate", SqlDbType.DateTime).Value = info.ModifiedDate;

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                            userId = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in UserSaveAndUpdate: " + ex.Message);
            }

            return userId;
        }

    }
}

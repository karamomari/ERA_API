using ERAAPI.Data;
using ERAAPI.DTO.Product;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace ERAAPI.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(EraPosDbNewLastContext context)
        {
            _connectionString = context.Database.GetDbConnection().ConnectionString;
        }



        public async Task<Product?> GetProductByIdAsync(decimal productId, string productCode, string barcode)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductViewById", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = productId;
            cmd.Parameters.Add("@productCode", SqlDbType.VarChar).Value = productCode;
            cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = barcode;

            await sqlcon.OpenAsync();

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Product
                {
                    ProductId = reader.GetDecimal(reader.GetOrdinal("productId")),
                    ProductCode = reader.GetString(reader.GetOrdinal("productCode")),
                    ProductName = reader.GetString(reader.GetOrdinal("productName")),
                    GroupId = reader.GetDecimal(reader.GetOrdinal("groupId")),
                    ProductType = reader.GetString(reader.GetOrdinal("productType")),
                    ProductTrackingType = reader.GetString(reader.GetOrdinal("productTrackingType")),
                    BrandId = reader.GetDecimal(reader.GetOrdinal("brandId")),
                    UnitId = reader.GetDecimal(reader.GetOrdinal("unitId")),
                    SizeId = reader.GetDecimal(reader.GetOrdinal("sizeId")),
                    ModelNoId = reader.GetDecimal(reader.GetOrdinal("modelNoId")),
                    TaxId = reader.GetDecimal(reader.GetOrdinal("taxId")),
                    TaxapplicableOn = reader.GetString(reader.GetOrdinal("taxapplicableOn")),
                    PurchaseRate = reader.GetDecimal(reader.GetOrdinal("purchaseRate")),
                    SalesRate = reader.GetDecimal(reader.GetOrdinal("salesRate")),
                    Mrp = reader.GetDecimal(reader.GetOrdinal("mrp")),
                    MinimumStock = reader.GetDecimal(reader.GetOrdinal("minimumStock")),
                    MaximumStock = reader.GetDecimal(reader.GetOrdinal("maximumStock")),
                    ReorderLevel = reader.GetDecimal(reader.GetOrdinal("reorderLevel")),
                    GodownId = reader.GetDecimal(reader.GetOrdinal("godownId")),
                    RackId = reader.GetDecimal(reader.GetOrdinal("rackId")),
                    IsallowBatch = reader.GetBoolean(reader.GetOrdinal("isallowBatch")),
                    Ismultipleunit = reader.GetBoolean(reader.GetOrdinal("ismultipleunit")),
                    IsBom = reader.GetBoolean(reader.GetOrdinal("isBom")),
                    Isopeningstock = reader.GetBoolean(reader.GetOrdinal("isopeningstock")),
                    Narration = reader.GetString(reader.GetOrdinal("narration")),
                    PartNo = reader.GetString(reader.GetOrdinal("partNo")),
                    ProductImageString = reader.GetString(reader.GetOrdinal("productImageString")),
                    ProductImage = reader["productImage"] as byte[],
                    IsActive = reader.GetBoolean(reader.GetOrdinal("isActive")),
                    IsshowRemember = reader.GetBoolean(reader.GetOrdinal("isshowRemember")),
                    Saleable = reader.GetBoolean(reader.GetOrdinal("saleable")),
                    Purchasable = reader.GetBoolean(reader.GetOrdinal("purchasable")),
                    Consumable = reader.GetBoolean(reader.GetOrdinal("consumable")),
                    Extra1 = reader.GetString(reader.GetOrdinal("extra1")),
                    Extra2 = reader.GetString(reader.GetOrdinal("extra2")),
                    ExtraDate = reader.GetDateTime(reader.GetOrdinal("extraDate")),
                    CreatedDate = reader.GetDateTime(reader.GetOrdinal("createdDate")),
                    CreatedBy = Convert.ToDecimal(reader.GetOrdinal("createdBy")),
                    ModifiedBy = Convert.ToDecimal(reader.GetOrdinal("modifiedBy")),
                    ModifiedDate = reader.GetDateTime(reader.GetOrdinal("modifiedDate"))
                };
            }

            return null; 
        }


        public async Task<IEnumerable<ProductInfoDTO>> ProductViewAllAsync()
        {
            var products = new List<ProductInfoDTO>();

            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductViewAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                products.Add(new ProductInfoDTO
                {
                    ProductId = reader.IsDBNull(reader.GetOrdinal("ProductId")) ? 0 : reader.GetDecimal(reader.GetOrdinal("ProductId")),
                    ProductCode = reader.IsDBNull(reader.GetOrdinal("Product Code")) ? null : reader.GetString(reader.GetOrdinal("Product Code")),
                    Barcode = reader.IsDBNull(reader.GetOrdinal("Barcode")) ? null : reader.GetString(reader.GetOrdinal("Barcode")),
                    ProductName = reader.IsDBNull(reader.GetOrdinal("Product Name")) ? null : reader.GetString(reader.GetOrdinal("Product Name")),
                    GroupIdName = reader.IsDBNull(reader.GetOrdinal("Product Group")) ? null : reader.GetString(reader.GetOrdinal("Product Group")),
                    SalesRate = reader.IsDBNull(reader.GetOrdinal("Sales Rate 1")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Sales Rate 1"))
                });
            }

            return products;
        }



        public async Task<bool> IsBarcodeExistAsync(string barcode, decimal productId)
        {
            await using var sqlcon = new SqlConnection(_connectionString);
            await using var cmd = new SqlCommand("eraPOS_BatchBarcodeCheckExistence", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = barcode;
            cmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = productId;

            await sqlcon.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToDecimal(result) > 0;
        }

        public async Task<decimal> SaveOrUpdateProductAsync(ProductCreateDTO info)
        {
            if (!string.IsNullOrWhiteSpace(info.Barcode) && await IsBarcodeExistAsync(info.Barcode, info.ProductId))
            {
                throw new Exception("Barcode Already Exists");
            }

            await using var sqlcon = new SqlConnection(_connectionString);
            await using var cmd = new SqlCommand("eraPOS_ProductSaveAndUpdate", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = info.ProductId;
            cmd.Parameters.Add("@productCode", SqlDbType.VarChar).Value = info.ProductCode ?? string.Empty;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = info.ProductName ?? string.Empty;
            cmd.Parameters.Add("@groupId", SqlDbType.Decimal).Value = info.GroupId;
            cmd.Parameters.Add("@productType", SqlDbType.VarChar).Value = info.ProductType ?? string.Empty;
            cmd.Parameters.Add("@productTrackingType", SqlDbType.VarChar).Value = info.ProductTrackingType ?? string.Empty;
            cmd.Parameters.Add("@brandId", SqlDbType.Decimal).Value = info.BrandId;
            cmd.Parameters.Add("@unitId", SqlDbType.Decimal).Value = info.UnitId;
            cmd.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = info.SizeId;
            cmd.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = info.ModelNoId;
            cmd.Parameters.Add("@taxId", SqlDbType.Decimal).Value = info.TaxId;
            cmd.Parameters.Add("@taxapplicableOn", SqlDbType.VarChar).Value = info.TaxApplicableOn ?? string.Empty;
            cmd.Parameters.Add("@purchaseRate", SqlDbType.Decimal).Value = info.PurchaseRate;
            cmd.Parameters.Add("@salesRate", SqlDbType.Decimal).Value = info.SalesRate;
            cmd.Parameters.Add("@mrp", SqlDbType.Decimal).Value = info.Mrp;
            cmd.Parameters.Add("@minimumStock", SqlDbType.Decimal).Value = info.MinimumStock;
            cmd.Parameters.Add("@maximumStock", SqlDbType.Decimal).Value = info.MaximumStock;
            cmd.Parameters.Add("@reorderLevel", SqlDbType.Decimal).Value = info.ReorderLevel;
            cmd.Parameters.Add("@godownId", SqlDbType.Decimal).Value = info.GodownId;
            cmd.Parameters.Add("@rackId", SqlDbType.Decimal).Value = info.RackId;
            cmd.Parameters.Add("@isallowBatch", SqlDbType.Bit).Value = info.IsAllowBatch;
            cmd.Parameters.Add("@ismultipleunit", SqlDbType.Bit).Value = info.IsMultipleUnit;
            cmd.Parameters.Add("@isBom", SqlDbType.Bit).Value = info.IsBom;
            cmd.Parameters.Add("@isopeningstock", SqlDbType.Bit).Value = info.IsOpeningStock;
            cmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = info.Narration ?? string.Empty;
            cmd.Parameters.Add("@partNo", SqlDbType.VarChar).Value = info.Barcode ?? string.Empty;
            cmd.Parameters.Add("@productImageString", SqlDbType.VarChar).Value = info.ProductImageString ?? string.Empty;
            cmd.Parameters.Add("@productImage", SqlDbType.Image).Value = (object)info.ProductImage ?? DBNull.Value;
            cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = info.IsActive;
            cmd.Parameters.Add("@isshowRemember", SqlDbType.Bit).Value = info.IsShowRemember;
            cmd.Parameters.Add("@saleable", SqlDbType.Bit).Value = info.Saleable;
            cmd.Parameters.Add("@purchasable", SqlDbType.Bit).Value = info.Purchasable;
            cmd.Parameters.Add("@consumable", SqlDbType.Bit).Value = info.Consumable;
            cmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = info.Extra1 ?? string.Empty;
            cmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = info.Extra2 ?? string.Empty;
            cmd.Parameters.Add("@extraDate", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@createdBy", SqlDbType.Decimal).Value = info.CreatedBy;
            cmd.Parameters.Add("@createdDate", SqlDbType.DateTime).Value = info.CreatedDate;
            cmd.Parameters.Add("@modifiedBy", SqlDbType.Decimal).Value = info.ModifiedBy;
            cmd.Parameters.Add("@modifiedDate", SqlDbType.DateTime).Value = info.ModifiedDate;

            await sqlcon.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return result != null ? Convert.ToDecimal(result) : 0;
        }


        public async Task<List<Product>> GetProductsByGroupIdAsync(decimal groupId)
        {
            var list = new List<Product>();

            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("sp1_ProductViewAllPOS", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupId", groupId);

            await sqlcon.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                list.Add(new Product
                {
                    ProductId = reader["productId"] != DBNull.Value ? Convert.ToDecimal(reader["productId"]) : 0,
                    ProductCode = reader["productCode"].ToString(),
                    ProductName = reader["productName"].ToString(),
                    GroupId = reader["groupId"] != DBNull.Value ? Convert.ToDecimal(reader["groupId"]) : 0,
                    ProductType = reader["productType"]?.ToString(),
                    SalesRate = reader["salesRate"] != DBNull.Value ? Convert.ToDecimal(reader["salesRate"]) : 0,
                    IsActive = reader["isActive"] != DBNull.Value && Convert.ToBoolean(reader["isActive"]),
                });
            }

            return list;
        }


        public bool TryDeleteProduct(decimal productId)
        {
            using var sqlcon = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("eraPOS_ProductCheckReferencesDelete", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = productId;

            sqlcon.Open();
            var rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected > 0; 
        }

    }
}


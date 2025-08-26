namespace ERAAPI.DTO.Product
{
    public class ProductCreateDTO
    {
        public decimal ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Barcode { get; set; }  // PartNo
        public string ProductName { get; set; }
        public decimal GroupId { get; set; }
        public string ProductType { get; set; }
        public string ProductTrackingType { get; set; }
        public decimal BrandId { get; set; }
        public decimal UnitId { get; set; }
        public decimal SizeId { get; set; }
        public decimal ModelNoId { get; set; }
        public decimal TaxId { get; set; }
        public string TaxApplicableOn { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SalesRate { get; set; }
        public decimal Mrp { get; set; }
        public decimal MinimumStock { get; set; }
        public decimal MaximumStock { get; set; }
        public decimal ReorderLevel { get; set; }
        public decimal GodownId { get; set; }
        public decimal RackId { get; set; }
        public bool IsAllowBatch { get; set; }
        public bool IsMultipleUnit { get; set; }
        public bool IsBom { get; set; }
        public bool IsOpeningStock { get; set; }
        public string Narration { get; set; }
        public string ProductImageString { get; set; }
        public byte[] ProductImage { get; set; }
        public bool IsActive { get; set; }
        public bool IsShowRemember { get; set; }
        public bool Saleable { get; set; }
        public bool Purchasable { get; set; }
        public bool Consumable { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public DateTime? ExtraDate { get; set; }
        public decimal CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

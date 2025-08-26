namespace ERAAPI.DTO.Product
{
    public class ProductInfoDTO
    {
        public decimal ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? Barcode { get; set; }
        public string? ProductName { get; set; }
        public string? GroupIdName { get; set; }
        public decimal SalesRate { get; set; }
    }
}

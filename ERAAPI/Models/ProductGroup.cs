namespace ERAAPI.Models
{
    public class ProductGroup
    {
        public decimal GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public decimal GroupUnder { get; set; }
        public string? GroupUnderName { get; set; }
        public string? Narration { get; set; }
        public DateTime ExtraDate { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public decimal CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

namespace ERAAPI.Models
{
    public class Tax
    {
        public decimal TaxId { get; set; }
        public string TaxName { get; set; } = string.Empty;
        public string TaxType { get; set; } = string.Empty;
        public string ApplicableOn { get; set; } = string.Empty;
        public decimal Rate { get; set; }
        public string CalculatingMode { get; set; } = string.Empty;
        public string Narration { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime ExtraDate { get; set; }
        public string Extra1 { get; set; } = string.Empty;
        public string Extra2 { get; set; } = string.Empty;
        public decimal CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

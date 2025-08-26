namespace ERAAPI.DTO.TaxDTO
{
    public class TaxDTO
    {
        public decimal TaxId { get; set; }
        public string TaxName { get; set; } = string.Empty;
        public string TaxType { get; set; } = string.Empty;
        public string ApplicableOn { get; set; } = string.Empty;
        public decimal Rate { get; set; }
        public bool IsActive { get; set; }
    }
}

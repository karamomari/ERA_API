namespace ERAAPI.DTO.ProductGroupDTO
{
    public class ProductGroupCreateDTO
    {
        public decimal GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public decimal GroupUnder { get; set; }
        public string? Narration { get; set; }
    }
}

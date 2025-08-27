namespace ERAAPI.Models
{
    public class Unit
    {
        public decimal UnitId { get; set; }
        public string UnitName { get; set; }
        public string Narration { get; set; }
        public DateTime ExtraDate { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public int NoOfDecimalPlaces { get; set; }
        public string FormalName { get; set; }
        public decimal CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

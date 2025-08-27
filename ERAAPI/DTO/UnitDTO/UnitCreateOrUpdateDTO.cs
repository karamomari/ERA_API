namespace ERAAPI.DTO.UnitDTO
{
    public class UnitCreateOrUpdateDTO
    {
        public decimal UnitId { get; set; }
        public string UnitName { get; set; }
        public string Narration { get; set; }
        public DateTime ExtraDate { get; set; }
        public int NoOfDecimalPlaces { get; set; }
        public string FormalName { get; set; }
       
    }
}

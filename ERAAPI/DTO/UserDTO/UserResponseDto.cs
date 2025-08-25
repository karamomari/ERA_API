namespace ERAAPI.DTO.UserDTO
{
    public class UserResponseDto
    {
        public decimal UserId { get; set; }
        public string UserName { get; set; }
        public bool Active { get; set; }
        public decimal RoleId { get; set; }
        public string Role { get; set; }
        public decimal EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal ManagerId { get; set; }
        public string ManagerName { get; set; }
        public decimal BankId { get; set; }
        public string BankName { get; set; }
        public decimal GodownId { get; set; }
        public string GodownName { get; set; }
        public string Narration { get; set; }
        public DateTime ExtraDate { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
    }
}

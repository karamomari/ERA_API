using System.ComponentModel.DataAnnotations;

namespace ERAAPI.DTO.UserDTO
{
    public class UserRequestDto
    {

        public decimal UserId { get; set; }

        [Required, StringLength(50)]
        public string UserName { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

        public bool Active { get; set; }

        [Required]
        public decimal RoleId { get; set; }

        public decimal EmployeeId { get; set; }
        public decimal ManagerId { get; set; }
        public decimal BankId { get; set; }
        public decimal GodownId { get; set; }

        [StringLength(200)]
        public string Narration { get; set; }

        public DateTime ExtraDate { get; set; } = DateTime.UtcNow;
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
    }
}

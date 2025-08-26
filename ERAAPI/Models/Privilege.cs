namespace ERAAPI.Models
{
    public class Privilege
    {
        public decimal PrivilegeId { get; set; }
        public decimal RoleId { get; set; }

        public string FormName { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public DateTime? ExtraDate { get; set; }
    }
}

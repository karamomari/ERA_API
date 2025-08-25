namespace ERAAPI.DTO.LoginDTO
{
    public class LoginResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public decimal UserId { get; set; }
        public string UserName { get; set; }
        public decimal? RoleId { get; set; }

    }
}

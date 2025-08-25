namespace ERAAPI.DTO
{
    public class GeneralResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}

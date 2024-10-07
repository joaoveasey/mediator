namespace mediator_app4_mediatr_and_cqrs_2.Models
{
    public class CustomResult<T>
    {
        public CustomResult(string message = "", bool success = true, T?  data = default)
        {
            Message = message;
            Success = success;
            Data = data;
        }

        public string Message { get; set; }
        public bool Success { get; set; }
        public T? Data { get; set; }
    }
}

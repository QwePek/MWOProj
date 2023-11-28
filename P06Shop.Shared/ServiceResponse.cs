namespace P06Shop.Shared
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; } = "Cannot invoke operation";
    }
}

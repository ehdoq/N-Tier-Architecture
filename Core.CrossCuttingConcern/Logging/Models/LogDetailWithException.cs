namespace Core.CrossCuttingConcern.Logging.Models
{
    public class LogDetailWithException : LogDetail
    {
        public string? ExceptionMessage { get; set; }
    }
}
namespace Core.CrossCuttingConcern.Exceptions.ExceptionModels
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {

        }
    }
}
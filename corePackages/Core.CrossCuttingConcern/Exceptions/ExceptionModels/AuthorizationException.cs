namespace Core.CrossCuttingConcern.Exceptions.ExceptionModels
{
    public class AuthorizationException : Exception
    {
        public AuthorizationException(string message) : base(message)
        {

        }
    }
}
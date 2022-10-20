namespace Core.Application.Interfaces.Authorization
{
    public interface ISecuredRequest
    {
        public string[] Roles { get; }
    }
}
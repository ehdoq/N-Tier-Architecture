using Application.Features.Auths.DTOs;
using Core.Security.DTOs;
using MediatR;

namespace Application.Features.Auths.Commands.Register
{
    public class RegisterCommand : IRequest<RegisteredDto>
    {
        public UserRegisterDto? UserRegisterDto { get; set; }
        public string? IpAddress { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisteredDto>
        {
            public Task<RegisteredDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
                // TODO: SELA
            }
        }
    }
}
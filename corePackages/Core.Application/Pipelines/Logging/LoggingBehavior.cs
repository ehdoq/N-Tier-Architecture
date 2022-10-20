using Core.Application.Interfaces.Logging;
using Core.CrossCuttingConcern.Logging.Models;
using Core.CrossCuttingConcern.Logging.Serilog;
using MediatR;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Core.Application.Pipelines.Logging
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
                                                        where TRequest : IRequest<TResponse>, ILoggableRequest
    {
        private readonly LoggerService _loggerService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoggingBehavior(LoggerService loggerService, IHttpContextAccessor httpContextAccessor)
        {
            _loggerService = loggerService;
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            List<LogParameter> logParameters = new()
            {
                new LogParameter
                {
                    Type = request.GetType().Name,
                    Value = request
                }
            };

            LogDetail logDetail = new()
            {
                MethodName = next.Method.Name,
                Parameters = logParameters,
                User = _httpContextAccessor.HttpContext == null ||
                       _httpContextAccessor.HttpContext.User.Identity.Name == null 
                       ? "?" : _httpContextAccessor.HttpContext.User.Identity.Name
            };

            _loggerService.Info(JsonConvert.SerializeObject(logDetail));

            return next();
        }
    }
}
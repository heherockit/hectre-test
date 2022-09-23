using HectreTest.Core;
using MediatR;

namespace HectreTest.Api;

public class HarvestReportQuery : IRequest<IEnumerable<Orchard>?>
{
    internal class Handler : IRequestHandler<HarvestReportQuery, IEnumerable<Orchard>?>
    {
        private readonly ILogger<Handler> _logger;
        private readonly IRepository<Orchard> _repos;

        public Handler(ILogger<Handler> logger
            , IRepository<Orchard> repos)
        {
            _logger = logger;
            _repos = repos;
        }

        public async Task<IEnumerable<Orchard>?> Handle(HarvestReportQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _repos.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{this.GetType().FullName} EXCEPTION!");
                return default;
            }
        }
    }
}
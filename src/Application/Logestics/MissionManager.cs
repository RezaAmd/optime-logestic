using Domain.Entities.Logestics;

namespace Application.Logestics
{
    public class MissionManager
    {
        #region DI & Ctor

        private readonly ILogger<MissionManager> _logger;
        private readonly IApplicationDbContext _context;
        public MissionManager(IApplicationDbContext context,
            ILogger<MissionManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion

        #region Methods

        public async Task<bool> CreateMissionAsync(TransportMissionEntity transportMissionEntity,
            CancellationToken cancellationToken = default)
        {
            // TODO:
            // Insert to database.
            return true;
        }

        #endregion
    }
}
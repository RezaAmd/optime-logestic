namespace Application.Logestics
{
    internal class DriverService
    {
        #region DI & Ctor

        private readonly ILogger<MissionManager> _logger;
        private readonly IApplicationDbContext _context;
        public DriverService(IApplicationDbContext context,
            ILogger<MissionManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion

        #region Methods



        #endregion

    }
}
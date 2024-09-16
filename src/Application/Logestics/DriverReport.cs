namespace Application.Logestics
{
    internal class DriverReport
    {
        #region DI & Ctor

        private readonly ILogger<MissionManager> _logger;
        private readonly IApplicationDbContext _context;
        public DriverReport(IApplicationDbContext context,
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
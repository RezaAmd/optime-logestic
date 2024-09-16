namespace Application.Logestics
{
    internal class MissionReport
    {
        #region DI & Ctor

        private readonly ILogger<MissionManager> _logger;
        private readonly IApplicationDbContext _context;
        public MissionReport(IApplicationDbContext context,
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
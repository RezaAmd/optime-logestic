using MediatR;

namespace Application.Logestics.Commands
{
    public class CreateMissionCommand : IRequest<bool>
    {

    }

    internal class CreateMissionCommandHsndler : IRequestHandler<CreateMissionCommand, bool>
    {
        #region DI & Ctor

        private readonly MissionManager _missionManager;

        public CreateMissionCommandHsndler(DriverService _driverService)
        {
            
        }

        #endregion

        public async Task<bool> Handle(CreateMissionCommand request, CancellationToken cancellationToken)
        {
            // Create new mission instance.

            return true;
        }
    }
}

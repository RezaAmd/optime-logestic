using Domain.Entities.Directories;

namespace Domain.Entities.Logestics
{
    public class TransportMissionEntity : BaseEntity
    {
        public TransportMissionStatus TransportMissionStatusId { get; set; } = TransportMissionStatus.Pending;
        public Guid FromLocationId { get; private set; }
        public Guid ToLocationId { get; private set; }

        #region Relations

        public virtual LocationEntity? FromLocation { get; set; }
        public virtual LocationEntity? ToLocation { get; set; }

        #endregion

        #region Ctor

        public TransportMissionEntity(Guid fromLocationId, Guid toLocationId)
        {
            FromLocationId = fromLocationId;
            ToLocationId = toLocationId;
        }

        #endregion
    }
}
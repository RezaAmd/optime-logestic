namespace Domain.Entities.Logestics
{
    public class ShipmentEntity : BaseEntity
    {
        public int TotalWeight { get; set; }

        public Guid MissionId { get; private set; }

        #region Relations

        //public virtual ICollection<ShipmentItemEntity>? ShipmentItems { get; set; }

        #endregion

        #region Ctors

        public ShipmentEntity()
        {
            
        }

        #endregion
    }
}
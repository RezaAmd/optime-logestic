namespace Domain.Entities.Logestics
{
    public class ShipmentItemEntity : BaseEntity
    {
        // ...
        //public Guid ShipmentId { get; private set; }
        //public ShipmentItemType ItemTypeId { get; set; } = ShipmentItemType.Other;

        #region Relations

        //public virtual ShipmentEntity? Shipment { get; set; }

        #endregion

        #region Ctors

        //public ShipmentItemEntity(Guid shipmentId)
        //{
        //    if (shipmentId == Guid.Empty)
        //        throw new ArgumentNullException("Shipment id cannot be null or empty!");
        //    ShipmentId = shipmentId;
        //}

        #endregion
    }
}
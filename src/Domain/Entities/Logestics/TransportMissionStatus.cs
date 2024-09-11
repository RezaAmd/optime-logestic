namespace Domain.Entities.Logestics
{
    public enum TransportMissionStatus
    {
        // تعریف شد
        Pending = 5,
        // تعریف شد
        ReadyToShipping = 10,
        // تأیید شده برای حمل و نقل
        ApprovedToShipping = 15,
        // درحال پردازش / درحال حمل
        Proccessing = 20,
        // وصول شد
        Shipped = 25,
        // بصورت جزوئی منتقل شد
        PartiallyShipped = 30,
        // لغو شد
        Canceled = 35
    }
}

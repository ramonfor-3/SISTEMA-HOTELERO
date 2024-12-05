namespace SISTEMA_HOTELERO.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }

        public Booking Booking { get; set; }
    }

    public enum PaymentMethod
    {
        CreditCard,
        PayPal,
        BankTransfer
    }

    public enum PaymentStatus
    {
        Successful,
        Failed,
        Pending
    }

}

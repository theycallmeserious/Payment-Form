namespace PaymentAPI.Dtos
{
    public class PaymentDto
    {
        public string CardOwnerName { get; set; } = "";
        public string CardNumber { get; set; } = "";
        public string ExpirationDate { get; set; } = "";
        public string SecurityCode { get; set; } = "";
    }
}

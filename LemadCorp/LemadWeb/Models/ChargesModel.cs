namespace LemadWeb.Models {
    public class ChargesModel {
        public string Token { get; set; }
        public string Description { get; set; }
        public long AmountInCents { get; set; }
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}

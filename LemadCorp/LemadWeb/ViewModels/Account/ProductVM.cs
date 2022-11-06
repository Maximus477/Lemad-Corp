namespace LemadWeb.ViewModels.Account
{
    public class ProductVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal getTotalPrice()
        {
            decimal TotalPrice = Price * Quantity;

            return TotalPrice;
        }
    }

}

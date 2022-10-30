using System.Collections.Generic;

namespace LemadWeb.ViewModels.Product
{
    public class CartVM
    {
        public Dictionary<string, string> Products { get; set; }

        public CartVM(Dictionary<string, string> products)
        { Products = products; }
    }
}

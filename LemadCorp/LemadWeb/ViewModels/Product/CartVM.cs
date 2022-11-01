using System.Collections.Generic;

namespace LemadWeb.ViewModels.Product
{
    public class CartVM
    {
        public Dictionary<int, int> Products { get; set; }

        public CartVM(Dictionary<int, int> products)
        { Products = products; }
    }
}

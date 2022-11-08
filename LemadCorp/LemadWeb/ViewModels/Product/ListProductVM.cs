using System.Collections.Generic;

namespace LemadWeb.ViewModels.Product
{
    public class ListProductVM
    {
        public List<string> SearchFilter { get; set; }
        public string PriceFilter { get; set; }
        public string StateFilter { get; set; }
        public string CategoryFilter { get; set; }
        public string DiscountFilter { get; set; }
        public string SortOrder { get; set; }
        public string NameSortOrder { get; set; }
        public string PriceSortOrder { get; set; }
        public string DateSortOrder { get; set; }
        public string DiscountSortOrder { get; set; }

        public ListProductVM(List<string> searchFilter,
                             string priceFilter,
                             string stateFilter,
                             string categoryFilter,
                             string discountFilter,
                             string sortOrder,
                             string nameSortOrder,
                             string priceSortOrder,
                             string dateSortOrder,
                             string discountSortOrder)
        {
            SearchFilter = searchFilter;
            PriceFilter = priceFilter;
            StateFilter = stateFilter;
            CategoryFilter = categoryFilter;
            DiscountFilter = discountFilter;
            SortOrder = sortOrder;
            NameSortOrder = nameSortOrder;
            PriceSortOrder = priceSortOrder;
            DateSortOrder = dateSortOrder;
            DiscountSortOrder = discountSortOrder;
        }

        public string GetSearch() {
            string list = "";

            foreach (string item in SearchFilter)
                list += item + ",";

            list = list.Substring(0, list.Length-1);

            return list;
        }
    }
}

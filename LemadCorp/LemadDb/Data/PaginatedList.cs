using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Data
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public string Search { get; private set; }
        public string SortOrder { get; private set; }
        public string PriceFilter { get; set; }
        public string StateFilter { get; set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize, string search, string sortOrder, string priceFilter, string stateFilter)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
            Search = search;
            SortOrder = sortOrder;
            PriceFilter = priceFilter;
            StateFilter = stateFilter;
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public static PaginatedList<T> CreateAsync(List<T> source, int pageIndex, int pageSize, string search, string sortOrder, string priceFilter, string stateFilter)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pageSize, search, sortOrder, priceFilter, stateFilter);
        }
    }
}

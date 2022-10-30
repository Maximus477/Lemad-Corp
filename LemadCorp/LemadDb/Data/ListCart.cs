using LemadDb.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Data
{
    public class ListCart : Dictionary<Product, string>
    {
        public Dictionary<Product, string> Products { get; set; }
        public bool Verification { get; set; }
        public byte CountProduct { get; set; }

        public ListCart(Dictionary<Product, string> products, bool verification, byte countProduct)
        {
            Products = products;
            Verification = verification;
            CountProduct = countProduct;
        }

        public static ListCart CreateAsync(Dictionary<Product, string> products, bool verification)
        {
            byte count = (byte)products.Count;

            return new ListCart(products, verification, count);
        }
    }
}

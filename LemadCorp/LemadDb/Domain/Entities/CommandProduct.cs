using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Domain.Entities
{
    public class CommandProduct
    {
        public Guid Id { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public CommandProduct(int productID, int quantity)
        {
            this.ProductID = productID;
            this.Quantity = quantity;
        }
    }
}

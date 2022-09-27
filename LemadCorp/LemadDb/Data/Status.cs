using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Data
{
    public class Status
    {
        public enum ProductStatus
        {
            AVAILABLE,
            INCOMMANDE,
            UNAVAILABLE,
            LIQUIDATION,
            PROMOTION
        };
    }
}

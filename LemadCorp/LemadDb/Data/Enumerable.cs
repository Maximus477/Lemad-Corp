using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Data
{
    public class Enumerable
    {
        public enum ProductCategory
        {
            DRIVER,
            PRINCIPAL,
            POWERUNIT,
            RACEENGINEER,
            TECHNICALCHIEF
        };

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

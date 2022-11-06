using LemadDb.Domain.Entities;
using System;
using System.Collections.Generic;
using static LemadDb.Data.Enumerable;

namespace LemadWeb.ViewModels.Account
{
    public class MyCommandsVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FullAddress { get; set; }
        public decimal Total { get; set; }
        public CommandStatus Status { get; set; }
        public List<ProductVM> Products { get; set; }

        public string GetTotal()
        {
            return FormatNumber(Total) + "$";
        }

        internal static long MaxThreeSignificantDigits(long x)
        {
            int i = (int)Math.Log10(x);
            i = Math.Max(0, i - 2);
            i = (int)Math.Pow(10, i);
            return x / i * i;
        }
        public string FormatNumber(decimal num)
        {
            num = MaxThreeSignificantDigits((long)num);
            Double dnum = Decimal.ToDouble(num);

            if (num >= 100000000)
                return (dnum / 1000000D).ToString("0.#M");
            if (num >= 1000000)
                return (dnum / 1000000D).ToString("0.##M");
            if (num >= 100000)
                return (dnum / 1000D).ToString("0k");
            if (num >= 100000)
                return (dnum / 1000D).ToString("0.#k");
            if (num >= 1000)
                return (dnum / 1000D).ToString("0.##k");
            return dnum.ToString("#,0");
        }
    }
}

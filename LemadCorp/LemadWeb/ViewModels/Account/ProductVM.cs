using System;

namespace LemadWeb.ViewModels.Account
{
    public class ProductVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string getTotalPrice()
        {
            decimal TotalPrice = Price * Quantity;

            return FormatNumber(TotalPrice) + "$";
        }

        public string GetPrice()
        {
            return FormatNumber(Price) + "$";
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

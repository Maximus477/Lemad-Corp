using System;

namespace LemadWeb.ViewModels.Product
{
    public class CartInfoVM
    {
        public decimal Total { get; set; }
        public string GetTotal
        {
            get { return FormatNumber(Total) + "$"; }
        }

        public decimal TotalWithDiscount { get; set; }
        public string GetTotalWithDiscount
        {
            get { return FormatNumber(TotalWithDiscount) + "$"; }
        }

        public decimal TotalDiscount { get; set; }
        public string GetTotalDiscount
        {
            get { return FormatNumber(TotalDiscount) + "$"; }
        }

        public decimal TotalWithTaxes { get; set; }
        public string GetTotalWithTaxes
        {
            get { return FormatNumber(TotalWithTaxes) + "$"; }
        }

        public byte CountProduct { get; set; }

        internal static long MaxThreeSignificantDigits(long x)
        {
            int i = (int)Math.Log10(x);
            i = Math.Max(0, i - 2);
            i = (int)Math.Pow(10, i);
            return x / i * i;
        }
        private string FormatNumber(decimal num)
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

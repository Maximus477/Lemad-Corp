using System;

namespace LemadWeb.ViewModels.Product
{
    public class PaymentInfoVM
    {
        public string ReceiptEmail { get; set; }
        public string ReceiptPhone { get; set; }
        public string ReceiptName { get; set; }
        public string ReceiptAddress { get; set; }
        public string ReceiptCity { get; set; }
        public string ReceiptProvince { get; set; }
        public string ReceiptCountry { get; set; }
        public string ReceiptPostalCode { get; set; }
        public string ReceiptLast4 { get; set; }
        public DateTime PurchaseTime { get; set; }
    }
}

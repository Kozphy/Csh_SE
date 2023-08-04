using System.ComponentModel.DataAnnotations;

namespace ECPAY.Models
{
        public partial class ECPayOrderCreateDataJSON
        {

                public string? MerchantID { get; set; }
                public string? MerchantTradeNo { get; set; }

                //TODO: need to convert dd/MM/yyyy HH:mm:ss -> yyyy/MM/dd HH:mm:ss
                public string? MerchantTradeDate { get; set; }

                public string? PaymentType { get; set; }
                public int TotalAmount { get; set; }
                public string? TradeDesc { get; set; }
                public string? ItemName { get; set; }
                public string? ReturnURL { get; set; }
                public string? ChoosePayment { get; set; }
                public int EncryptType { get; set; }
                public string? CheckMacValue { get; set; }
        }
}

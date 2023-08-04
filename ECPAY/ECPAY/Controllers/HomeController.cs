using ECPAY.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ECPay.Payment.Integration;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace ECPAY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        private string BuildCheckMacValue(string HashKey, string HashIV, string parameters, int encryptType = 0)
        {
            string szCheckMacValue = String.Empty;
            string reshash = String.Empty;
            // 產生檢查碼。
            szCheckMacValue = String.Format("HashKey={0}{1}&HashIV={2}", HashKey, parameters, HashIV);
            szCheckMacValue = HttpUtility.UrlEncode(szCheckMacValue).ToLower();
            if (encryptType == 1)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(szCheckMacValue));
                    foreach (byte b in hashValue)
                    {
                        reshash += $"{b:X2}";
                    }
                }
            }
            else
            {
                throw new Exception("please input one at EncryptType");
            }
            return reshash;
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] ECPayOrderCreateDataJSON data)
        {
            //DateTime date = DateTime.ParseExact(new DateTime().ToString(),"yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);

            List<string> enErrors = new List<string>();

            string HashKey = "spPjZn66i0OhqJsQ";
            string HashIV = "hT5OJckN45isQTTs";
            string date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            data.MerchantTradeDate = date;
            data.CheckMacValue = BuildCheckMacValue(HashKey, HashIV, data.CheckMacValue, data.EncryptType).ToUpper();


            //return Json(data);

            foreach (PropertyDescriptor desc in TypeDescriptor.GetProperties(data))
            {
                string name = desc.Name;
                object value = desc.GetValue(data);
                Console.WriteLine("{0}={1}", name, value);
            }

            try
            {
                using (AllInOne oPayment = new AllInOne())
                {
                    /* 服務參數 */
                    oPayment.ServiceMethod = ECPay.Payment.Integration.HttpMethod.HttpPOST;
                    oPayment.ServiceURL = "https://payment-stage.ecpay.com.tw/Cashier/AioCheckOut/V5";
                    oPayment.HashKey = HashKey; //ECPay提供的Hash Key
                    oPayment.HashIV = HashIV; //ECPay提供的Hash IV
                    oPayment.MerchantID = data.MerchantID; //ECPay提供的特店編號

                    /* 基本參數 */
                    oPayment.Send.ReturnURL = "http://example.com";//付款完成通知回傳的網址
                    oPayment.Send.ClientBackURL = data.ReturnURL; //瀏覽器端返回的廠商網址
                    oPayment.Send.OrderResultURL = "http://localhost:52413/CheckOutFeedback.aspx"; //瀏覽器端回傳付款結果網址
                    oPayment.Send.MerchantTradeNo = "ECPay" + new Random().Next(0, 99999).ToString(); //廠商的交易編號
                    oPayment.Send.MerchantTradeDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); //廠商的交易時間
                    oPayment.Send.TotalAmount = Decimal.Parse("3280");//交易總金額
                    oPayment.Send.TradeDesc = "交易描述";//交易描述
                    oPayment.Send.ChoosePayment = PaymentMethod.ALL;//使用的付款方式
                    oPayment.Send.Remark = "";//備註欄位
                    oPayment.Send.ChooseSubPayment = PaymentMethodItem.None;//使用的付款子項目
                    oPayment.Send.NeedExtraPaidInfo = ExtraPaymentInfo.Yes;//是否需要額外的付款資訊
                    oPayment.Send.DeviceSource = DeviceType.PC;//來源裝置
                    oPayment.Send.IgnorePayment = ""; //不顯示的付款方式
                    oPayment.Send.PlatformID = "";//特約合作平台商代號
                    oPayment.Send.CustomField1 = "";
                    oPayment.Send.CustomField2 = "";
                    oPayment.Send.CustomField3 = "";
                    oPayment.Send.CustomField4 = "";
                    oPayment.Send.EncryptType = 1;

                    //訂單的商品資料
                    oPayment.Send.Items.Add(new Item()
                    {
                        Name = "蘋果",//商品名稱
                        Price = Decimal.Parse("3280"),//商品單價
                        Currency = "新台幣",//幣別單位
                        Quantity = Int32.Parse("1"),//購買數量
                        URL = "http://google.com",//商品的說明網址

                    });
                    /* 產生訂單 */
                    enErrors.AddRange(oPayment.CheckOut());
                    //Console.WriteLine(res);
                }

            }
            catch (Exception ex)
            {
                enErrors.Add(ex.Message);
            }
            finally
            {
                if (enErrors.Count() > 0)
                {
                    string szErrorMessage = String.Join("\\r\\n", enErrors);
                    Console.WriteLine(szErrorMessage);
                }
            }
            return View();
            //return Json(data);
        }

        public IActionResult OrderReturn()
        {
            return View();
        }

        public IActionResult OrderResult()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
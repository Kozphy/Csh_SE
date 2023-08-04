using Microsoft.AspNetCore.Mvc;
using SendEmail.Models;
using System.Diagnostics;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;


namespace SendEmail.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("api/GetMailTrapAccess")]
        [HttpGet]
        public ActionResult GetMailAccess() {
            Dictionary<string, string> mail_access = new Dictionary<string, string>()
            {
                { "mail_server", DotNetEnv.Env.GetString("SEND_MAIL_SERVER")},
                { "mail_username", DotNetEnv.Env.GetString("SEND_MAIL_USERNAME")},
                { "mail_password", DotNetEnv.Env.GetString("SEND_MAIL_PASSWORD")},
                { "mail_securetoken", DotNetEnv.Env.GetString("SEND_MAIL_SECURETOKEN")},
            };

            return Json(mail_access);
        }

        [HttpPost]
        [Route("MailKit/SendMail", Name ="SendMail")]
        public void SendMail([FromForm] string userEmail) {
            Console.WriteLine(userEmail);

            //return;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("GoSweet", "GoSweet@gmail.com"));
            message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "testdbdf0147@gmail.com"));
            message.Subject = "check for reset password'?";
            var builder = new BodyBuilder();
            builder.HtmlBody = "<a href=http://localhost:5189/Home/Privacy>click here to reset password</a>";
            message.Body = builder.ToMessageBody();

//            message.Body = new TextPart("plain")
//            {
//                Text = @"Hey Chandler,

//I just wanted to let you know that Monica and I were going to go play some paintball, you in?

//-- Joey"
//            };

            using (var client = new SmtpClient())
            {
                string smtpServer = "smtp.gmail.com";
                client.Connect(smtpServer, 465, true);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("dbdf0147@gmail.com", "lojqyqxyyhewnjrf");

                client.Send(message);
                client.Disconnect(true);
                Console.WriteLine("Email Send");
            }
        }

        [Route("Login", Name ="Login")]
        public void Login() { 

        }

        public IActionResult Index()
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
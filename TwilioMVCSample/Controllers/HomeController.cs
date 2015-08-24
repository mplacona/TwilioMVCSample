using System.Web.Mvc;
using Twilio;
using Twilio.TwiML.Mvc;

namespace TwilioMVCSample.Controllers
{
    public class HomeController : TwilioController
    {
        // GET: Home
        public ActionResult Index()
        {
            string AccountSid = "mySID";
            string AuthToken = "myAuth";

            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            return Content(twilio.ApiVersion);
        }
    }
}
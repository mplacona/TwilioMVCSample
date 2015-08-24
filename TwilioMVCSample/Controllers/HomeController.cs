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
            const string accountSid = "mySID";
            const string authToken = "myAuth";

            var twilio = new TwilioRestClient(accountSid, authToken);
            return Content(twilio.ApiVersion);
        }
    }
}
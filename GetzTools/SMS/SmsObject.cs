using static GetzTools.Commons;

namespace GetzTools.SMS
{
    public class SmsObject
    {
        public string UrlApiSmoovIM { get; set; }
        public string AccessKeyApiSmoovIM { get; set; }
        public string SmoovImUserName { get; set; }
        public string SmoovImPassword { get; set; }
        public Servers Server { get; set; }
        public string SmsRecipients { get; set; }
        public string SmsMessage { get; set; }
        public string SmsResult { get; set; }
    }
}

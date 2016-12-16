using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetzTools
{
    public class UrlSmoovIm
    {
            public const string SendSms = "{0}/api/sms";
            public const string RequestApiKeys = "{0}/api/request_api_keys";
            public const string OneTimeToken = "{0}/api/one_time_token";
    }

    public class StatusApiSmoovIM
    {
        public const string Token = "token";
        public const string Succcess = "1000";
    }

    public class SmoovIMKeyword
    {
        public const string Apikey = "apikey";
        public const string Message = "message";
        public const string Recipients = "recipients";
        public const string Encoding = "encoding";
        public const string Timestamp = "timestamp";
        public const string Signature = "signature";
        public const string Text = "text";
        public const string Token = "token";
        public const string Email = "email";
        public const string Password = "password";
        public const string ApiAccessKey = "api_access_key";
    }
}

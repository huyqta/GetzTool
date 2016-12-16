using GetzTools.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GetzTools.SMS
{
    public static class SmoovImHelper
    {
        /// <summary>
        /// Sends the SMS.
        /// </summary>
        /// <param name="smsModel">The SMS model.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="secrect">The secrect.</param>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        /// <author>"Dao.Nguyen"</author>
        /// <datetime>7/8/2015-3:32 PM</datetime>
        public static SmoovIMResponse SendSms(SmsObject smsObject, string apiKey, string timestamp, string secrect, string url)
        {
            if (smsObject != null)
            {
                var data = new Dictionary<string, string>
            {
                {SmoovIMKeyword.Apikey, apiKey},
                {SmoovIMKeyword.Message, smsObject.SmsMessage},
                {SmoovIMKeyword.Recipients, smsObject.SmsRecipients},
                {SmoovIMKeyword.Text, SmoovIMKeyword.Text},
                {SmoovIMKeyword.Timestamp, timestamp}
            };

                var signature = ApiSmoovHelper.Sign(data, secrect);

                data.Add(SmoovIMKeyword.Signature, signature);

                var datapost = ApiSmoovHelper.GenerateStringPost(data);

                var apiResultStr = ExecuteRequest(url, datapost);

                var apiResult = JsonConvert.DeserializeObject<SmoovIMResponse>(apiResultStr);

                return apiResult;
            }

            return null;
        }

        /// <summary>
        /// Requests the API keys API.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="apikey">The apikey.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <author>"Dao.Nguyen"</author>
        /// <datetime>7/8/2015-2:55 PM</datetime>
        public static SmoovIMResponse RequestApiKeysApi(string username, string password, string apikey, string timestamp, string token, string urlApiSmoovIM)
        {
            var urlRequestApiKeys = string.Format(
                UrlSmoovIm.RequestApiKeys, urlApiSmoovIM);

            var data = new Dictionary<string, string>
            {
                {SmoovIMKeyword.Token, token},
                {SmoovIMKeyword.Timestamp, timestamp},
                {SmoovIMKeyword.Email, username},
                {SmoovIMKeyword.Password, password}
            };

            var datapost = ApiSmoovHelper.GenerateStringPost(data);

            var apiResultStr = ExecuteRequest(urlRequestApiKeys, datapost);

            var apiResult = JsonConvert.DeserializeObject<SmoovIMResponse>(apiResultStr);

            return apiResult;
        }
        /// <summary>
        /// Gets the one time token.
        /// </summary>
        /// <param name="accessKey">The access key.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <returns></returns>
        /// <author>"Dao.Nguyen"</author>
        /// <datetime>7/8/2015-2:56 PM</datetime>
        public static SmoovIMResponse GetOneTimeToken(string accessKey, string timestamp, string urlApiSmoovIM)
        {
            var urlOneTimeToken = string.Format(UrlSmoovIm.OneTimeToken, urlApiSmoovIM);

            var data = new Dictionary<string, string>
            {
                {SmoovIMKeyword.ApiAccessKey, accessKey},
                {SmoovIMKeyword.Timestamp, timestamp}
            };

            var datapost = ApiSmoovHelper.GenerateStringPost(data);

            var apiResultStr = ExecuteRequest(urlOneTimeToken, datapost);

            var apiResult = JsonConvert.DeserializeObject<SmoovIMResponse>(apiResultStr);

            return apiResult;
        }

        /// <summary>
        /// Executes the request.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="sdata">The sdata.</param>
        /// <returns></returns>
        /// <author>"Dao.Nguyen"</author>
        /// <datetime>7/8/2015-2:56 PM</datetime>
        public static string ExecuteRequest(string url, string sdata)
        {

            try
            {
                using (var wb = new WebClient())
                {
                    var nvData = HttpUtility.ParseQueryString(sdata);

                    var response = wb.UploadValues(url, "POST", nvData);

                    var resultString = wb.Encoding.GetString(response);

                    return resultString;
                }
            }
            catch (Exception ex)
            {
                var pageContent = string.Format("SmoovImHelper.ExecuteRequest error with message:{0} stacktrace:{1} ",
                    ex.Message, ex.StackTrace);

                return pageContent;
            }
        }
    }
}

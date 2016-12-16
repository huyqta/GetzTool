using GetzTools.PushNotification;
using GetzTools.SMS;
using Newtonsoft.Json.Linq;
using PushSharp.Apple;
using System;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace GetzTools
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private SmsObject smsObj;
        private PushNotificationObject pushObj;
        public static frmMain _frmMain;

        public frmMain()
        {
            InitializeComponent();
            UpdateServerSmoovImConfiguration();
            UpdateEnvironmentPushNotification();
            _frmMain = this;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void btnSend_Click(object sender, EventArgs e)
        {
            UpdateServerSmoovImConfiguration();

            btnSend.Enabled = false;
            btnSend.Text = "SENDING...";
            ///////////////////////////////
            smsObj.SmsRecipients = txtSmsRecipients.Text.Replace("+", "");
            smsObj.SmsMessage = txtSmsMessage.Text;
            txtSmsResult.AppendText("===" + DateTime.Now.ToString() + "===============" + Environment.NewLine);
            SmoovIMResponse smoovIMResponse = CallApiSendSms(smsObj);
            txtSmsResult.AppendText(" Message: " + smoovIMResponse.Message + Environment.NewLine);
            txtSmsResult.AppendText(" Response: " + smoovIMResponse.Response + Environment.NewLine);
            txtSmsResult.AppendText(" Status: " + smoovIMResponse.Status + Environment.NewLine);
            txtSmsResult.AppendText("---------------------------------------------------------------------------" + Environment.NewLine);
            txtSmsResult.SelectionStart = txtSmsResult.Text.Length;
            txtSmsResult.ScrollToCaret();
            ///////////////////////////////
            btnSend.Text = "SEND";
            btnSend.Enabled = true;
        }

        private void rdSms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServerSmoovImConfiguration();
        }

        private void UpdateServerSmoovImConfiguration()
        {
            if (rdSmsUAT.Checked)
            {
                smsObj = new Commons().SettingConfigurationSms("UAT");
                smsObj.Server = Commons.Servers.UAT;
            }
            else
            {
                smsObj = new Commons().SettingConfigurationSms("LIVE");
                smsObj.Server = Commons.Servers.LIVE;
            }
        }

        public SmoovIMResponse CallApiSendSms(SmsObject smsObject)
        {

            var timestamp = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString("###");

            var urlSms = string.Format(UrlSmoovIm.SendSms, smsObject.UrlApiSmoovIM);

            var accessKey = smsObject.AccessKeyApiSmoovIM;

            SmoovIMResponse apiResult = null;

            var responseOneTime = SmoovImHelper.GetOneTimeToken(accessKey, timestamp, smsObject.UrlApiSmoovIM);
            if (smsObject != null)
            {
                var stSmsModel = new JavaScriptSerializer().Serialize(smsObject);

                if (responseOneTime != null && responseOneTime.Status.Equals(StatusApiSmoovIM.Succcess))
                {
                    var responseRequestApiKey = SmoovImHelper.RequestApiKeysApi(smsObject.SmoovImUserName, smsObject.SmoovImPassword, accessKey, timestamp,
                        responseOneTime.Response.Data.Token, smsObject.UrlApiSmoovIM);

                    if (responseRequestApiKey != null && responseRequestApiKey.Status.Equals(StatusApiSmoovIM.Succcess))
                    {
                        apiResult = SmoovImHelper.SendSms(smsObject, responseRequestApiKey.Response.Data.Apikey, timestamp,
                            responseRequestApiKey.Response.Data.Secret, urlSms);

                        if (responseRequestApiKey.Status.Equals(StatusApiSmoovIM.Succcess)) return apiResult;

                        var stResponseRequestApiKey = new JavaScriptSerializer().Serialize(responseRequestApiKey);

                        apiResult = responseRequestApiKey;

                        var stApiResult = new JavaScriptSerializer().Serialize(apiResult);

                        var stError = string.Format("CallApiSendSMS Failed with stSmsModel: {0} stResponseRequestApiKey: {1} stApiResult: {2}",
                            stSmsModel, stResponseRequestApiKey, stApiResult);
                    }
                    else
                    {
                        var stResponseRequestApiKey = new JavaScriptSerializer().Serialize(responseRequestApiKey);

                        apiResult = responseRequestApiKey;

                        var stApiResult = new JavaScriptSerializer().Serialize(apiResult);

                        var stError = string.Format("CallApiSendSMS1 Failed with stSmsModel: {0} stResponseRequestApiKey: {1} stApiResult: {2}",
                            stSmsModel, stResponseRequestApiKey, stApiResult);
                    }
                }
                else
                {
                    var stResponseOneTime = new JavaScriptSerializer().Serialize(responseOneTime);

                    apiResult = responseOneTime;

                    var stApiResult = new JavaScriptSerializer().Serialize(apiResult);

                    var stError = string.Format("CallApiSendSMS2 Failed with stSmsModel: {0} stResponseOneTime: {1} stApiResult: {2}", stSmsModel,
                        stResponseOneTime, stApiResult);

                }
            }

            return apiResult;
        }

        private void UpdateEnvironmentPushNotification()
        {
            if (rdPushInternal.Checked)
            {
                pushObj = new Commons().SettingConfigurationPushNotification("INTERNAL");
            }
            else if (rdPushPublic.Checked)
            {
                pushObj = new Commons().SettingConfigurationPushNotification("PUBLIC");
            }
            else
            {
                pushObj = new Commons().SettingConfigurationPushNotification("ENTERPRISE");
            }
            pushObj.ListDevice = txtListDevicePush.Text.Split('\n');
            pushObj.Badge = txtPushBadge.Text;
            pushObj.Alert = txtPushMessages.Text;
        }

        private void rdPushNotification_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnvironmentPushNotification();
        }

        private void btnPushNotification_Click(object sender, EventArgs e)
        {
            UpdateEnvironmentPushNotification();

            btnPushNotification.Enabled = false;
            btnPushNotification.Text = "PUSHING...";
            ///////////////////////////////
            AllocConsole();
            SendIOSPushNotify(pushObj);
            ///////////////////////////////
            btnPushNotification.Text = "PUSH";
            btnPushNotification.Enabled = true;
        }

        public PushNotificationResponse SendIOSPushNotify(PushNotificationObject pushObject)
        {
            //Task<string> getStringTask = client.GetStringAsync("start");
            PushNotificationResponse response = new PushNotificationResponse();
            WebClient wc1 = new WebClient();
            var onlCert1 = wc1.DownloadData(pushObject.FileP12Name);
            // Configuration (NOTE: .pfx can also be used here)
            var config = new ApnsConfiguration(ApnsConfiguration.ApnsServerEnvironment.Production,
                onlCert1, pushObject.FileP12Password);

            // Create a new broker
            var apnsBroker = new ApnsServiceBroker(config);

            // Wire up events
            apnsBroker.OnNotificationFailed += (notification, aggregateEx) =>
            {

                aggregateEx.Handle(ex =>
                {

                    // See what kind of exception it was to further diagnose
                    if (ex is ApnsNotificationException)
                    {
                        var notificationException = (ApnsNotificationException)ex;

                        // Deal with the failed notification
                        var apnsNotification = notificationException.Notification;
                        var statusCode = notificationException.ErrorStatusCode;
                        System.Console.WriteLine($"Apple Notification Failed: ID={apnsNotification.Identifier}, Code={statusCode}");
                    }
                    else
                    {
                        // Inner exception might hold more useful information dows.Forms.RichTextBox)mFormMain.Controls.Find("txtPushResults", true)[0];
                        System.Console.WriteLine($"Apple Notification Failed for some unknown reason : {ex.InnerException}");
                    }

                    // Mark it as handled
                    return true;
                });
            };

            apnsBroker.OnNotificationSucceeded += (notification) =>
            {
                System.Console.WriteLine("Apple Notification Sent!");
            };

            // Start the broker
            apnsBroker.Start();
            string data = "{\"aps\":{\"badge\":" + pushObject.Badge + ", \"alert\": \"" + pushObject.Alert + "\", \"sound\": \"" + pushObject.AppleDeviceSoundNotify + "\"}}";
            foreach (var deviceToken in pushObject.ListDevice)
            {
                // Queue a notification to send
                apnsBroker.QueueNotification(new ApnsNotification
                {
                    DeviceToken = deviceToken,
                    Payload = JObject.Parse(data)
                });
            }
            // Stop the broker, wait for it to finish   
            // This isn't done after every message, but after you're
            // done with the broker
            apnsBroker.Stop();
            response.Message = "Success!";
            return response;
        }

    }
}

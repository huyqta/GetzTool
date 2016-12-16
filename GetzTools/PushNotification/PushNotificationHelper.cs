using Newtonsoft.Json.Linq;
using PushSharp.Apple;
using System.Collections.Generic;
using System.Net;

namespace GetzTools.PushNotification
{
    public class PushNotificationHelper
    {
        //frmMain mFormMain;

        public PushNotificationHelper()
        {
            //mFormMain = frm;
        }

        //public PushNotificationResponse SendIOSPushNotify(PushNotificationObject pushObject, System.Windows.Forms.RichTextBox mFormMain)
        //{
        //    PushNotificationResponse response = new PushNotificationResponse();
        //    WebClient wc1 = new WebClient();
        //    var onlCert1 = wc1.DownloadData(pushObject.FileP12Name);
        //    // Configuration (NOTE: .pfx can also be used here)
        //    var config = new ApnsConfiguration(ApnsConfiguration.ApnsServerEnvironment.Production,
        //        onlCert1, pushObject.FileP12Password);

        //    // Create a new broker
        //    var apnsBroker = new ApnsServiceBroker(config);

        //    // Wire up events
        //    apnsBroker.OnNotificationFailed += (notification, aggregateEx) =>
        //    {

        //        aggregateEx.Handle(ex =>
        //        {

        //            // See what kind of exception it was to further diagnose
        //            if (ex is ApnsNotificationException)
        //            {
        //                var notificationException = (ApnsNotificationException)ex;

        //                // Deal with the failed notification
        //                var apnsNotification = notificationException.Notification;
        //                var statusCode = notificationException.ErrorStatusCode;

        //                frmMain._frmMain.UpdatePushNotification($"Apple Notification Failed: ID={apnsNotification.Identifier}, Code={statusCode}");
        //            }
        //            else
        //            {
        //                // Inner exception might hold more useful information dows.Forms.RichTextBox)mFormMain.Controls.Find("txtPushResults", true)[0];
        //                frmMain._frmMain.AppendText($"Apple Notification Failed for some unknown reason : {ex.InnerException}");
        //            }

        //            // Mark it as handled
        //            return true;
        //        });
        //    };

        //    apnsBroker.OnNotificationSucceeded += (notification) =>
        //    {
        //        frmMain._frmMain.AppendText("Apple Notification Sent!");
        //    };

        //    // Start the broker
        //    apnsBroker.Start();
        //    string data = "{\"aps\":{\"badge\":" + pushObject.Badge + ", \"alert\": \"" + pushObject.Alert + "\", \"sound\": \"" + pushObject.AppleDeviceSoundNotify + "\"}}";
        //    foreach (var deviceToken in pushObject.ListDevice)
        //    {
        //        // Queue a notification to send
        //        apnsBroker.QueueNotification(new ApnsNotification
        //        {
        //            DeviceToken = deviceToken,
        //            Payload = JObject.Parse(data)
        //        });
        //    }

        //    //apnsBroker.QueueNotification(new ApnsNotification
        //    //{
        //    //    DeviceToken = "6ae4a26ba2e454118ffc6ffc907739a47da74fc7e09a1c31fef607c05a47e303",
        //    //    Payload = JObject.Parse("{\"aps\":{\"badge\":10, \"alert\": \"Huy Quan Test. 0123456 !*@&^!*^&@\", \"sound\": \"default\"}}")
        //    //});

        //    // Stop the broker, wait for it to finish   
        //    // This isn't done after every message, but after you're
        //    // done with the broker
        //    apnsBroker.Stop();
        //    response.Message = "Success!";
        //    return response;
        //}
    }
}

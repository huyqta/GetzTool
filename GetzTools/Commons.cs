using GetzTools.PushNotification;
using GetzTools.SMS;
using System.Configuration;

namespace GetzTools
{
    public class Commons
    {
        public enum Servers { LOCAL = 3, SIT = 2, UAT = 1, LIVE = 0};

        public SmsObject SettingConfigurationSms(string strServer)
        {
            SmsObject sms = new SmsObject();
            sms.UrlApiSmoovIM = ConfigurationManager.AppSettings[strServer + "_UrlApiSmoovIM"];
            sms.AccessKeyApiSmoovIM = ConfigurationManager.AppSettings[strServer + "_AccessKeyApiSmoovIM"];
            sms.SmoovImUserName = ConfigurationManager.AppSettings[strServer + "_SmoovImUserName"];
            sms.SmoovImPassword = ConfigurationManager.AppSettings[strServer + "_SmoovImPassword"];

            return sms;
        }

        public PushNotificationObject SettingConfigurationPushNotification(string strServer)
        {
            PushNotificationObject push = new PushNotificationObject();
            push.AppleDeviceSoundNotify = ConfigurationManager.AppSettings[strServer + "_AppleDeviceSoundNotify"];
            push.BundleId = ConfigurationManager.AppSettings[strServer + "_BundleId"];
            push.FileP12Name = ConfigurationManager.AppSettings[strServer + "_FileP12Name"];
            push.FileP12Password = ConfigurationManager.AppSettings[strServer + "_FileP12Password"];

            return push;
        }
    }
}

namespace GetzTools.PushNotification
{
    public class PushNotificationObject
    {
        public string Badge { get; set; }
        public string Alert { get; set; }
        public string FileP12Name { get; set; }
        public string FileP12Password { get; set; }
        public string AppleDeviceSoundNotify { get; set; }
        public string BundleId { get; set; }
        public string[] ListDevice { get; set; }
    }
}

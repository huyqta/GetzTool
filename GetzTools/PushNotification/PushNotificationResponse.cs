using GetzTools.SMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetzTools.PushNotification
{
    public class PushNotificationResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public ApiResponse Response { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetzTools.SMS
{
    public class SmoovIMResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public ApiResponse Response { get; set; }
    }
    public class ApiResponse
    {
        public ApiData Data { get; set; }
    }

    public class ApiData
    {
        public string Token { get; set; }
        public string GeneratedTime { get; set; }
        public string ExpiryTime { get; set; }
        public string Name { get; set; }
        public string SenderName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Modified { get; set; }
        public string Apikey { get; set; }
        public string Secret { get; set; }
    }
}

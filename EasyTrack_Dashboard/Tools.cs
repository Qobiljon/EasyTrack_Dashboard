using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EasyTrack_Dashboard
{
    internal struct Server
    {
        private string ip;
        private short port;

        public Server(string ip, short port)
        {
            this.ip = ip;
            this.port = port;
        }

        internal System.Net.IPAddress IP_Address { get { return System.Net.IPAddress.Parse(ip); } }
        internal short Port { get { return port; } }
    }
    class Tools
    {
        internal static void init()
        {
            httpClient.Timeout = new TimeSpan(hours: 0, minutes: 0, seconds: 2);
        }

        #region Constants
        internal const string REGISTER_API = "register";
        internal const string UNREGISTER_API = "unregister";
        internal const string AUTHENTICATE_API = "authenticate";
        #endregion

        #region Variables
        internal static Server server = new Server(ip: "165.246.43.162", port: 9876);
        private static readonly HttpClient httpClient = new HttpClient();
        #endregion

        internal static async Task<string> post(string api, Dictionary<string, string> body)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await httpClient.PostAsync(api, content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}

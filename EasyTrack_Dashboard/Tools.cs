using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    class Tools
    {
        #region Constants
        internal const string SERVER_URL = "http://165.246.43.162:36012";
        // internal const string SERVER_URL = "http://165.246.43.163:9876";

        internal const string API_REGISTER = "register";
        internal const string API_UNREGISTER = "unregister";
        internal const string API_AUTHENTICATE = "authenticate";
        internal const string API_SUBMIT_HEARTBEAT = "heartbeat";
        internal const string API_SUBMIT_DATA = "submit_data";
        internal const string API_NOTIFY = "notify";
        internal const string API_GET_PARTICIPANT_LIST = "get_participant_list";
        internal const string API_GET_UNIQUE_DATA_SOURCES = "get_unique_data_sources";
        internal const string API_CREATE_CAMPAIGN = "create_campaign";
        internal const string API_GET_CAMPAIGNS = "get_campaigns";
        internal const string API_GET_CAMPAIGN_DQ_VALUES = "handle_get_campaign_dq_values";
        internal const string API_CHECK_PARTICIPANT_AVAILABILITY = "check_participant_availability";
        internal const string API_DOWNLOAD_DEVICE_ICON = "device_image";
        #endregion

        internal async static Task<HttpResponseMessage> post(string api, Dictionary<string, string> body, byte[] fileContent = null)
        {
            if (fileContent == null)
                using (HttpClient client = new HttpClient())
                    return await client.PostAsync($"{SERVER_URL}/{api}", new FormUrlEncodedContent(body));
            else
                using (HttpContent bytesContent = new ByteArrayContent(fileContent))
                using (MultipartFormDataContent formData = new MultipartFormDataContent())
                using (HttpClient client = new HttpClient())
                {
                    foreach (var elem in body)
                        formData.Add(new StringContent(elem.Value), elem.Key, elem.Key);
                    formData.Add(bytesContent, "file", "file");
                    return await client.PostAsync($"{SERVER_URL}/{api}", formData);
                }
        }

        internal static void runOnUiThread(Control control, Action action)
        {
            control.BeginInvoke(action);
        }
    }

    // Result codes from server
    enum ServerResult
    {
        OK = 0,
        FAIL = 1,
        BAD_JSON_PARAMETERS = 2,
        USERNAME_TAKEN = 3,
        TOO_SHORT_PASSWORD = 4,
        TOO_LONG_PASSWORD = 5,
        USER_DOES_NOT_EXIST = 6,
        BAD_PASSWORD = 7
    }
}

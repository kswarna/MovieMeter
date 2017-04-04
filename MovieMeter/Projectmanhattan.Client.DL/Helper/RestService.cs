using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieMeter.Service
{
    public static class RestService<T>
    {
 
        public static async Task<List<T>> GetItems(string RestUrl)
        {
            HttpClient client = new HttpClient() { MaxResponseContentBufferSize = Int32.MaxValue };
            var DataList = new List<T>();

            var uri = new Uri(string.Format(RestUrl, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    DataList = JsonConvert.DeserializeObject<List<T>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return DataList;
        }

        public static async Task<T> GetItemData(string RestUrl,int ItemID) 
        {
            HttpClient client = new HttpClient() { MaxResponseContentBufferSize = Int32.MaxValue };
            var Item = default(T);

            var uri = new Uri(string.Format(RestUrl, ItemID.ToString()));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Item = JsonConvert.DeserializeObject<T>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return Item;
        }

        public static async Task<List<T>> GetItems(string RestUrl, int ItemID)
        {
            HttpClient client = new HttpClient() { MaxResponseContentBufferSize = Int32.MaxValue };
            var DataList = new List<T>();

            var uri = new Uri(string.Format(RestUrl, ItemID.ToString()));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    DataList = JsonConvert.DeserializeObject<List<T>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return DataList;
        }
        
        
    }
}

using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ClassLibrary.Services
{
    public class RandomUserService
    {
        public async Task<string> GetRandomUserAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://randomuser.me/api/");
                string responseBody = await response.Content.ReadAsStringAsync();

                JObject jObject = JObject.Parse(responseBody);
                string firstName = (string)jObject["results"][0]["name"]["first"];
                string lastName = (string)jObject["results"][0]["name"]["last"];
                return $"{firstName} {lastName}";
            }
        }
    }
}
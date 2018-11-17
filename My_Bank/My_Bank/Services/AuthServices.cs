using My_Bank.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank.Services
{
    class AuthServices
    {
        private string URL = "https://mybank-sp.azurewebsites.net/api/auth";

        public async Task Register(User newUser)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(newUser);
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(URL + "/register" , content);
        }

        public async Task Login(LoginUser logUser)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(logUser);
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(URL + "/login", content);
        }
    }
}

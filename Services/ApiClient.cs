using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Frontend.AppConfig;

namespace Frontend.Services
{
    public sealed class ApiClient
    {
        private static readonly Lazy<ApiClient> lazy = new(() => new ApiClient());
        public static ApiClient Instance => lazy.Value;

        private readonly HttpClient _http;
        private string _jwtToken;

        private ApiClient()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri(AppConfig.BaseUri)
            };
        }

        public void SetJwtToken(string token)
        {
            _jwtToken = token;
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public string GetJwtToken() => _jwtToken;

        public HttpClient Http => _http;
    }
}

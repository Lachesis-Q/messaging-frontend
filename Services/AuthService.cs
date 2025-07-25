using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Frontend.Models;
using Frontend.AppConfig;

namespace Frontend.Services
{
    public class AuthService
    {
        private readonly HttpClient _http;

        public AuthService()
        {
            _http = ApiClient.Instance.Http;
        }

        public record SignUpRequest(string UserName, string Email, string Password);
        public record UserResponse(int Id, string Email);
        public record SignUpResponse(UserResponse User, string JwtToken);

        public async Task<SignUpResponse> SignUpAsync(string username, string email, string password)
        {
            var req = new SignUpRequest(username, email, password);
            var resp = await _http.PostAsJsonAsync(AppConfig.SignUpUri, req);
            resp.EnsureSuccessStatusCode();
            var data = await resp.Content.ReadFromJsonAsync<SignUpResponse>();
            if (data != null && !string.IsNullOrEmpty(data.JwtToken))
                ApiClient.Instance.SetJwtToken(data.JwtToken);
            return data;
        }
    }
}

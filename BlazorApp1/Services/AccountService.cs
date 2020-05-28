using BlazorApp1.Models;
using BLL;
using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class AccountService
    {
        public HttpClient _httpClient;

        public AccountService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<bool> Login(LoginViewModel model)
        {
            UserDTO user = new UserDTO
            {
                Email = model.Email,
                //Role = "User",
                Password = model.Password
            };
            var json = JsonSerializer.Serialize(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Account/login", data);
            //using var responseContent = await response.Content.ReadAsStreamAsync();
            //var r = await JsonSerializer.DeserializeAsync<Details>(responseContent);
            //return r;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Details> Register(RegisterViewModel model)
        {
            UserDTO user = new UserDTO
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                //Role = "User",
                Password = model.Password
            };
            var json = JsonSerializer.Serialize(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/account/register", data);
            using var responseContent = await response.Content.ReadAsStreamAsync();
            var r = await JsonSerializer.DeserializeAsync<Details>(responseContent);
            return r;
        }
    }
}

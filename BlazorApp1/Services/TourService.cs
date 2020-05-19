using BlazorApp1.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class TourService
    {
        public HttpClient _httpClient;

        public TourService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<TourViewModel>> GetAll(PagingParameters p)
        {
            var res = await _httpClient.GetAsync($"api/Tour?pageNumber={p.PageNumber}&pageSize={p.PageSize}");
            res.EnsureSuccessStatusCode();

            using var responseContent = await res.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<TourViewModel>>(responseContent);
        }
    }
}

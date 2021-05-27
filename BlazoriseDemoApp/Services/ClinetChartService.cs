using BlazoriseDemoApp.Models;
using BlazoriseDemoApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazoriseDemoApp.Services
{
    public interface IClinetChartService
    {
        public Task<ConvertModel> GetData(int skip);
    }
    public class ClinetChartService : IClinetChartService
    {
        private readonly HttpClient _httpClient;
        public ClinetChartService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<ConvertModel> GetData(int skip)
        {
            var uri = new UriBuilderExt(new Uri(_httpClient.BaseAddress, "/api/chart"))
                .AddParameter("skip", $"{skip}")
                .Uri;
            return await _httpClient.GetFromJsonAsync<ConvertModel>(uri);
        }
    }
}

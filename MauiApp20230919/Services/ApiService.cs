using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp20230919.Models;
using Newtonsoft.Json;

namespace MauiApp20230919.Services
{
    class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(
                $"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}&apikey=ee5bc5d80616a8bf6a85d576afe069c6&lang=zh");
            return JsonConvert.DeserializeObject<Root>( response );
        }
    }
}

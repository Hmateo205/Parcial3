using Newtonsoft.Json;
using p3.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3.Services
{
    public class Chuck
    {
        public HttpClient _httpClient;
        public Chuck()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<ChuckNorris>> DevuelveListadoChistes()
        {
            string url = "https://api.chucknorris.io/jokes/random";
            string json = await _httpClient.GetStringAsync(url);

            ResourceList resourcelist_Chiste = JsonConvert.DeserializeObject<ResourceList>(json);
            return resourcelist_Chiste.results;
        }


       
    }
}

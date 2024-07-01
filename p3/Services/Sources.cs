using System.Text.Json;
using System.Text.Json.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p3.Models;

namespace p3.Services
{
    internal class Sources : Source
    {


        private string url = "https://api.chucknorris.io/jokes/aKS0aJOZRBmHtOOk9Lqm8Q";
        public async Task<List<Chistes>> GetChistechucks()

        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode p3 = nodos["chistes"];

            var chiste = JsonSerializer.Deserialize<List<Chistes>>(p3.ToString());
            return chiste;

        }
    }
}
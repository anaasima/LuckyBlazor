using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LuckyBlazor.Model;
using LuckyBlazor.Model.Rating;

namespace LuckyBlazor.Data
{
    public class ComponentService : IComponentService
    {
        public async Task<IList<Component>> GetAllComponentsAsync()
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/components"; 
            string message = await httpClient.GetStringAsync(uri);

            Console.WriteLine(message);
            
            IList<Component> result = JsonSerializer.Deserialize<IList<Component>>(message) ;
            return result;
        }

        public async Task AddNewComponentAsync(Component component)
        {
            HttpClient httpClient = new HttpClient();
            string componentSerialized = JsonSerializer.Serialize(component);
            StringContent content = new StringContent(
                componentSerialized,
                Encoding.UTF8,
                "application/json"
                );

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("https://localhost:8080/components", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task RateComponent(RatingComponent ratingComponent)
        {
            HttpClient client = new HttpClient();
            string ratingSerialized = JsonSerializer.Serialize(ratingComponent);
            StringContent content = new StringContent(
                ratingSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage =
                await client.PatchAsync("https://localhost:8080/componentRating", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}
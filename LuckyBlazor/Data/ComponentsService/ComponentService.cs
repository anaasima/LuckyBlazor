using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data
{
    public class ComponentService : IComponentService
    {
        public async Task<ComponentList> GetAllComponentsAsync() //TODO: later we will add filters as arguments
        {
            
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/components"; 
            string message = await httpClient.GetStringAsync(uri);
            ComponentList result = JsonSerializer.Deserialize<ComponentList>(message) ;
            
            
            
            
            return result;
        }
    }
}
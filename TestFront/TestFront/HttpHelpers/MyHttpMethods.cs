using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestFront.HttpHelpers
{
    public class MyHttpMethods : IMyHttpMethods
    {
        private HttpClient _client;
        public MyHttpMethods(HttpClient client)
        {
            _client = client;
            _client.BaseAddress =
                //new Uri("https://localhost:44316/api");
                new Uri("https://localhost:44327/api");
            //new Uri("https://localhost:44316/weatherforecast");

        }

        public Task<List<Customer>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetRoomsAsync()
        {
            HttpResponseMessage responseMessage = 
                await _client.GetAsync("/test/getCustomers");

            string httpContent = await responseMessage.Content.ReadAsStringAsync();

            List<Customer> myObject = JsonConvert.DeserializeObject<List<Customer>>(httpContent);

            return myObject;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}

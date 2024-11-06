using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.ApiClients
{
    public class ComisionApiClient
    {
        private static HttpClient client = new HttpClient();

        static ComisionApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7279/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Comision> GetAsync(int id)
        {
            Comision comision = null;
            HttpResponseMessage response = await client.GetAsync("comisiones/" + id);
            if (response.IsSuccessStatusCode)
            {
                comision = await response.Content.ReadAsAsync<Comision>();
            }
            return comision;
        }

        public static async Task<IEnumerable<Comision>> GetAllAsync()
        {
            IEnumerable<Comision> comisiones = null;
            HttpResponseMessage response = await client.GetAsync("comisiones");
            if (response.IsSuccessStatusCode)
            {
                comisiones = await response.Content.ReadAsAsync<IEnumerable<Comision>>();
            }
            return comisiones;
        }

        public static async Task AddAsync(Comision comision)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("comisiones", comision);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("comisiones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Comision comision)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("comisiones", comision);
            response.EnsureSuccessStatusCode();
        }
    }
}

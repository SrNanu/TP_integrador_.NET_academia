using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.ApiClients
{
    public class AlumnoInscripcionApiClient
    {
        private static HttpClient client = new HttpClient();

        static AlumnoInscripcionApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7279/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<AlumnoInscripcion> GetAsync(int id)
        {
            AlumnoInscripcion inscripcion = null;
            HttpResponseMessage response = await client.GetAsync("inscripciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                inscripcion = await response.Content.ReadAsAsync<AlumnoInscripcion>();
            }
            return inscripcion;
        }

        public static async Task<IEnumerable<AlumnoInscripcion>> GetAllAsync()
        {
            IEnumerable<AlumnoInscripcion> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("inscripciones");
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();
            }
            return inscripciones;
        }

        public static async Task AddAsync(AlumnoInscripcion inscripcion)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("inscripciones", inscripcion);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("inscripciones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(AlumnoInscripcion inscripcion)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("inscripciones", inscripcion);
            response.EnsureSuccessStatusCode();
        }

    }
}

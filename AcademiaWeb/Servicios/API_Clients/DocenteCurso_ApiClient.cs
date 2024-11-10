using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Web.ApiClients
{
    public class DocenteCursoApiClient
    {
        private static HttpClient client = new HttpClient();

        static DocenteCursoApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7279/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<DocenteCurso> GetAsync(int id)
        {
            DocenteCurso docenteCurso = null;
            HttpResponseMessage response = await client.GetAsync("docenteCursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                docenteCurso = await response.Content.ReadAsAsync<DocenteCurso>();
            }
            return docenteCurso;
        }

        public static async Task<IEnumerable<DocenteCurso>> GetAllAsync()
        {
            IEnumerable<DocenteCurso> docenteCursos = null;
            HttpResponseMessage response = await client.GetAsync("docenteCursos");
            if (response.IsSuccessStatusCode)
            {
                docenteCursos = await response.Content.ReadAsAsync<IEnumerable<DocenteCurso>>();
            }
            return docenteCursos;
        }

        public static async Task AddAsync(DocenteCurso docenteCurso)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("docenteCursos", docenteCurso);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al crear el docenteCurso: {ex.Message}");
            }
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("docenteCursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(DocenteCurso docenteCurso)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("docenteCursos", docenteCurso);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al actualizar el docenteCurso: {ex.Message}");
            }
        }

        public static async Task<IEnumerable<DocenteCurso>> GetDocentesInscripcionesByIdDocente(int idDocente)
        {
            IEnumerable<DocenteCurso> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("docenteCursos");
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<DocenteCurso>>();
                List<DocenteCurso> inscripcionesDocente = new List<DocenteCurso>();

                foreach (var inscripcion in inscripciones)
                {
                    if (inscripcion.IdDocente == idDocente)
                    {
                        inscripcionesDocente.Add(inscripcion);
                    }
                }

                return inscripcionesDocente;
            }
            return null;
        }

        public async static Task<IEnumerable<DocenteCurso>> GetDocentesDC(int idCurso)
        {
            IEnumerable<DocenteCurso> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("docenteCursos");
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<DocenteCurso>>();
                List<DocenteCurso> inscripcionesDocente = new List<DocenteCurso>();

                foreach (var inscripcion in inscripciones)
                {
                    if (inscripcion.IdCurso == idCurso)
                    {
                        inscripcionesDocente.Add(inscripcion);
                    }
                }

                return inscripcionesDocente;
            }
            return null;
        }
    }
}
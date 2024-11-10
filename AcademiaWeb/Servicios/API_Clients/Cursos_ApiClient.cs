using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Web.ApiClients
{
    public class CursoApiClient
    {
        private static HttpClient client = new HttpClient();

        static CursoApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7279/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Curso> GetAsync(int id)
        {
            Curso curso = null;
            HttpResponseMessage response = await client.GetAsync("cursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                curso = await response.Content.ReadAsAsync<Curso>();
            }
            return curso;
        }

        public static async Task<IEnumerable<Curso>> GetAllAsync()
        {
            IEnumerable<Curso> cursos = null;
            HttpResponseMessage response = await client.GetAsync("cursos");
            if (response.IsSuccessStatusCode)
            {
                cursos = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
            }
            return cursos;
        }

        public static async Task AddAsync(Curso curso)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("cursos", curso);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al crear el curso: {ex.Message}");
            }
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("cursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Curso curso)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("cursos", curso);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al actualizar el curso: {ex.Message}");
            }
        }

        public static async Task<IEnumerable<Curso>> GetCursosByIdMateria(int idMateria)
        {
            IEnumerable<Curso> cursos = null;
            HttpResponseMessage response = await client.GetAsync("cursos");
            if (response.IsSuccessStatusCode)
            {
                cursos = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
                List<Curso> cursosDeMateria = new List<Curso>();

                foreach (var curso in cursos)
                {
                    if (curso.IdMateria == idMateria)
                    {
                        cursosDeMateria.Add(curso);
                    }
                }

                return cursosDeMateria;
            }
            return null;
        }

        public static async Task<Curso?> GetOneCursoByIdMateria(int idMateria)
        {
            IEnumerable<Curso> cursos = null;
            HttpResponseMessage response = await client.GetAsync("cursos");
            if (response.IsSuccessStatusCode)
            {
                cursos = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
                List<Curso> cursosDeMateria = new List<Curso>();

                foreach (var curso in cursos)
                {
                    if (curso.IdMateria == idMateria)
                    {
                        cursosDeMateria.Add(curso);
                    }
                }

                foreach (var curso in cursosDeMateria)
                {
                    var inscripciones = await AlumnoInscripcionApiClient
                        .GetAlumnosInscripcionesByIdCurso(curso.IdMateria);
                    var cantidadInscriptos = inscripciones.Count();

                    if (cantidadInscriptos > curso.Cupo)
                    {
                        return curso;
                    }
                }
            }
            return null;
        }
    }
}
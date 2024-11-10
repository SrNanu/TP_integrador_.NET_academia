﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Web.ApiClients
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
            HttpResponseMessage response = await client.GetAsync("inscipciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                inscripcion = await response.Content.ReadAsAsync<AlumnoInscripcion>();
            }
            return inscripcion;
        }

        public static async Task<IEnumerable<AlumnoInscripcion>> GetAllAsync()
        {
            IEnumerable<AlumnoInscripcion> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("inscipciones");
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();
            }
            return inscripciones;
        }

        public static async Task AddAsync(AlumnoInscripcion inscripcion)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("inscipciones", inscripcion);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("inscipciones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(AlumnoInscripcion inscripcion)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("inscipciones", inscripcion);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<AlumnoInscripcion> GetOneAlumnoInscripcionByIdUsuario(int idUsuario)
        {
            IEnumerable<AlumnoInscripcion> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("inscipciones");
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();

                foreach (var inscripcion in inscripciones)
                {
                    if (inscripcion.IdAlumno == idUsuario)
                    {
                        return inscripcion;
                    }
                }
            }
            return null;
        }

        public static async Task<IEnumerable<AlumnoInscripcion>> GetAlumnosInscripcionesByIdUsuario(int idUsuario)
        {
            IEnumerable<AlumnoInscripcion> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("inscipciones");
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();
                List<AlumnoInscripcion> inscripcionesAlumno = new List<AlumnoInscripcion>();

                foreach (var inscripcion in inscripciones)
                {
                    if (inscripcion.IdAlumno == idUsuario)
                    {
                        inscripcionesAlumno.Add(inscripcion);
                    }
                }

                return inscripcionesAlumno;
            }
            return null;
        }

        public static async Task<IEnumerable<AlumnoInscripcion>> GetAlumnosInscripcionesByIdCurso(int idCurso)
        {
            IEnumerable<AlumnoInscripcion> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("inscipciones");
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();
                List<AlumnoInscripcion> inscripcionesCurso = new List<AlumnoInscripcion>();

                foreach (var inscripcion in inscripciones)
                {
                    if (inscripcion.IdCurso == idCurso)
                    {
                        inscripcionesCurso.Add(inscripcion);
                    }
                }

                return inscripcionesCurso;
            }
            return null;
        }
    }
}
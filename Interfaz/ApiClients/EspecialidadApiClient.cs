﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.ApiClients
{
    public class EspecialidadApiClient
    {
        private static HttpClient client = new HttpClient();

        static EspecialidadApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7279/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Especialidad> GetAsync(int id)
        {
            Especialidad especialidad = null;
            HttpResponseMessage response = await client.GetAsync("especialidades/" + id);
            if (response.IsSuccessStatusCode)
            {
                especialidad = await response.Content.ReadAsAsync<Especialidad>();
            }
            return especialidad;
        }

        public static async Task<IEnumerable<Especialidad>> GetAllAsync()
        {
            IEnumerable<Especialidad> especialidades = null;
            HttpResponseMessage response = await client.GetAsync("especialidades");
            if (response.IsSuccessStatusCode)
            {
                especialidades = await response.Content.ReadAsAsync<IEnumerable<Especialidad>>();
            }
            return especialidades;
        }

        public static async Task AddAsync(Especialidad especialidad)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("especialidades", especialidad);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al crear la especialidad: {ex.Message}");
            }
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("especialidades/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Especialidad especialidad)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("especialidades", especialidad);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al actualizar la especialidad: {ex.Message}");
            }
        }
    }
}

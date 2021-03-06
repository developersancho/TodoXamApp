﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TodoXamApp.Models;

namespace TodoXamApp.Services
{
    public class TodoService
    {
        private string Url = "http://localhost:4646/api/todoes/";

        public async Task<List<Todo>> GetTodoes()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(Url);
            var todoes = JsonConvert.DeserializeObject<List<Todo>>(json);
            return todoes;
        }

        public async Task PostTodo(Todo todo)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(todo);
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(Url, content);
        }

        public async Task PutTodo(int id, Todo todo)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(todo);
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(Url + id, content);
        }

        public async Task DeleteTodo(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync(Url + id);
        }

    }
}

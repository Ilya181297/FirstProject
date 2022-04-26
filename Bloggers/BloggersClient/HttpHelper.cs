using Bloggers.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp
{
    internal class HttpHelper
    {
        private readonly HttpClient _httpClient;
        public HttpHelper()
        {
            _httpClient = new HttpClient();
        }

        public List<Blogger> GetBloggers()
        {
            var response = _httpClient.GetAsync("http://localhost:5000/Bloggers").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var bloggers = JsonConvert.DeserializeObject<List<Blogger>>(content);
            return bloggers ?? new List<Blogger>();
        }

        public bool DeleteBlogger(int id)
        {
            var response = _httpClient.DeleteAsync($"http://localhost:5000/Bloggers/{id}").Result;

            if (!response.IsSuccessStatusCode)
                return false;

            var content = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<bool>(content);

        }

        public bool PostBlogger(string? name, string? post)
        {
            var blogger = new Blogger();
            blogger.Name = name;
            blogger.Post = post;
            var json = JsonConvert.SerializeObject(blogger);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = _httpClient.PostAsync($"http://localhost:5000/Bloggers", data).Result;

            if (!response.IsSuccessStatusCode)
                return false;

            var content = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public bool PutBlogger(int id, string? name, string? post)
        {
            var blogger = new Blogger
            {
                Id = id,
                Name = name,
                Post = post
            };
            var json = JsonConvert.SerializeObject(blogger);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = _httpClient.PutAsync($"http://localhost:5000/Bloggers", data).Result;

            if (!response.IsSuccessStatusCode)
                return false;

            var content = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}


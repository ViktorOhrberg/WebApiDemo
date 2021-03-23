using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiDemoMVC.Models.ViewModels;

namespace WebApiDemoMVC.Models
{
    public class PhotosService
    {
        IHttpClientFactory httpClientFactory;
        public PhotosService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<PhotosIndexVM[]> GetAllPhotos()
        {
            HttpClient client = httpClientFactory.CreateClient(); //new HttpClient();

            //string url = "https://jsonplaceholder.typicode.com/photos";
            string url = "https://localhost:44346/"; // string to MyFirstAPI;
            string json = await client.GetStringAsync(url);

            var photos = JsonConvert.DeserializeObject<Photo[]>(json);

            return photos
                .Select(p => new PhotosIndexVM { Title = p.title, URL = p.url })
                .ToArray();
        }
    }
}

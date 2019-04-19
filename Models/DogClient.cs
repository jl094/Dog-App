using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DogApp.Models
{
    public class DogClient
    {
        private string Base_URL = "http://dogapp20190416032230.azurewebsites.net/api/";

        private HttpClient SetupClient() {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Base_URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }


        public IEnumerable<Dog> findAll() {
            try
            {
                HttpClient client = SetupClient();
                HttpResponseMessage response = client.GetAsync("dogs").Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<Dog>>().Result;
                }
                return null;
            }
            catch {
                return null;
            }
        }

        public Dog find(int id)
        {
            try
            {
                HttpClient client = SetupClient();
                HttpResponseMessage response = client.GetAsync("dogs/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<Dog>().Result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool Create(Dog dog)
        {
            try
            {
                HttpClient client = SetupClient();
                HttpResponseMessage response = client.PostAsJsonAsync("dogs", dog).Result;

                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(Dog dog)
        {
            try
            {
                HttpClient client = SetupClient();
                HttpResponseMessage response = client.PutAsJsonAsync("dogs/" + dog.Id, dog).Result;

                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                HttpClient client = SetupClient();
                HttpResponseMessage response = client.DeleteAsync("dogs/" + id).Result;

                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
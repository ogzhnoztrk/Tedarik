using Newtonsoft.Json;
using System.Net.Http.Headers;
using Tedarik.Core.Models;

namespace Tedarik.Web.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">return type</typeparam>
    /// <typeparam name="Y">post model</typeparam>
    public class HttpService<T, Y> : IHttpService<T, Y> /*where T : class  where Y : class*/
    {

        public HttpService()
        {

        }
        public async Task<Result<T>> PostAsync(string endpoint, Y postModel)
        {
            var content = JsonConvert.SerializeObject(postModel, Formatting.Indented);
            content = content.Replace("\r", "");

            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44323/api/" + endpoint);//Firma/post
                request.Headers.Add("accept", "text/plain");
                //request.Headers.Add("Authorization", "Bearer " + FileManager.LoadToken());

                request.Content = new StringContent(content);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responsedata = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Result<T>>(responsedata);
                }
            }

        }

        public async Task<Result<T>> DeleteAsync(string endpoint)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, "https://localhost:44323/api/" + endpoint);//Firma/delete
                request.Headers.Add("accept", "text/plain");
                //request.Headers.Add("Authorization", "Bearer " + FileManager.LoadToken());
                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responsedata = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Result<T>>(responsedata);
                }
            }

        }

        public async Task<Result<T>> GetAsync(string endpoint)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                client.Timeout = TimeSpan.FromMinutes(10);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44323/api/" + endpoint);//Firma/all
                request.Headers.Add("accept", "text/plain");
                //request.Headers.Add("Authorization", "Bearer " + FileManager.LoadToken());


                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responsedata = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Result<T>>(responsedata);
                }


            }




        }

        public async Task<Result<T>> PutAsync(string endpoint, T putModel)
        {
            var content = JsonConvert.SerializeObject(putModel, Formatting.Indented);
            content = content.Replace("\r", "");

            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, "https://localhost:44323/api/" + endpoint);//Firma/post
                request.Headers.Add("accept", "text/plain");
                //request.Headers.Add("Authorization", "Bearer " + FileManager.LoadToken());

                request.Content = new StringContent(content);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responsedata = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Result<T>>(responsedata);
                }
            }
            throw new NotImplementedException();
        }
    }
}
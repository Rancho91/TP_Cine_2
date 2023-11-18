using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Text;

namespace ReportesCine.service
{
    public class DataHttp
    {
        private string Url { get; set; }
        private string Route { get; set; }

        public DataHttp(string route)
        {
            Url = "https://localhost:7011/api/";
            Route = route;
        }

        public async Task<string> Get()
        {

            using (var client = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            }))
            {
                try
                {
                    var result = await client.GetAsync(Url+Route);
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine($"Status Code: {result.StatusCode}");
                    Console.WriteLine($"Response Content: {content}");
                    return content;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }
        public async Task<string> Post(string jsonData)
        {
            using (var client = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            }))
            {
                try
                {
                    // Convierte los datos JSON en un contenido StringContent
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Realiza la solicitud POST
                    var result = await client.PostAsync(Url + Route, content);

                    // Lee y devuelve el contenido de la respuesta
                    var responseContent = await result.Content.ReadAsStringAsync();

                    Console.WriteLine($"Status Code: {result.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");

                    return responseContent;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }

        public async Task<string> Delete()
        {
            using (var client = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            }))
            {
                try
                {
                    var result = await client.DeleteAsync(Url + Route);

                    var responseContent = await result.Content.ReadAsStringAsync();

                    Console.WriteLine($"Status Code: {result.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");
                    if (!result.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error: {result.ReasonPhrase}");
                        return $"Error: {result.ReasonPhrase}";
                    }

                    return responseContent;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return ex.Message;
                }

            }
        }
        public async Task<string> Put(string jsonData)
        {
            using (var client = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            }))
            {
                try
                {
                    // Convierte los datos JSON en un contenido StringContent
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Realiza la solicitud PUT
                    var result = await client.PutAsync(Url + Route, content);

                    // Lee y devuelve el contenido de la respuesta
                    var responseContent = await result.Content.ReadAsStringAsync();

                    Console.WriteLine($"Status Code: {result.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");

                    return responseContent;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }


    }

}

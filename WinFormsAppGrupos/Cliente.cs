using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WinFormsAppGrupos
{
    internal class Cliente
    {
        private readonly HttpClient httpClient; 
        private static Cliente nuevoCliente;

        private  Cliente()                          
        {
            httpClient = new HttpClient();
        }

        public static Cliente GetCliente()      
        {
            if (nuevoCliente == null)
            {
                nuevoCliente = new Cliente();
            }
            return nuevoCliente;
        }

        public async Task<string> PostAsync(string url, string json)    
        {
            StringContent httpContent = new StringContent(json, Encoding.UTF8,"application/json"); 
            
            var response = await httpClient.PostAsync(url, httpContent);

            var responseString = "";

            if (response.IsSuccessStatusCode)
                responseString = await response.Content.ReadAsStringAsync();
            
            return responseString;            
        }

        public async Task<string> PutAsync(string url, string json)
        {
            StringContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync(url, httpContent);

            var responseString = "";

            if (response.IsSuccessStatusCode)
                responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }


        public async Task<string> GetAsync(string url)
        {
            
            var result = await httpClient.GetAsync(url);
            var content = "";

            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();

            return content;
            
        }


    }
}

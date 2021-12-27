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
        private readonly HttpClient httpClient; //It is recommended to instantiate one HttpClient for your application's lifetime and share it
        private static Cliente nuevoCliente;

        private  Cliente()                          //cada vez que se hace un Cliente, se crea un HttpClient
        {
            httpClient = new HttpClient();
        }

        public static Cliente GetCliente()      // obtiene una única instancia de Cliente, es estático, no es necesario instanciarla
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

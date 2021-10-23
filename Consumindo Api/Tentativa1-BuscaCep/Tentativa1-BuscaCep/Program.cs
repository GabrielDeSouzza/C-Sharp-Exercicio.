using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;




namespace Tentativa1_BuscaCep
{
    class Program
    {
        private static readonly HttpClient CepUsurio = new HttpClient();
        static async Task Main(string[] args)
        {
            string s = Convert.ToString( Console.Read());

            if (s.Length == 7)
            {
                var seriarJson = await prossCep(s);


                Console.WriteLine(seriarJson.logradouro);
                Console.WriteLine(seriarJson.localidade);
                Console.ReadKey();

                /* foreach (var dados in seriarJson)
                 {
                     Console.WriteLine(dados.logradouro);
                     Console.WriteLine(dados.localidade);
                     Console.WriteLine(dados.uf);
                 }*/
                
            }
            Console.WriteLine(s.Length);
            Console.ReadKey();
        }
        private static async Task<DadosCep>prossCep(string x)
        {
            
            Console.WriteLine(x);
            CepUsurio.DefaultRequestHeaders.Accept.Clear();
            CepUsurio.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("aplication/json"));
            // var stringTask = CepUsurio.GetStringAsync("https://viacep.com.br/ws/01001000/json/");
            // var msg = await stringTask;
            var streamTask = CepUsurio.GetStreamAsync($"https://viacep.com.br/ws/{x}/json/");

           
            var options = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
                IgnoreNullValues=true,
               
            };

            var seriarJson = await JsonSerializer.DeserializeAsync<DadosCep>(await streamTask, options);

            return seriarJson;
            /*foreach (var dados in seriarJson)
            {
                Console.WriteLine(dados.logradouro);
                Console.WriteLine(dados.localidade);
                Console.WriteLine(dados.uf);
            }

            Console.ReadKey();*/
             

        }

        
    }
}

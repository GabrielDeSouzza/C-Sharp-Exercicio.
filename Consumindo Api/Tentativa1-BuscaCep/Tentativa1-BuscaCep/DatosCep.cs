using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace Tentativa1_BuscaCep
{
    
    public class DadosCep
    {
        [JsonPropertyName ("logradouro")]
        public string logradouro { get; set; }


        [JsonPropertyName("localidade")]
        public string localidade { get; set; }

        [JsonPropertyName("uf")]
        public string uf { get; set; }

    }
}

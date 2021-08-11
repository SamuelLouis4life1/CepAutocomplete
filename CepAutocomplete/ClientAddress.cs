using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CepAutocomplete
{
    public class ClientAddress
    {
        [JsonProperty ("cep")]
        public string PostalCode { get; set; }

        [JsonProperty("logradouro")]
        public string logradouro { get; set; }

        [JsonProperty("complemento")]
        public string complemento { get; set; }

        [JsonProperty("bairro")]
        public string bairro { get; set; }

        [JsonProperty("localidade")]
        public string localidade { get; set; }

        [JsonProperty("uf")]
        public string uf { get; set; }

        [JsonProperty("ibge")]
        public string ibge { get; set; }

        [JsonProperty("gia")]
        public string Gia { get; set; }

        [JsonProperty("ddd")]
        public string ddd { get; set; }

        [JsonProperty("siafi")]
        public string siafi { get; set; }

        //public string Number { get; set; }
    }
}

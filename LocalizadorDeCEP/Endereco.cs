﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LocalizadorDeCEP
{
    public class Endereco
    {
            [JsonProperty("cep")]
            public string cep { get; set; }

            [JsonProperty("logradouro")]
            public string logradouro { get; set; }

            [JsonProperty("complemento")]
            public string complemento { get; set; }

            [JsonProperty("unidade")]
            public string unidade { get; set; }

            [JsonProperty("bairro")]
            public string bairro { get; set; }

            [JsonProperty("localidade")]
            public string localidade { get; set; }

            [JsonProperty("uf")]
            public string uf { get; set; }

            [JsonProperty("estado")]
            public string estado { get; set; }

            [JsonProperty("regiao")]
            public string regiao { get; set; }

            [JsonProperty("ibge")]
            public string ibge { get; set; }

            [JsonProperty("gia")]
            public string gia { get; set; }

            [JsonProperty("ddd")]
            public string ddd { get; set; }

            [JsonProperty("siafi")]
            public string siafi { get; set; }
    }
}

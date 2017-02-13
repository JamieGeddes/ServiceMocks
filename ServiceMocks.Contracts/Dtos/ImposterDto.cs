using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServiceMocks.Contracts.Dtos
{
    public class ImposterDto
    {
        public ImposterDto()
        {
            Stubs = new List<StubDto>();
        }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stubs")]
        public ICollection<StubDto> Stubs { get; set; }
    }
}

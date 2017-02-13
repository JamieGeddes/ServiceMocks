using Newtonsoft.Json;

namespace ServiceMocks.Contracts.Dtos
{
    public class EqualsDto
    {
        public EqualsDto()
        {
            Headers = new HeadersDto();
        }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("headers")]
        public HeadersDto Headers { get; set; }
    }
}

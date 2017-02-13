using Newtonsoft.Json;

namespace ServiceMocks.Contracts.Dtos
{
    public class EqualsDto
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}

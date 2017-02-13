using Newtonsoft.Json;

namespace ServiceMocks.Contracts.Dtos
{
    public class HeadersDto
    {
        public HeadersDto()
        {
            ContentType = "application/json";
            Accept = string.Empty;
        }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        [JsonProperty("accept")]
        public string Accept { get; set; }

        [JsonProperty("connection")]
        public string Connection { get; set; }
    }
}

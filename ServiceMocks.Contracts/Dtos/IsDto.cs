using Newtonsoft.Json;
using System.Net;

namespace ServiceMocks.Contracts.Dtos
{
    public class IsDto
    {
        public IsDto()
        {
            StatusCode = (int)HttpStatusCode.OK;

            Headers = new HeadersDto();
        }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("headers")]
        public HeadersDto Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}

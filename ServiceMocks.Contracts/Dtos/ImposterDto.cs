using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace ServiceMocks.Contracts.Dtos
{
    public class ImposterDto
    {
        public ImposterDto()
        {
            Name = string.Empty;

            Stubs = new List<StubDto>();

            DefaultResponse = new ResponseDto
            {
                IsDto = new IsDto
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Headers = new HeadersDto
                    {
                        Connection = "close"
                    },
                    Body = string.Empty
                }
            };
        }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stubs")]
        public ICollection<StubDto> Stubs { get; set; }

        [JsonProperty("defaultResponse")]
        public ResponseDto DefaultResponse { get; set; }
    }
}

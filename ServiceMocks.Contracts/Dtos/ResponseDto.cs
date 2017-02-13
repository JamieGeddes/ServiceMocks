using Newtonsoft.Json;

namespace ServiceMocks.Contracts.Dtos
{
    public class ResponseDto
    {
        public ResponseDto()
        {
            IsDto = new IsDto();
        }

        [JsonProperty("is")]
        public IsDto IsDto { get; set; }
    }
}

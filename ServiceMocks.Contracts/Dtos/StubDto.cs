using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServiceMocks.Contracts.Dtos
{
    public class StubDto
    {
        public StubDto()
        {
            Responses = new List<ResponseDto>();
            Predicates = new List<PredicateDto>();
        }

        [JsonProperty("responses")]
        public ICollection<ResponseDto> Responses { get; set; }

        [JsonProperty("predicates")]
        public ICollection<PredicateDto> Predicates { get; set; }
    }
}

using Newtonsoft.Json;

namespace ServiceMocks.Contracts.Dtos
{
    public class PredicateDto
    {
        public PredicateDto()
        {
            EqualsDto = new EqualsDto();
        }

        [JsonProperty("equals")]
        public EqualsDto EqualsDto { get; set; }
    }
}

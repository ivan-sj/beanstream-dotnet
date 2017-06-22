using Newtonsoft.Json;

namespace Beanstream.Api.SDK.Requests
{
    public class LegatoTokenRequest
    {
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "expiry_month")]
        public string ExpiryMonth { get; set; }

        [JsonProperty(PropertyName = "expiry_year")]
        public string ExpiryYear { get; set; }

        [JsonProperty(PropertyName = "cvd")]
        public string Cvd { get; set; }
    }
}

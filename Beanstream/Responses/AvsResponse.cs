using Newtonsoft.Json;

namespace Beanstream.Api.SDK
{
    public class AvsResponse
    {
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "message", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "processed", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool Processed { get; set; }
    }
}
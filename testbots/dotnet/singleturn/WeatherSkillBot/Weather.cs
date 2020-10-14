using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.BotBuilderSamples.EchoSkillBot
{
    [JsonArray]
    public class WeatherReport
    {
        [JsonProperty("properties")]
        public Newtonsoft.Json.Linq.JObject report;
    }

    public class SingleDay
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        [JsonProperty("shortForecast")]
        public string ShortForecast { get; set; }
    }
}

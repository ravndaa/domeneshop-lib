using System;
using Newtonsoft.Json;

namespace Domeneshop
{
    public class DnsRecord
    {
        [JsonProperty("host")]
        public string Host { get; set; }
        [JsonProperty("ttl")]
        public short TTL {get;set;}
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
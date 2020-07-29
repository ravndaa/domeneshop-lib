using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domeneshop
{
    public class DnsApi : IDnsApi
    {
        private readonly HttpClient _http;
        private readonly string _token;

        public DnsApi(string token)
        {
            _http = new HttpClient();
            _token = token;
            _http.DefaultRequestHeaders.Add("Authorization", "Basic " + _token);
        }
        public DnsApi(string token, HttpClient http)
        {
            _http = http;
            _token = token;
        }

        // Get All domains
        public async Task<List<DnsDomain>> ListDomains()
        {
            
            var res = await _http.GetAsync("https://api.domeneshop.no/v0/domains");
            var json = JsonConvert.DeserializeObject<List<DnsDomain>>(await res.Content.ReadAsStringAsync());

            return json;
        }

        // 
        public async Task<DnsDomain> FindDomainById(string id)
        {
            
            var res = await _http.GetAsync($"https://api.domeneshop.no/v0/domains/{id}");
            var json = JsonConvert.DeserializeObject<DnsDomain>(await res.Content.ReadAsStringAsync());

            return json;
        }
        // 
        public async Task<List<DnsRecord>> ListDnsRecords(string id)
        {
            var res = await _http.GetAsync($"https://api.domeneshop.no/v0/domains/{id}/dns");
            var json = JsonConvert.DeserializeObject<List<DnsRecord>>(await res.Content.ReadAsStringAsync());

            return json;

        }

        //
        public async Task AddDnsRecord(string domainId, DnsRecord record)
        {
            var payload = new StringContent(JsonConvert.SerializeObject(record),System.Text.Encoding.UTF8,"application/json");
            Console.WriteLine(await payload.ReadAsStringAsync());
            var res = await _http.PostAsync($"https://api.domeneshop.no/v0/domains/{domainId}/dns", payload);
            if(!res.IsSuccessStatusCode) throw new HttpRequestException(await res.Content.ReadAsStringAsync());
            
        }
    }
}
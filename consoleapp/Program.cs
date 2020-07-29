using System;
using System.Threading.Tasks;
using Domeneshop;

namespace consoleapp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var dns = new Domeneshop.DnsApi("");
           // var res = await dns.ListDomains();
/*
            foreach (var item in res)
            {
                Console.WriteLine(item.Domain);
                var records = await dns.ListDnsRecords(item.Id);
                foreach (var rec in records)
                {
                    Console.WriteLine($"{rec.Type} - {rec.Host} - {rec.Data}");
                }
            }*/
            var api = new DnsRecord {
                Host = "api",
                TTL = 3600,
                Data = "127.0.0.1.1",
                Type = "A"
            };
            await dns.AddDnsRecord("1355103",api);


        }
    }
}

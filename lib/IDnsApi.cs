using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domeneshop
{
    public interface IDnsApi
    {
        Task<List<DnsDomain>> ListDomains();
        Task<DnsDomain> FindDomainById(string domainId);
        Task<List<DnsRecord>> ListDnsRecords(string domainId);

        Task AddDnsRecord(string domainId, DnsRecord record);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPIDapper.Models;

namespace WebAPIDapper.Interface
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompanyById(Company company);
    }
}

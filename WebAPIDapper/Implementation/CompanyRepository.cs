using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using WebAPIDapper.Interface;
using WebAPIDapper.Models;

namespace WebAPIDapper.Implementation
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IDapperRepository _dapper;
        public CompanyRepository(IDapperRepository dapper)
        {
            _dapper = dapper;
        }
        public async Task<IEnumerable<Company>> GetCompanies()
        {
            string sp = "Select * from Company";
            var res = await _dapper.GetAllAsync<Company>(sp,null, CommandType.Text);
            return res ?? new List<Company>();
        }

        public async Task<Company> GetCompanyById(Company company)
        {
            string sp = "Select * from Company where Id = @Id";
            var res = await _dapper.GetAsync<Company>(sp, new { Id = company.Id}, CommandType.Text);
            return res ?? new Company();
        }
    }
}

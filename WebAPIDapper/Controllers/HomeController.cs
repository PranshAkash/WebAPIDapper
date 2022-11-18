using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPIDapper.Interface;
using WebAPIDapper.Models;

namespace WebAPIDapper.Controllers
{
    [ApiController]
    [Route("api/")]
    public class HomeController : ControllerBase
    {
        public readonly ICompanyRepository _company;
        public HomeController(ICompanyRepository company) 
        {
            _company = company;
        }
        [Route("/api/GetCompany")]
        public async Task<IActionResult> GetCcompanies()
        {
            var res = await _company.GetCompanies();
            return Ok(res);
        }
        [Route("/api/GetCompanyById")]
        public async Task<IActionResult> GetCcompaniesById(Company company)
        {
            var res = await _company.GetCompanyById(company);
            return Ok(res);
        }
    }
}

using CarrierWebApi.Database;
using CarrierWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarrierWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
        public class CountriesController(CarrierRegistrationDbContext carrierRegistrationDbContext) : ControllerBase
        {
            private readonly CarrierRegistrationDbContext _carrierRegistrationDbContext = carrierRegistrationDbContext;

            [HttpGet]
            public async Task<IEnumerable<Countries>> GetCountries()
            {
                return await _carrierRegistrationDbContext.Countries.ToListAsync();
            }
        }
    }



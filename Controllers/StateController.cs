using CarrierWebApi.Database;
using CarrierWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarrierWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController(CarrierRegistrationDbContext carrierRegistrationDbContext) : ControllerBase
    {
        private readonly CarrierRegistrationDbContext _carrierRegistrationDbContext = carrierRegistrationDbContext;

        [HttpGet]
        public async Task<IEnumerable<States>> GetStates()
        {
            return await _carrierRegistrationDbContext.States.ToListAsync();
        }
    }
}

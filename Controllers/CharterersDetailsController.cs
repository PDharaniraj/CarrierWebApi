using CarrierWebApi.Database;
using CarrierWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarrierWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharterersDetailsController(CarrierRegistrationDbContext carrierRegistrationDbContext) : ControllerBase
    {
       
            private readonly CarrierRegistrationDbContext _carrierRegistrationDbContext = carrierRegistrationDbContext;

        [HttpGet("load/{id}")]
            public async Task<IEnumerable<CharterersDetails>> GetCharterersDetail(long id)
            {
             
            var result = await _carrierRegistrationDbContext.CharterersDetails.Where(x => x.VesselId == id).ToListAsync();
            var resultCountry = await _carrierRegistrationDbContext.Countries.ToListAsync();
            var resultState = await _carrierRegistrationDbContext.States.ToListAsync();
            foreach (var item in result)
            {
                item.CountryName  =  resultCountry.Where(x => x.CountryId == item.Country).Select(x => x.CountryName).FirstOrDefault();
                item.StateName = resultState.Where(x => x.StateId == item.State).Select(x => x.StateName).FirstOrDefault();

            }
            return result;
            }
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var item = _carrierRegistrationDbContext.CharterersDetails.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
            public async Task<CharterersDetails> GetChartererDetails(CharterersDetails charterersDetails)
            {
                _carrierRegistrationDbContext.Add(charterersDetails);
                await _carrierRegistrationDbContext.SaveChangesAsync();
                return charterersDetails;
            }
            [HttpPut("{CharterersId}")]
            public async Task<CharterersDetails> UpdateCharterersDetails(CharterersDetails CharterersId)
            {
                _carrierRegistrationDbContext.Entry(CharterersId).State = EntityState.Modified;
                await _carrierRegistrationDbContext.SaveChangesAsync();
                return CharterersId;
            }
        [HttpDelete("{CharterersId}")]

        public bool DeleteCharterersDetails(long charterersId)
        {
            var CharterersDetails = _carrierRegistrationDbContext.CharterersDetails.Find(charterersId);
            if (CharterersDetails != null)
            {
                _carrierRegistrationDbContext.Remove(CharterersDetails).State = EntityState.Deleted;
                _carrierRegistrationDbContext.SaveChanges();
            }
            return true;
        }
        }
}

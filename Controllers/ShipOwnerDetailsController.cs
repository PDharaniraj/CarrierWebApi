using CarrierWebApi.Database;
using CarrierWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarrierWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipOwnerDetailsController(CarrierRegistrationDbContext carrierRegistrationDbContext) : ControllerBase
    {
       
            private readonly CarrierRegistrationDbContext _carrierRegistrationDbContext = carrierRegistrationDbContext;

        [HttpGet("load/{id}")]
        public async Task<IEnumerable<ShipOwnerDetails>> GetShipOwnerDetail(long id)
        {

            var result = await _carrierRegistrationDbContext.ShipOwnerDetails.Where(x => x.VesselId == id).ToListAsync();
            var resultCountry = await _carrierRegistrationDbContext.Countries.ToListAsync();
            var resultState = await _carrierRegistrationDbContext.States.ToListAsync();
            foreach (var item in result)
            {
                item.CountryName = resultCountry.Where(x => x.CountryId == item.Country).Select(x => x.CountryName).FirstOrDefault();
                item.StateName = resultState.Where(x => x.StateId == item.State).Select(x => x.StateName).FirstOrDefault();

            }
            return result;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var item = _carrierRegistrationDbContext.ShipOwnerDetails.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
            public async Task<ShipOwnerDetails> GetShipOwnerDetails(ShipOwnerDetails shipOwnerDetails)
            {
                _carrierRegistrationDbContext.Add(shipOwnerDetails);
                await _carrierRegistrationDbContext.SaveChangesAsync();
                return shipOwnerDetails;
            }
            [HttpPut("{ShipOwnerDetailsId}")]
            public async Task<long> UpdateShipOwnerDetails(long ShipOwnerDetailsId,ShipOwnerDetails shipOwnerDetails)
            {
            var item = _carrierRegistrationDbContext.ShipOwnerDetails.Find(ShipOwnerDetailsId);
            item.ShipOwnerDetailsId = shipOwnerDetails.ShipOwnerDetailsId;
            item.ShipOwnerName = shipOwnerDetails.ShipOwnerName;
            item.EmailID = shipOwnerDetails.EmailID;
            item.MobileNo = shipOwnerDetails.MobileNo;
            item.Address = shipOwnerDetails.Address;
            item.PostalCode = shipOwnerDetails.PostalCode;
            item.City = shipOwnerDetails.City;
            item.State = shipOwnerDetails.State;
            item.Country= shipOwnerDetails.Country;
            _carrierRegistrationDbContext.Update(item);
            await _carrierRegistrationDbContext.SaveChangesAsync();
            return item.ShipOwnerDetailsId;

        }
        [HttpDelete("{ShipOwnerDetailsId}")]

        public bool DeleteShipOwnerDetails(long ShipOwnerDetailsId)
        {
            var ShipOwnerDetails = _carrierRegistrationDbContext.ShipOwnerDetails.Find(ShipOwnerDetailsId);
            if (ShipOwnerDetails != null)
            {
                _carrierRegistrationDbContext.Remove(ShipOwnerDetails).State = EntityState.Deleted;
                _carrierRegistrationDbContext.SaveChanges();
            }
            return true;
        }
    }
    }
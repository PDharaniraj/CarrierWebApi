using CarrierWebApi.Database;
using CarrierWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CarrierWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VesselRegistrationController(CarrierRegistrationDbContext carrierRegistrationDbContext) : ControllerBase

    {
       
        private readonly CarrierRegistrationDbContext _carrierRegistrationDbContext = carrierRegistrationDbContext;

        [HttpGet]
        public async Task<IEnumerable<VesselRegistration>> GetVesselRegistration()
        {
            return await _carrierRegistrationDbContext.VesselRegistration.ToListAsync();
        }
        [HttpGet("VesselRegistrationPort")]
        public async Task<IEnumerable<VesselRegistration>> GetVesselRegistrationforship()
        {
            return await _carrierRegistrationDbContext.VesselRegistration.Where(vr => vr.StateName == "Submited").ToListAsync();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var item = _carrierRegistrationDbContext.VesselRegistration.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<long> GetVesselRegistration(VesselRegistration vesselRegistration)
        {
            _carrierRegistrationDbContext.Add(vesselRegistration);
            await _carrierRegistrationDbContext.SaveChangesAsync();
            return vesselRegistration.VesselId;
        }
        [HttpPut("{VesselId}")]
        public async Task<long> UpdateVesselRegistration( long VesselId,VesselRegistration vesselRegistration)
        {
            var item = _carrierRegistrationDbContext.VesselRegistration.Find(VesselId);
            item.VesselId = vesselRegistration.VesselId;
            item.VesselType = vesselRegistration.VesselType;
            item.ShipIdentificationNo = vesselRegistration.ShipIdentificationNo; 
            item.Registrationdate = vesselRegistration.Registrationdate;
            item.NameofShip = vesselRegistration.NameofShip;
            item.NationalityofShip = vesselRegistration.NationalityofShip; 
            item.FlagStateofShip = vesselRegistration.FlagStateofShip; 
            item.IMONo = vesselRegistration.IMONo;
            item.CallSignNo = vesselRegistration.CallSignNo;
            item.PortofRegistration = vesselRegistration.PortofRegistration;
            item.CertificateRegistrationDate = vesselRegistration.CertificateRegistrationDate;
            item.GrossRegistrationTons = vesselRegistration.GrossRegistrationTons;
            item.DeadWeight = vesselRegistration.DeadWeight;
            item.DisplacementWeight = vesselRegistration.DisplacementWeight;
            item.PandIclub = vesselRegistration.PandIclub;
            item.Beam = vesselRegistration.Beam;
            item.StandardDraught = vesselRegistration.StandardDraught;
            item.VesselCapacity = vesselRegistration.VesselCapacity;
            item.AreaofOperation = vesselRegistration.AreaofOperation;
            item.YearBuilt = vesselRegistration.YearBuilt;
            item.VesselTrade = vesselRegistration.VesselTrade;
            item.VesselTerm = vesselRegistration.VesselTerm;
            item.CargoType = vesselRegistration.CargoType;
            item.PositionofBridge = vesselRegistration.PositionofBridge;
            item.TypeofHull = vesselRegistration.TypeofHull;
            item.ApplicantRemarks = vesselRegistration.ApplicantRemarks;
            item.StateName = vesselRegistration.StateName;


            _carrierRegistrationDbContext.Update(item);
            await _carrierRegistrationDbContext.SaveChangesAsync();
            return item.VesselId;
        }
        
        [HttpDelete("{VesselId}")]

        public bool DeleteShipOwnerDetails(long VesselId)
        {
            var VesselRegistration = _carrierRegistrationDbContext.VesselRegistration.Find(VesselId);
            if (VesselRegistration != null)
            {
                _carrierRegistrationDbContext.Remove(VesselRegistration).State = EntityState.Deleted;
                _carrierRegistrationDbContext.SaveChanges();
            }
            return true;
        }
    }
}

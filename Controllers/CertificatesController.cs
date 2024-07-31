using CarrierWebApi.Database;
using CarrierWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarrierWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController(CarrierRegistrationDbContext carrierRegistrationDbContext) : ControllerBase
    {
        private readonly CarrierRegistrationDbContext _carrierRegistrationDbContext = carrierRegistrationDbContext;

        [HttpGet("load/{id}")]
        public async Task<IEnumerable<Certificates>> GetCertificates( long id)
        {
            return await _carrierRegistrationDbContext.Certificates.Where(x=>x.VesselId==id).ToListAsync();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var item = _carrierRegistrationDbContext.Certificates.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
        public async  Task <long> GetCertificates(Certificates certificates)
        {
            _carrierRegistrationDbContext.Add(certificates);
            await _carrierRegistrationDbContext.SaveChangesAsync();
            return certificates.CertificateId;
        }
        [HttpPut("{CertificateId}")]
        public  async Task<long> UpdateCertificates(long CertificateId, Certificates Certificates)
        {
            var item = _carrierRegistrationDbContext.Certificates.Find(CertificateId);
             item.CertificateId = Certificates.CertificateId;
             item.DocumentType = Certificates.DocumentType;
             item.DocumentReferenceNo = Certificates.DocumentReferenceNo;
             item.IssuedDate = Certificates.IssuedDate;
             item.ExpiryDate = Certificates.ExpiryDate;
            _carrierRegistrationDbContext.Update(item);
            await _carrierRegistrationDbContext.SaveChangesAsync();
            return item.CertificateId;
        }
        [HttpDelete("{CertificateId}")]
        
        public bool DeleteCertificates(long CertificateId)
        {
            var Certificate = _carrierRegistrationDbContext.Certificates.Find(CertificateId);
            if (Certificate != null)
            {
                _carrierRegistrationDbContext.Remove(Certificate).State = EntityState.Deleted;
                _carrierRegistrationDbContext.SaveChanges();
            }
            return true;
        }
        
    }
}

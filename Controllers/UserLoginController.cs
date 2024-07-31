using CarrierWebApi.Database;
using CarrierWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarrierWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class UserLoginController(CarrierRegistrationDbContext carrierRegistrationDbContext) : ControllerBase
    {
        
        private readonly CarrierRegistrationDbContext _carrierRegistrationDbContext = carrierRegistrationDbContext;


         [HttpPost]
        public async Task<long> GetUserLogin(UserLogin userLogin)
        {
            _carrierRegistrationDbContext.Add(userLogin);
            await _carrierRegistrationDbContext.SaveChangesAsync();
            return userLogin.UserId;
        }
        [HttpPost("UserLogin")]
        public async Task<IActionResult> AddLogin(UserLogin userobj)
        {
            var entity = await _carrierRegistrationDbContext.UserLogin.FirstOrDefaultAsync(x => x.UserEmailId == userobj.UserEmailId && x.Password == userobj.Password);
            if (entity == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(entity);
            }
        }
       
     
        
    }

}
   
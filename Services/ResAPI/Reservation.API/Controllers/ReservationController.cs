using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infsracture;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ReservationController(IReservationServices reservationService) : ControllerBase
    {
        [HttpGet("{bkgNumber}")]
        public async Task<IActionResult> Get(int bkgNumber)
        {
            ReservationDTO result = await reservationService.GetResByBKNumber(bkgNumber);
            return Ok(result);
        }


    }
}

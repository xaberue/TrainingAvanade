using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Training.Application.Reservations;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {

        private readonly IReservationService _reservationService;


        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }


        [HttpGet("{userId}")]
        public IActionResult Get(Guid userId)
        {
            var reservations = _reservationService.Get(userId);

            return Ok(reservations);
        }
        
        [HttpPost]
        public IActionResult Post(ReservationDto reservation)
        {
            _reservationService.Create(reservation);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(ReservationUpdateDto reservationUpdate)
        {
            _reservationService.Update(reservationUpdate);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _reservationService.Delete(id);

            return Ok();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorControl.Controllers
{
    [ApiController]
    [Route("[controller]/[:id]")]
    public class ElevatorController : ControllerBase
    {
        private readonly ILogger<ElevatorController> _logger;
        private readonly IElevator _elevator;
        private readonly int _id;

        public ElevatorController(ILogger<ElevatorController> logger, IElevator elevator, int id)
        {
            _logger = logger;
            _elevator = elevator;
            _id = id;
        }

        [HttpGet]
        public IEnumerable<int> All()
        {
            return _elevator.All();
        }

        [HttpPut]
        public IActionResult Put(int floor)
        {
            try
            {
                _elevator.FloorRequest(floor, null);
            }
            catch (IndexOutOfRangeException)
            {
                return BadRequest("Wrong floor");
            }

            return Ok();
        }

        [HttpPost]
        IActionResult Next()
        {
            return Ok(_elevator.Next());
        }
    }
}

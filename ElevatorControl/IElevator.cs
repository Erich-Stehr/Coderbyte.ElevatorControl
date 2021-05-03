using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorControl
{
    public interface IElevator
    {
        public int[] All();
        public void FloorRequest(int floor, int? direction = null);
    }
}

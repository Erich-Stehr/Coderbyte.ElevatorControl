using System;
using System.Collections.Generic;

namespace ElevatorControl
{
    public class Elevator: IElevator
    {
        private readonly int[] floors = new int[3];

        public int[] All()
        {
            List<int> result = new List<int>();

            for (int i = 0; i < floors.Length; ++i)
            {
                if (floors[i] != 0)
                    result.Add(i);
            }
            return result.ToArray();
        }

        public void FloorRequest(int floor, int? direction = null)
        {
            // TOOD: use direction for floor calls
            floors[floor] = 1;
        }

        public int? Next()
        {
            // TODO: totally inefficient, but spec calls for interface first then logic
            int? result = null;
            for (int i = 0; i < floors.Length; ++i)
            {
                if (floors[i] != 0)
                {
                    floors[i] = 0;  // TODO: should this be changing here or a new exposed method?
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}

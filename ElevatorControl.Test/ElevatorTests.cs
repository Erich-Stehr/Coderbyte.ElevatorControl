using System;
using Xunit;

namespace ElevatorControl.Test
{
    public class ElevatorTests
    {
        [Fact]
        public void GetAllWhenEmpty()
        {
            var sut = new Elevator();

            var result = sut.All();

            Assert.Equal(new int[0], result);
        }

        [Fact]
        public void GetAllRequesting0()
        {
            var sut = new Elevator();
            sut.FloorRequest(0, null);

            var result = sut.All();

            Assert.Equal(new int[1] { 0 }, result);
        }

        [Fact]
        public void WrongFloor()
        {
            var sut = new Elevator();

            void act() => sut.FloorRequest(10000, null);

            Assert.Throws<IndexOutOfRangeException>(act);
        }
    }
}

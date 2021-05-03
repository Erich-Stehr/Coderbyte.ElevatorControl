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
    }
}

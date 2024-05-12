using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_Test
{
    public class BMWTests
    {
        [Fact]
        public void IsStopped_velocity15_false()
        {
            // Arrange
            BMW x6 = new BMW();
            x6.velocity = 10;

            // Act
            bool result = x6.IsStopped();

            // Boolean Asserts
            Assert.False(result);


            //Numeric Asserts
            Assert.InRange(x6.velocity, 10, 15);

            Assert.NotInRange(x6.velocity, 15, 20);
        }

        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {
            // Arrange
            BMW x6 = new BMW();
            x6.drivingMode = DrivingMode.Stopped;

            // Act
            string result = x6.GetDirection();

          //  string Asserts

            //1
            Assert.Equal("Stopped", result);

            //2
            Assert.StartsWith("S", result);

            //3
            Assert.EndsWith("ed", result);

            //4
            Assert.Contains("pp", result);

            //5
            Assert.DoesNotContain("mm", result);

           
        }

       

    }
}

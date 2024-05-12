using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_Test
{
    public class CarFactoryTests
    {
        [Fact]
        public void GetMyCar_callFunction_SameCar()
        {

            BMW x6 = new BMW();
            BMW x3 = new BMW();

            // Act
            Car car = x6.GetMyCar();

            // Refrence Assert
            Assert.Same(x6, car);
            Assert.NotSame(x3, car);
        }

        [Fact]
        public void NewCar_CarTypeBMW_BMW()
        {
            // Arrange

            // Act
            Car? car = CarFactory.NewCar(CarTypes.BMW);

           

            // Type Asserts
            Assert.IsType<BMW>(car);

            Assert.IsNotType<Toyota>(car);

        }

        [Fact]
        public void NewCar_CarTypeHonda_Exception()
        {
            // Arrange



            // Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }

    }
}

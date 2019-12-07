using Advent01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Advent01
{
    public class ModulesTests
    {

        [Theory]
        [InlineData(14, 2)]
        public void GetAllRequiredFuel_ReturnsFuelBasedItterativelyOnFuel(int mass, int resultingFuel)
        {
            // Arrange
            var module = new Module(mass);

            // Act
            var totalRequiredItterativeFuel = module.GetAllRequiredFuel();

            // Assert
            Assert.Equal(resultingFuel, totalRequiredItterativeFuel);
        }
    }
}

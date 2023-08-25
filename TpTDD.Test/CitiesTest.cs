using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpTDD.Core;

namespace TpTDD.Test
{
    [TestClass]
    public class CitiesTest
    {
        [TestMethod]
        public void SearchCities_WithLessThan2Char_ThrowsNotFoundException()
        {

        // Arrange
        Cities citySearch = new Cities();

            // Act
            // Assert
            Assert.ThrowsException<NotFoundException>(() => citySearch.CitySearch("A"));


        }
    }
}

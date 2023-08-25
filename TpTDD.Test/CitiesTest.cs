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

        [TestMethod]
        public void SearchCities_WithExactAndAbove2Char_MatchCities()
        {
            // Arrange
            Cities citiesSearch = new Cities();

            // Act 
            List<string> results = citiesSearch.CitySearch("Va");
            List<string> excepted = new List<string>()
            {
                "Valence", "Vancouver"
            };

            // Assert
            CollectionAssert.AreEqual(excepted, results);
        }
    }
}

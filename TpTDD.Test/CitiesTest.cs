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
        
        public int MyProperty { get; set; }
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

        [TestMethod]
        public void SearchCities_WithPartialSearch_MatchCities()
        {
            Cities citiesSearch = new Cities();
            List<string> results = citiesSearch.CitySearch("Ape");
            List<string> expected = new List<string>()
            {
                "Budapest"
            };
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void SearchCities_WithAsterix_ReturnAllCities()
        {
            Cities citiesSearch = new Cities();
            List<string> results = citiesSearch.CitySearch("*");
            List<string> asterix = new List<string>()
            {
                "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul", "Italy"
            };
            CollectionAssert.AreEqual(asterix, results);
        }
    }
}

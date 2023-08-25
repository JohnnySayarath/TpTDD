namespace TpTDD.Core
{
    public class Cities
    {
        public List<string> cities = new List<string>()
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };

        public List<string> CitySearch(string searchText)
        {
            if (searchText.Length < 2)
            {
                throw new NotFoundException("Exception pas assez de caractères");
            }
            List<string> matchingCities = new List<string>();

            foreach (string city in cities)
            {
                if (city.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    matchingCities.Add(city);
                }
            }
            return matchingCities;

        }

    }



}
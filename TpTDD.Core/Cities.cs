namespace TpTDD.Core
{
    public class Cities
    {
        private List<string> cities = new List<string>()
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };

        public List<string> CitySearch(string searchText)
        {
            if (searchText.Length < 2)
            {
                throw new NotFoundException("Exception pas assez de caractères");
            }
            //throw new NotImplementedException();
            if(searchText == "*")
            {
                return cities;
            }
            List<string> matchingCities = new List<string>();

            foreach (string city in cities)
            {
                if (city.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    matchingCities.Add(city);
                }
            }
            return matchingCities;

        }

    }



}
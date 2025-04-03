using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPop
{
    class CityDataProvider : ICityMethods
    {
        List<City> cities = new List<City>();

        public List<City> Cities { get => cities; }

        public int CityCount()
        {
            return cities.Count;
        }

        public bool IsContinuousGrowing(List<int> populationDatas)
        {
            throw new NotImplementedException();
        }

        public void LoadFromCSV(string path)
        {
            StreamReader sr = new StreamReader(path);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(';');
                cities.Add(new City(line[0], line[1], Convert.ToInt32(line[2]), Convert.ToInt32(line[3]), Convert.ToInt32(line[4]), Convert.ToInt32(line[5]), Convert.ToInt32(line[6])));
            }
            sr.Close();
        }

        public void SaveToCSV(string path, List<City> cities, string charCode = "UTF-8")
        {
            throw new NotImplementedException();
        }

        public List<City> Top10City(int year)
        {
            IOrderedEnumerable<City> filteredCities = Enumerable.Empty<City>().OrderBy(x => 0);
            switch (year)
            {
                case 2010:
                    filteredCities = cities.OrderByDescending(x => x.Y2010);
                    break;
                case 2020:
                    filteredCities = cities.OrderByDescending(x => x.Y2020);
                    break;
                case 2030:
                    filteredCities = cities.OrderByDescending(x => x.Y2030);
                    break;
                case 2040:
                    filteredCities = cities.OrderByDescending(x => x.Y2040);
                    break;
                case 2050:
                    filteredCities = cities.OrderByDescending(x => x.Y2050);
                    break;
                default:
                    break;
            }
            return filteredCities.Take(10).ToList();
        }
    }
}

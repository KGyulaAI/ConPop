namespace ConPop
{
    public class City
    {
        string cityCode;
        string cityName;
        int y2010;
        int y2020;
        int y2030;
        int y2040;
        int y2050;

        public City(string cityCode, string cityName, int y2010, int y2020, int y2030, int y2040, int y2050)
        {
            this.cityCode = cityCode;
            this.cityName = cityName;
            this.y2010 = y2010;
            this.y2020 = y2020;
            this.y2030 = y2030;
            this.y2040 = y2040;
            this.y2050 = y2050;
        }

        public string CityCode { get => cityCode; }
        public string CityName { get => cityName; }
        public int Y2010 { get => y2010; }
        public int Y2020 { get => y2020; }
        public int Y2030 { get => y2030; }
        public int Y2040 { get => y2040; }
        public int Y2050 { get => y2050; }

        public int Y2010_2050 { get => y2050 - y2010; }

        public bool IsContinousGrowth => y2010 < y2020 && y2020 < y2030 && y2030 < y2040 && y2040 < y2050;
    }
}
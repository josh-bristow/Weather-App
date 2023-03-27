using System.Collections.Generic;

namespace MyWeatherApp
{
    internal class WeatherInfo
    {
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }


        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }


        public class Main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }


        public class Wind
        {
            public double speed { get; set; }
        }


        public class Sys
        {
            public string country { get; set; }
            public double sunrise { get; set; }
            public double sunset { get; set; }
        }


        public class Root
        {
            public string name { get; set; }
            public double dt { get; set; }

            public Sys sys { get; set; }
            public Wind wind { get ; set; }
            public Main main { get; set; }
            public List<Weather> weather { get; set; }
            public Coord coordinte { get; set; }
        }
    }
}

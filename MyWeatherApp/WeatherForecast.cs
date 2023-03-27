using System.Collections.Generic;

namespace MyWeatherApp
{
    public class WeatherForecast
    {
        public City city { get; set; }
        public List<List> list { get; set; }

    }

    public class Main
    {
        public float temp { get; set; }
    }


    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }


    public class Temp
    {
        public double day { get; set; }
    }

    public class City
    {
        public string name { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; }
        public int deg { get; set; }
        public float gust { get; set; }
    }
    public class List
    {
        public double dt { get; set; } //Date in milliseconds
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double speed { get; set; }
        public List<Weather> weather { get; set; }
        public Temp temp { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }

    }
}

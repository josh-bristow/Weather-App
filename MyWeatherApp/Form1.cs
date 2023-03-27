using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace MyWeatherApp
{
    public partial class Form1 : Form
    {

        const string APPID = "API key is used here";
        string cityName = "Durban";
        string measurementUnits = "metric";        

        public Form1()
        {
            InitializeComponent();
            getWeather(cityName);
            getForecast(cityName);
        }

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units={1}&appid={2}", city, measurementUnits, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                WeatherInfo.Root output = result;

                lblCityException.Visible = false;
                lblCityName.Text = string.Format("{0}", output.name);
                lblCountry.Text = string.Format("{0}", output.sys.country);
                lblTemperature.Text = string.Format("{0} \u00b0" + "C", (int)output.main.temp);
                lblHumidity.Text = string.Format("{0}%", output.main.humidity);
                lblWindSpeed.Text = string.Format("{0}km/h", Math.Round(output.wind.speed),0);
                pictureMain.Image = setIcon(output.weather[0].icon);
                lblDescription.Text = string.Format("{0}", output.weather[0].main);
            }
        }

        void getForecast(string city)
        {
            using (WebClient web = new WebClient())
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units={1}&appid={2}", city, measurementUnits, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherForecast>(json);

                WeatherForecast forecast = result;

                const int forecastDay2 = 8;
                const int forecastDay3 = 16;

                // Day 2 Forecast

                lblDay2.Text = string.Format("{0}", getDate(forecast.list[forecastDay2].dt).DayOfWeek);
                lblDescription2.Text = textInfo.ToTitleCase(string.Format("{0}", forecast.list[forecastDay2].weather[0].main));
                lblTemperature2.Text = string.Format("{0} \u00b0" + "C", (int)forecast.list[forecastDay2].main.temp);
                lblWindSpeed2.Text = string.Format("{0}km/h", Math.Round((forecast.list[forecastDay2].wind.speed),0));
                pictureForecastDay2.Image = setIcon(forecast.list[forecastDay2].weather[0].icon);

                // Day 3 Forecast

                lblDay3.Text = string.Format("{0}", getDate(forecast.list[forecastDay3].dt).DayOfWeek);
                lblDescription3.Text = textInfo.ToTitleCase(string.Format("{0}", forecast.list[forecastDay3].weather[0].main));
                lblTemperature3.Text = string.Format("{0} \u00b0" + "C", (int)forecast.list[forecastDay3].main.temp);
                lblWindSpeed3.Text = string.Format("{0}km/h", Math.Round((forecast.list[forecastDay3].wind.speed), 0));
                pictureForecastDay3.Image = setIcon(forecast.list[forecastDay3].weather[0].icon);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        DateTime getDate(double seconds)
        {

            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();

            return day;
        }

        Image setIcon(string iconID)
        {
            string url = string.Format("http://openweathermap.org/img/w/{0}.png", iconID);
            var request = WebRequest.Create(url);
            using (var  response = request.GetResponse())
            using (var weatherIcon = response.GetResponseStream())
            {
                Image weatherImg = Bitmap.FromStream(weatherIcon);
                return weatherImg;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtBoxCitySearch.Text != "")
                {
                    getWeather(txtBoxCitySearch.Text);
                    getForecast(txtBoxCitySearch.Text);
                }
            }
            catch (System.Net.WebException)
            {

                lblCityException.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDescription2_Click(object sender, EventArgs e)
        {

        }
    }
}

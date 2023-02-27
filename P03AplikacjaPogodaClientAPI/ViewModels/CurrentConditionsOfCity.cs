using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaPogodaClientAPI.ViewModels
{
    public class CurrentConditionsOfCity
    {
        public string WeatherText { get; set; }
        public bool HasPrecipitation { get; set; }

        public double TemperatureValue { get; set; }

        //public string TemperatureValueString { get { return TemperatureValue.ToString(); } }
    }
}

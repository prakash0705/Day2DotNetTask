using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    static class TemperatureConverter
    {
        public static double CelciusToFahrenheit(string temperatureCelcius)
        {
            double celcius = Double.Parse(temperatureCelcius);

            return (celcius * 1.8) + 32;
           
        }
        public static double FahrenheitToCelcius(string temeratureFahrenheit)
        {
            double fahrenheit = Double.Parse(temeratureFahrenheit);
            return ((fahrenheit - 32) * 5) / 9;
            
        }
    }
}

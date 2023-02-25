using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassesStructs
{
    static class Temperature
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double celsius = double.Parse(temperatureCelsius);

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;

        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double farenheit = double.Parse(temperatureFahrenheit);

            double celsius = (farenheit - 32) * 5 / 9;

            return celsius;
        }
    }
}

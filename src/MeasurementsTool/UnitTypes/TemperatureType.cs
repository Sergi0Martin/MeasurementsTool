namespace MeasurementsTool.UnitTypes;

public enum TemperatureType
{
    // International System
    Kelvin,
    Celsius,
    Fahrenheit,
}

public static class TemperatureConverter
{
    public static double ConvertTo(this TemperatureType from, TemperatureType to, double value)
    {
        if (from == to)
        {
            return value;
        }

        if (from == TemperatureType.Kelvin)
        {
            if (to == TemperatureType.Celsius)
            {
                return value - 273.15;
            }
            if (to == TemperatureType.Fahrenheit)
            {
                return value * 9 / 5 - 459.67;
            }
        }

        if (from == TemperatureType.Celsius)
        {
            if (to == TemperatureType.Kelvin)
            {
                return value + 273.15;
            }
            if (to == TemperatureType.Fahrenheit)
            {
                return value * 9 / 5 + 32;
            }
        }

        if (from == TemperatureType.Fahrenheit)
        {
            if (to == TemperatureType.Kelvin)
            {
                return (value + 459.67) * 5 / 9;
            }
            if (to == TemperatureType.Celsius)
            {
                return (value - 32) * 5 / 9;
            }
        }

        throw new NotImplementedException("Conversion not implemented");
    }
}

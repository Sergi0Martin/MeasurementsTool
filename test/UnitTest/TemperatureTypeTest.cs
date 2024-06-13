namespace MeasurementsTool.UnitTests;

public sealed class TemperatureTypeTest
{
    [SetUp]
    public void Setup() { }

    [Theory]
    [TestCase(TemperatureType.Celsius, TemperatureType.Fahrenheit, 50.5, 122.9)]
    [TestCase(TemperatureType.Celsius, TemperatureType.Kelvin, 50.5, 323.65)]
    [TestCase(TemperatureType.Fahrenheit, TemperatureType.Celsius, 50.5, 10.277777777777779)]
    [TestCase(TemperatureType.Fahrenheit, TemperatureType.Kelvin, 50.5, 283.42777777777775)]
    [TestCase(TemperatureType.Kelvin, TemperatureType.Celsius, 50.5, -222.64999999999998)]
    [TestCase(TemperatureType.Kelvin, TemperatureType.Fahrenheit, 50.5, -368.77)]
    public void ConvertTo_International_System_Works(TemperatureType from, TemperatureType to, double value, double expectedResult)
    {
        // Act
        var conversion = from.ConvertTo(
            to: to,
            value: value);

        // Assert
        conversion
            .Should()
            .Be(expectedResult);
    }
}

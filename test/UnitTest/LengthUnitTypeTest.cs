namespace MeasurementsTool.UnitTests;

public sealed class LengthUnitTypeTest
{
    [SetUp]
    public void Setup() { }

    [Theory]
    [TestCase(LengthUnitType.M, LengthUnitType.MM, 50.5, 50500)]
    [TestCase(LengthUnitType.MM, LengthUnitType.DM, 50.5, 0.505)]
    [TestCase(LengthUnitType.KM, LengthUnitType.M, 50.5, 50500)]
    public void ConvertTo_International_System_Works(LengthUnitType from, LengthUnitType to, double value, double expectedResult)
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

    [Theory]
    [TestCase(LengthUnitType.YD, LengthUnitType.MM, 50.5, 46177.2)]
    [TestCase(LengthUnitType.FT, LengthUnitType.IN, 50.5, 606)]
    [TestCase(LengthUnitType.IN, LengthUnitType.M, 50.5, 1.2827)]
    public void ConvertTo_Non_International_System_Works(LengthUnitType from, LengthUnitType to, double value, double expectedResult)
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
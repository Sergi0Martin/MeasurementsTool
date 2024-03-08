namespace MeasurementsTool.UnitTests;

public sealed class CapacityUnitTest
{
    [SetUp]
    public void Setup() { }

    [Theory]
    [TestCase(CapacityUnitType.L, CapacityUnitType.mL, 50.5, 50500)]
    [TestCase(CapacityUnitType.mL, CapacityUnitType.L, 50.5, 0.0505)]
    [TestCase(CapacityUnitType.YL, CapacityUnitType.PL, 50.5, 50500000000)]
    [TestCase(CapacityUnitType.YL, CapacityUnitType.yL, 50.5, 5.05E+47)]
    public void ConvertTo_International_System_Works(CapacityUnitType from, CapacityUnitType to, double value, double expectedResult)
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

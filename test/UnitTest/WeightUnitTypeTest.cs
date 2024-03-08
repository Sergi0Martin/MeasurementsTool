namespace MeasurementsTool.UnitTests;

public class WeightUnitTypeTest
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Theory]
    [TestCase(WeightUnitType.KG, WeightUnitType.G, 50.5, 50500)]
    [TestCase(WeightUnitType.G, WeightUnitType.T, 50.5, 0.0000505)]
    [TestCase(WeightUnitType.G, WeightUnitType.MCG, 50.5, 505000)]
    public void ConvertTo_International_System_Works(WeightUnitType from, WeightUnitType to, double value, double expectedResult)
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
    [TestCase(WeightUnitType.LB, WeightUnitType.G, 50.5, 22906.414685)]
    [TestCase(WeightUnitType.KG, WeightUnitType.LongTon, 50.5, 0.0497024296)]
    [TestCase(WeightUnitType.ShortTon, WeightUnitType.OZ, 50.5, 1616000.1068801165)]
    public void ConvertTo_Non_International_System_Works(WeightUnitType from, WeightUnitType to, double value, double expectedResult)
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
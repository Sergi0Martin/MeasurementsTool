namespace MeasurementsTool.UnitTypes;

public enum WeightUnitType
{
    /// International System
    T, // Metric tone
    Q,
    KG,
    HG,
    DAG,
    G,
    DG,
    CG,
    MG,
    MCG,
    /// Non International System
    LongTon, //UK ton
    ShortTon, //US ton
    LB,
    OZ
}

public static class WeightUnitConverter
{
    private static readonly int ConversionFactor = 10;

    private static readonly Dictionary<WeightUnitType, int> InternationalSystemTable = new Dictionary<WeightUnitType, int>()
    {
        {WeightUnitType.T,      1},
        {WeightUnitType.Q,      2},
        {WeightUnitType.KG,     4},
        {WeightUnitType.HG,     5},
        {WeightUnitType.DAG,    6},
        {WeightUnitType.G,      7},
        {WeightUnitType.DG,     8},
        {WeightUnitType.CG,     9},
        {WeightUnitType.MG,     10},
        {WeightUnitType.MCG,    11},
    };

    private static readonly Dictionary<WeightUnitType, double> NonInternationalSystemToKiloGramConversionTable = new Dictionary<WeightUnitType, double>
    {
        { WeightUnitType.LongTon,   1016.0469088},
        { WeightUnitType.ShortTon,  907.1847},
        { WeightUnitType.LB,        0.45359237 },
        { WeightUnitType.OZ,        0.02834952 },
    };

    public static double ConvertTo(this WeightUnitType from, WeightUnitType to, double value)
    {
        if (!InternationalSystemTable.ContainsKey(from))
        {
            value = ConvertNonInternationalSystemToKiloGram(from, value);
            from = WeightUnitType.KG;
        }

        if (!InternationalSystemTable.ContainsKey(to))
        {
            value = from.ConvertTo(WeightUnitType.KG, value);
            return Math.Round(ConvertKiloGramToNonInternationalSystem(to, value), 10, MidpointRounding.AwayFromZero);
        }

        if (from == to)
        {
            return value;
        }

        var fromIndex = InternationalSystemTable[from];
        var toIndex = InternationalSystemTable[to];

        var iterations = fromIndex - toIndex;

        value /= Math.Pow(ConversionFactor, iterations);

        return Math.Round(value, 10, MidpointRounding.AwayFromZero);
    }

    private static double ConvertNonInternationalSystemToKiloGram(WeightUnitType from, double value)
    {
        if (!NonInternationalSystemToKiloGramConversionTable.ContainsKey(from))
        {
            throw new NotImplementedException($"{from} conversion not implemented");
        }

        return value * NonInternationalSystemToKiloGramConversionTable[from];
    }

    private static double ConvertKiloGramToNonInternationalSystem(WeightUnitType to, double value)
    {
        if (!NonInternationalSystemToKiloGramConversionTable.ContainsKey(to))
        {
            throw new NotImplementedException($"{to} conversion not implemented");
        }

        return value / NonInternationalSystemToKiloGramConversionTable[to];
    }
}
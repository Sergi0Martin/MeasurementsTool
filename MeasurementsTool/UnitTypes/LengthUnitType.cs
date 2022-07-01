namespace MeasurementsTool.UnitTypes
{
    public enum LengthUnitType
    {
        // International System
        KM,
        HM,
        DAM,
        M,
        DM,
        CM,
        MM,
        // Non International System
        YD,
        FT,
        IN
    }

    public static class LengthUnitConverter
    {
        private static readonly int ConversionFactor = 10;

        private static readonly Dictionary<LengthUnitType, int> InternationalSystemTable = new Dictionary<LengthUnitType, int>()
        {
            {LengthUnitType.KM,     1},
            {LengthUnitType.HM,     2},
            {LengthUnitType.DAM,    3},
            {LengthUnitType.M,      4},
            {LengthUnitType.DM,     5},
            {LengthUnitType.CM,     6},
            {LengthUnitType.MM,     7},
        };

        private static readonly Dictionary<LengthUnitType, double> NonInternationalSystemToMeterConversionTable = new Dictionary<LengthUnitType, double>
        {
            { LengthUnitType.YD,    0.9144 },
            { LengthUnitType.FT,    0.3048 },
            { LengthUnitType.IN,    0.0254 },
        };

        public static double ConvertTo(this LengthUnitType from, LengthUnitType to, double value)
        {
            if (!InternationalSystemTable.ContainsKey(from))
            {
                value = ConvertNonInternationalSystemToMeter(from, value);
                from = LengthUnitType.M;
            }

            if (!InternationalSystemTable.ContainsKey(to))
            {
                value = from.ConvertTo(LengthUnitType.M, value);
                return Math.Round(ConvertMeterToNonInternationalSystem(to, value), 10, MidpointRounding.AwayFromZero);
            }

            if (from == to)
            {
                return value;
            }

            var fromIndex = InternationalSystemTable[from];
            var toIndex = InternationalSystemTable[to];

            var iterations = fromIndex - toIndex;

            // Increase unit
            if (iterations > 0)
            {
                for (int i = 0; i < iterations; i++)
                {
                    value /= ConversionFactor;
                }
            }

            // Decrease unit
            if (iterations < 0)
            {
                for (int i = 0; i > iterations; i--)
                {
                    value *= ConversionFactor;
                }
            }

            return Math.Round(value, 10, MidpointRounding.AwayFromZero);
        }

        private static double ConvertNonInternationalSystemToMeter(LengthUnitType from, double value)
        {
            if (!NonInternationalSystemToMeterConversionTable.ContainsKey(from))
            {
                throw new NotImplementedException($"{from} conversion not implemented");
            }

            return value * NonInternationalSystemToMeterConversionTable[from];
        }

        private static double ConvertMeterToNonInternationalSystem(LengthUnitType to, double value)
        {
            if (!NonInternationalSystemToMeterConversionTable.ContainsKey(to))
            {
                throw new NotImplementedException($"{to} conversion not implemented");
            }

            return value / NonInternationalSystemToMeterConversionTable[to];
        }
    }
}

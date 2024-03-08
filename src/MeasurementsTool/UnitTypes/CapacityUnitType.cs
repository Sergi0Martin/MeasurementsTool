using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementsTool.UnitTypes;

public enum CapacityUnitType
{
    // International System
    YL,
    ZL,
    EL,
    PL,
    TL,
    GL,
    ML,
    kL,
    hL,
    daL,
    L,
    dL,
    cL,
    mL,
    uL,
    nL,
    pL,
    fL,
    aL,
    zL,
    yL
}

public static class CapacityUnitConverter
{
    private static readonly int ConversionFactor = 10;

    private static readonly Dictionary<CapacityUnitType, int> InternationalSystemTable = new Dictionary<CapacityUnitType, int>()
        {
            {CapacityUnitType.YL,       0},
            {CapacityUnitType.ZL,       3},
            {CapacityUnitType.EL,       6},
            {CapacityUnitType.PL,       9},
            {CapacityUnitType.TL,       12},
            {CapacityUnitType.GL,       15},
            {CapacityUnitType.ML,       18},
            {CapacityUnitType.kL,       19},
            {CapacityUnitType.hL,       20},
            {CapacityUnitType.daL,      21},
            {CapacityUnitType.L,        22},
            {CapacityUnitType.dL,       23},
            {CapacityUnitType.cL,       24},
            {CapacityUnitType.mL,       25},
            {CapacityUnitType.uL,       28},
            {CapacityUnitType.nL,       31},
            {CapacityUnitType.pL,       34},
            {CapacityUnitType.fL,       37},
            {CapacityUnitType.aL,       40},
            {CapacityUnitType.zL,       43},
            {CapacityUnitType.yL,       46}
        };

    public static double ConvertTo(this CapacityUnitType from, CapacityUnitType to, double value)
    {
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
}


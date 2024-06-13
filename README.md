# MeasurementsTool 📐  📏 

[![codecov](https://codecov.io/gh/Sergi0Martin/MeasurementsTool/branch/dev/graph/badge.svg?token=QA8HAR6NME)](https://codecov.io/gh/Sergi0Martin/MeasurementsTool)
[![Production Deploy](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/measurements-tool-nuget-package.yml/badge.svg?branch=master)](https://www.nuget.org/packages/MeasurementsTool)
[![Docs Deploy](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/measurements-tool-docs.yml/badge.svg)](https://sergi0martin.github.io/MeasurementsTool/)

**MeasurementsTool** are simple C# Enum types with cool extension methods for measurement conversions.
### Features
#### Available conversion types:
- Length:
    > **International System**:
            KM, HM, DAM, M, DM, CM, MM
            
    >  **Non International System**:
            YD, FT, IN

- Weight:
    > **International System**:
            T, Q, KG, HG, DAG, G, DG, CG, MG, MCG

    > **Non International System**:
            LongTon, ShortTon, LB, OZ

- Capacity:
    > **International System**: 
            YL, ZL, EL, PL, TL, GL, ML, kL, hL, daL, L, dL, cL, mL, uL, nL, pL, fL, aL, zL, yL

- Temperature:
    > **International System**:
            Celsius, Fahrenheit, Kelvin

### Usage
```csharp
WeightUnitType.<fromWeightUnit>.ConvertTo(<desiredWeightUnit>, <weightValue>)
LengthUnitType.<fromLengthUnit>.ConvertTo(<desiredLengthUnit>, <lengthValue>)
```

#### :
```csharp
WeightUnitType.KG.ConvertTo(WeightUnitType.G, 50.5);
LengthUnitType.KM.ConvertTo(LengthUnitType.M, 50.5);
```

[Github](https://github.com/Sergi0Martin/MeasurementsTool)
[NuGet](https://www.nuget.org/packages/MeasurementsTool/)

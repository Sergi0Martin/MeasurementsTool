# MeasurementsTool 📐  📏 

[![Production Deploy](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/master-release.yml/badge.svg?branch=master)](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/master-release.yml)

[![codecov](https://codecov.io/gh/Sergi0Martin/MeasurementsTool/branch/codecoverage/graph/badge.svg?token=QA8HAR6NME)](https://codecov.io/gh/Sergi0Martin/MeasurementsTool)

[![dev-pipeline](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/dev-pipeline.yml/badge.svg)](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/dev-pipeline.yml)

**MeasurementsTool** are simple C# Enum types with cool extension methods for measurement conversions.
### Features
##### Available conversion types:
- LengthUnit:
    > **International System**:
            KM, HM, DAM, M, DM, CM, MM
    >  **Non International System**:
            YD, FT, IN


- WeightUnit:
    > **International System**:
            T, Q, KG, HG, DAG, G, DG, CG, MG, MCG
    > **Non International System**:
            LongTon, ShortTon, LB, OZ
### Usage
```csharp
WeightUnitType.<fromWeightUnit>.ConvertTo(<desiredWeightUnit>, <weightValue>)
LengthUnitType.<fromLengthUnit>.ConvertTo(<desiredLengthUnit>, <lengthValue>)
```

[Github](https://github.com/Sergi0Martin/MeasurementsTool)
[NuGet](https://www.nuget.org/packages/MeasurementsTool/)
# MeasurementsTool 📐  📏 

[![Production Deploy](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/master-release.yml/badge.svg?branch=master)](https://github.com/Sergi0Martin/MeasurementsTool/actions/workflows/master-release.yml)

**MeasurementsTool** are simple C# Enum types with cool extension methods for measurement conversions.
### Features
##### Available conversion types:
- LengthUnit
- WeightUnit

### Usage
```csharp
WeightUnitType.<fromWeightUnit>.ConvertTo(<desiredWeightUnit>, <weightValue>)
LengthUnitType.<fromLengthUnit>.ConvertTo(<desiredLengthUnit>, <lengthValue>)
```

[Github](https://github.com/Sergi0Martin/MeasurementsTool)
[NuGet](https://www.nuget.org/packages/MeasurementsTool/)
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LuminousIntensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LuminousIntensityTestsBase
    {
        protected abstract double CandelaInOneCandela { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CandelaTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity((double)0.0, LuminousIntensityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new LuminousIntensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LuminousIntensityUnit.Candela, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.PositiveInfinity, LuminousIntensityUnit.Candela));
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.NegativeInfinity, LuminousIntensityUnit.Candela));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.NaN, LuminousIntensityUnit.Candela));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new LuminousIntensity(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void LuminousIntensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new LuminousIntensity(1, LuminousIntensityUnit.Candela);

            QuantityInfo<LuminousIntensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(LuminousIntensity.Zero, quantityInfo.Zero);
            Assert.Equal("LuminousIntensity", quantityInfo.Name);
            Assert.Equal(QuantityType.LuminousIntensity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<LuminousIntensityUnit>().Except(new[] {LuminousIntensityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void CandelaToLuminousIntensityUnits()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(CandelaInOneCandela, candela.Candela, CandelaTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = LuminousIntensity.From(1, LuminousIntensityUnit.Candela);
            AssertEx.EqualTolerance(1, quantity00.Candela, CandelaTolerance);
            Assert.Equal(LuminousIntensityUnit.Candela, quantity00.Unit);

        }

        [Fact]
        public void FromCandela_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.NegativeInfinity));
        }

        [Fact]
        public void FromCandela_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.NaN));
        }

        [Fact]
        public void As()
        {
            var candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(CandelaInOneCandela, candela.As(LuminousIntensityUnit.Candela), CandelaTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var candela = LuminousIntensity.FromCandela(1);

            var candelaQuantity = candela.ToUnit(LuminousIntensityUnit.Candela);
            AssertEx.EqualTolerance(CandelaInOneCandela, (double)candelaQuantity.Value, CandelaTolerance);
            Assert.Equal(LuminousIntensityUnit.Candela, candelaQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(1, LuminousIntensity.FromCandela(candela.Candela).Candela, CandelaTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LuminousIntensity v = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(-1, -v.Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (LuminousIntensity.FromCandela(3)-v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (v + v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(10, (v*10).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(10, (10*v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (LuminousIntensity.FromCandela(10)/5).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, LuminousIntensity.FromCandela(10)/LuminousIntensity.FromCandela(5), CandelaTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LuminousIntensity oneCandela = LuminousIntensity.FromCandela(1);
            LuminousIntensity twoCandela = LuminousIntensity.FromCandela(2);

            Assert.True(oneCandela < twoCandela);
            Assert.True(oneCandela <= twoCandela);
            Assert.True(twoCandela > oneCandela);
            Assert.True(twoCandela >= oneCandela);

            Assert.False(oneCandela > twoCandela);
            Assert.False(oneCandela >= twoCandela);
            Assert.False(twoCandela < oneCandela);
            Assert.False(twoCandela <= oneCandela);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Equal(0, candela.CompareTo(candela));
            Assert.True(candela.CompareTo(LuminousIntensity.Zero) > 0);
            Assert.True(LuminousIntensity.Zero.CompareTo(candela) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Throws<ArgumentException>(() => candela.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Throws<ArgumentNullException>(() => candela.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = LuminousIntensity.FromCandela(1);
            var b = LuminousIntensity.FromCandela(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = LuminousIntensity.FromCandela(1);
            var b = LuminousIntensity.FromCandela(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = LuminousIntensity.FromCandela(1);
            Assert.True(v.Equals(LuminousIntensity.FromCandela(1), CandelaTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LuminousIntensity.Zero, CandelaTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.False(candela.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.False(candela.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(LuminousIntensityUnit.Undefined, LuminousIntensity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LuminousIntensityUnit)).Cast<LuminousIntensityUnit>();
            foreach(var unit in units)
            {
                if(unit == LuminousIntensityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(LuminousIntensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cd", new LuminousIntensity(1, LuminousIntensityUnit.Candela).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cd", new LuminousIntensity(1, LuminousIntensityUnit.Candela).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s1"));
                Assert.Equal("0.12 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s2"));
                Assert.Equal("0.123 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s3"));
                Assert.Equal("0.1235 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s1", culture));
            Assert.Equal("0.12 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s2", culture));
            Assert.Equal("0.123 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s3", culture));
            Assert.Equal("0.1235 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s4", culture));
        }
    }
}
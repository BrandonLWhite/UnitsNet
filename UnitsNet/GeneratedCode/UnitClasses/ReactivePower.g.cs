﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Volt-ampere reactive (var) is a unit by which reactive power is expressed in an AC electric power system. Reactive power exists in an AC circuit when the current and voltage are not in phase.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
#if WINDOWS_UWP
    public sealed partial class ReactivePower
#else
    public partial struct ReactivePower : IComparable, IComparable<ReactivePower>
#endif
    {
        /// <summary>
        ///     Base unit of ReactivePower.
        /// </summary>
        private readonly double _voltamperesReactive;

#if WINDOWS_UWP
        public ReactivePower() : this(0)
        {
        }
#endif

        public ReactivePower(double voltamperesreactive)
        {
            _voltamperesReactive = Convert.ToDouble(voltamperesreactive);
        }

        // Method overloads and with same number of parameters not supported in Universal Windows Platform (WinRT Components).
#if WINDOWS_UWP
        private
#else
        public
#endif
        ReactivePower(long voltamperesreactive)
        {
            _voltamperesReactive = Convert.ToDouble(voltamperesreactive);
        }

        // Method overloads and with same number of parameters not supported in Universal Windows Platform (WinRT Components).
        // Decimal type not supported in Universal Windows Platform (WinRT Components).
#if WINDOWS_UWP
        private
#else
        public
#endif
        ReactivePower(decimal voltamperesreactive)
        {
            _voltamperesReactive = Convert.ToDouble(voltamperesreactive);
        }

        #region Properties

        public static ReactivePowerUnit BaseUnit
        {
            get { return ReactivePowerUnit.VoltampereReactive; }
        }

        /// <summary>
        ///     Get ReactivePower in KilovoltamperesReactive.
        /// </summary>
        public double KilovoltamperesReactive
        {
            get { return (_voltamperesReactive) / 1e3d; }
        }

        /// <summary>
        ///     Get ReactivePower in MegavoltamperesReactive.
        /// </summary>
        public double MegavoltamperesReactive
        {
            get { return (_voltamperesReactive) / 1e6d; }
        }

        /// <summary>
        ///     Get ReactivePower in VoltamperesReactive.
        /// </summary>
        public double VoltamperesReactive
        {
            get { return _voltamperesReactive; }
        }

        #endregion

        #region Static

        public static ReactivePower Zero
        {
            get { return new ReactivePower(); }
        }

        /// <summary>
        ///     Get ReactivePower from KilovoltamperesReactive.
        /// </summary>
        public static ReactivePower FromKilovoltamperesReactive(double kilovoltamperesreactive)
        {
            return new ReactivePower((kilovoltamperesreactive) * 1e3d);
        }

        /// <summary>
        ///     Get ReactivePower from MegavoltamperesReactive.
        /// </summary>
        public static ReactivePower FromMegavoltamperesReactive(double megavoltamperesreactive)
        {
            return new ReactivePower((megavoltamperesreactive) * 1e6d);
        }

        /// <summary>
        ///     Get ReactivePower from VoltamperesReactive.
        /// </summary>
        public static ReactivePower FromVoltamperesReactive(double voltamperesreactive)
        {
            return new ReactivePower(voltamperesreactive);
        }

#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable ReactivePower from nullable KilovoltamperesReactive.
        /// </summary>
        public static ReactivePower? FromKilovoltamperesReactive(double? kilovoltamperesreactive)
        {
            if (kilovoltamperesreactive.HasValue)
            {
                return FromKilovoltamperesReactive(kilovoltamperesreactive.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ReactivePower from nullable MegavoltamperesReactive.
        /// </summary>
        public static ReactivePower? FromMegavoltamperesReactive(double? megavoltamperesreactive)
        {
            if (megavoltamperesreactive.HasValue)
            {
                return FromMegavoltamperesReactive(megavoltamperesreactive.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ReactivePower from nullable VoltamperesReactive.
        /// </summary>
        public static ReactivePower? FromVoltamperesReactive(double? voltamperesreactive)
        {
            if (voltamperesreactive.HasValue)
            {
                return FromVoltamperesReactive(voltamperesreactive.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReactivePowerUnit" /> to <see cref="ReactivePower" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReactivePower unit value.</returns>
        public static ReactivePower From(double val, ReactivePowerUnit fromUnit)
        {
            switch (fromUnit)
            {
                case ReactivePowerUnit.KilovoltampereReactive:
                    return FromKilovoltamperesReactive(val);
                case ReactivePowerUnit.MegavoltampereReactive:
                    return FromMegavoltamperesReactive(val);
                case ReactivePowerUnit.VoltampereReactive:
                    return FromVoltamperesReactive(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReactivePowerUnit" /> to <see cref="ReactivePower" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReactivePower unit value.</returns>
        public static ReactivePower? From(double? value, ReactivePowerUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case ReactivePowerUnit.KilovoltampereReactive:
                    return FromKilovoltamperesReactive(value.Value);
                case ReactivePowerUnit.MegavoltampereReactive:
                    return FromMegavoltamperesReactive(value.Value);
                case ReactivePowerUnit.VoltampereReactive:
                    return FromVoltamperesReactive(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

		
        /// <summary>
		/// Convert a value with unit specified at runtime to another unit within ReactivePowerUnit.
		/// This exists to facilitate UnitSystem.Convert
        /// </summary>
        /// <param name="value">Unit to convert from, must be ReactivePowerUnit</param>
        /// <param name="fromUnit">Unit to convert to, must be ReactivePowerUnit</param>
        /// <returns>The converted value.</returns>
		internal static double DynamicConvert(double value, Enum fromUnit, Enum toUnit)
		{
			return From(value, (ReactivePowerUnit)fromUnit).As((ReactivePowerUnit)toUnit);
		}

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ReactivePowerUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ReactivePowerUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

#if !WINDOWS_UWP
        public static ReactivePower operator -(ReactivePower right)
        {
            return new ReactivePower(-right._voltamperesReactive);
        }

        public static ReactivePower operator +(ReactivePower left, ReactivePower right)
        {
            return new ReactivePower(left._voltamperesReactive + right._voltamperesReactive);
        }

        public static ReactivePower operator -(ReactivePower left, ReactivePower right)
        {
            return new ReactivePower(left._voltamperesReactive - right._voltamperesReactive);
        }

        public static ReactivePower operator *(double left, ReactivePower right)
        {
            return new ReactivePower(left*right._voltamperesReactive);
        }

        public static ReactivePower operator *(ReactivePower left, double right)
        {
            return new ReactivePower(left._voltamperesReactive*(double)right);
        }

        public static ReactivePower operator /(ReactivePower left, double right)
        {
            return new ReactivePower(left._voltamperesReactive/(double)right);
        }

        public static double operator /(ReactivePower left, ReactivePower right)
        {
            return Convert.ToDouble(left._voltamperesReactive/right._voltamperesReactive);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is ReactivePower)) throw new ArgumentException("Expected type ReactivePower.", "obj");
            return CompareTo((ReactivePower) obj);
        }

#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ReactivePower other)
        {
            return _voltamperesReactive.CompareTo(other._voltamperesReactive);
        }

#if !WINDOWS_UWP
        public static bool operator <=(ReactivePower left, ReactivePower right)
        {
            return left._voltamperesReactive <= right._voltamperesReactive;
        }

        public static bool operator >=(ReactivePower left, ReactivePower right)
        {
            return left._voltamperesReactive >= right._voltamperesReactive;
        }

        public static bool operator <(ReactivePower left, ReactivePower right)
        {
            return left._voltamperesReactive < right._voltamperesReactive;
        }

        public static bool operator >(ReactivePower left, ReactivePower right)
        {
            return left._voltamperesReactive > right._voltamperesReactive;
        }

        public static bool operator ==(ReactivePower left, ReactivePower right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltamperesReactive == right._voltamperesReactive;
        }

        public static bool operator !=(ReactivePower left, ReactivePower right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltamperesReactive != right._voltamperesReactive;
        }
#endif

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _voltamperesReactive.Equals(((ReactivePower) obj)._voltamperesReactive);
        }

        public override int GetHashCode()
        {
            return _voltamperesReactive.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(ReactivePowerUnit unit)
        {
            switch (unit)
            {
                case ReactivePowerUnit.KilovoltampereReactive:
                    return KilovoltamperesReactive;
                case ReactivePowerUnit.MegavoltampereReactive:
                    return MegavoltamperesReactive;
                case ReactivePowerUnit.VoltampereReactive:
                    return VoltamperesReactive;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ReactivePower Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ReactivePower Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return UnitParser.ParseUnit<ReactivePower>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    ReactivePowerUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromVoltamperesReactive(x.VoltamperesReactive + y.VoltamperesReactive));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ReactivePower result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out ReactivePower result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(ReactivePower);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ReactivePowerUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ReactivePowerUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static ReactivePowerUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<ReactivePowerUnit>(str.Trim());

            if (unit == ReactivePowerUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ReactivePowerUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is VoltampereReactive
        /// </summary>
        public static ReactivePowerUnit ToStringDefaultUnit { get; set; } = ReactivePowerUnit.VoltampereReactive;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(ReactivePowerUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(ReactivePowerUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ReactivePowerUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ReactivePowerUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of ReactivePower
        /// </summary>
        public static ReactivePower MaxValue
        {
            get
            {
                return new ReactivePower(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of ReactivePower
        /// </summary>
        public static ReactivePower MinValue
        {
            get
            {
                return new ReactivePower(double.MinValue);
            }
        }
    }
}

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

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToElectricPotentialDc
{
    public static class NumberToElectricPotentialDcExtensions
    {
        #region KilovoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double)"/>
        public static ElectricPotentialDc KilovoltsDc(this int value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double?)"/>
        public static ElectricPotentialDc? KilovoltsDc(this int? value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double)"/>
        public static ElectricPotentialDc KilovoltsDc(this long value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double?)"/>
        public static ElectricPotentialDc? KilovoltsDc(this long? value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double)"/>
        public static ElectricPotentialDc KilovoltsDc(this double value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double?)"/>
        public static ElectricPotentialDc? KilovoltsDc(this double? value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double)"/>
        public static ElectricPotentialDc KilovoltsDc(this float value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double?)"/>
        public static ElectricPotentialDc? KilovoltsDc(this float? value) => ElectricPotentialDc.FromKilovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double)"/>
        public static ElectricPotentialDc KilovoltsDc(this decimal value) => ElectricPotentialDc.FromKilovoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double?)"/>
        public static ElectricPotentialDc? KilovoltsDc(this decimal? value) => ElectricPotentialDc.FromKilovoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegavoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double)"/>
        public static ElectricPotentialDc MegavoltsDc(this int value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double?)"/>
        public static ElectricPotentialDc? MegavoltsDc(this int? value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double)"/>
        public static ElectricPotentialDc MegavoltsDc(this long value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double?)"/>
        public static ElectricPotentialDc? MegavoltsDc(this long? value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double)"/>
        public static ElectricPotentialDc MegavoltsDc(this double value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double?)"/>
        public static ElectricPotentialDc? MegavoltsDc(this double? value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double)"/>
        public static ElectricPotentialDc MegavoltsDc(this float value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double?)"/>
        public static ElectricPotentialDc? MegavoltsDc(this float? value) => ElectricPotentialDc.FromMegavoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double)"/>
        public static ElectricPotentialDc MegavoltsDc(this decimal value) => ElectricPotentialDc.FromMegavoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double?)"/>
        public static ElectricPotentialDc? MegavoltsDc(this decimal? value) => ElectricPotentialDc.FromMegavoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrovoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double)"/>
        public static ElectricPotentialDc MicrovoltsDc(this int value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double?)"/>
        public static ElectricPotentialDc? MicrovoltsDc(this int? value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double)"/>
        public static ElectricPotentialDc MicrovoltsDc(this long value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double?)"/>
        public static ElectricPotentialDc? MicrovoltsDc(this long? value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double)"/>
        public static ElectricPotentialDc MicrovoltsDc(this double value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double?)"/>
        public static ElectricPotentialDc? MicrovoltsDc(this double? value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double)"/>
        public static ElectricPotentialDc MicrovoltsDc(this float value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double?)"/>
        public static ElectricPotentialDc? MicrovoltsDc(this float? value) => ElectricPotentialDc.FromMicrovoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double)"/>
        public static ElectricPotentialDc MicrovoltsDc(this decimal value) => ElectricPotentialDc.FromMicrovoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double?)"/>
        public static ElectricPotentialDc? MicrovoltsDc(this decimal? value) => ElectricPotentialDc.FromMicrovoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillivoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double)"/>
        public static ElectricPotentialDc MillivoltsDc(this int value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double?)"/>
        public static ElectricPotentialDc? MillivoltsDc(this int? value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double)"/>
        public static ElectricPotentialDc MillivoltsDc(this long value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double?)"/>
        public static ElectricPotentialDc? MillivoltsDc(this long? value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double)"/>
        public static ElectricPotentialDc MillivoltsDc(this double value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double?)"/>
        public static ElectricPotentialDc? MillivoltsDc(this double? value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double)"/>
        public static ElectricPotentialDc MillivoltsDc(this float value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double?)"/>
        public static ElectricPotentialDc? MillivoltsDc(this float? value) => ElectricPotentialDc.FromMillivoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double)"/>
        public static ElectricPotentialDc MillivoltsDc(this decimal value) => ElectricPotentialDc.FromMillivoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double?)"/>
        public static ElectricPotentialDc? MillivoltsDc(this decimal? value) => ElectricPotentialDc.FromMillivoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region VoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double)"/>
        public static ElectricPotentialDc VoltsDc(this int value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double?)"/>
        public static ElectricPotentialDc? VoltsDc(this int? value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double)"/>
        public static ElectricPotentialDc VoltsDc(this long value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double?)"/>
        public static ElectricPotentialDc? VoltsDc(this long? value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double)"/>
        public static ElectricPotentialDc VoltsDc(this double value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double?)"/>
        public static ElectricPotentialDc? VoltsDc(this double? value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double)"/>
        public static ElectricPotentialDc VoltsDc(this float value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double?)"/>
        public static ElectricPotentialDc? VoltsDc(this float? value) => ElectricPotentialDc.FromVoltsDc(value);

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double)"/>
        public static ElectricPotentialDc VoltsDc(this decimal value) => ElectricPotentialDc.FromVoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double?)"/>
        public static ElectricPotentialDc? VoltsDc(this decimal? value) => ElectricPotentialDc.FromVoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif

// <copyright file="Unit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblemStatement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class Contain Unit Type.
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// Feet store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Feet = new Unit(12.0, "LENGTH");

        /// <summary>
        /// Inch store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Inch = new Unit(1.0, "LENGTH");

        /// <summary>
        /// Yard store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Yard = new Unit(36.0, "LENGTH");

        /// <summary>
        /// centimeter store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Centimeter = new Unit(2.5, "LENGTH");

        /// <summary>
        /// Liter store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Liter = new Unit(1000, "VOLUME");

        /// <summary>
        /// Gallon store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Gallon = new Unit(3780, "VOLUME");

        /// <summary>
        /// Millimeter store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit MiliLeter = new Unit(1, "VOLUME");

        /// <summary>
        /// Gram store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Gram = new Unit(1, "WEIGHT");

        /// <summary>
        /// Kilogram store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Kilogram = new Unit(1000, "WEIGHT");

        /// <summary>
        /// Tonne store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Tonne = new Unit(1000000, "WEIGHT");

        /// <summary>
        /// Tonne store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Celsius = new Unit(1.8, "TEMPERATURE");

        /// <summary>
        /// Tonne store it,s unit Type and base unit value.
        /// </summary>
        public static readonly Unit Fahrenheit = new Unit(0.5, "TEMPERATURE");

        public readonly double Value;

        public readonly string UnitType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class.
        /// Initialize base unit here.
        /// </summary>
        /// <param name="value"> Contain base value of unit.</param>
        /// <param name="unitType"> Contain unit type.</param>
        private Unit(double value, string unitType)
        {
            this.Value = value;
            this.UnitType = unitType;
        }
    }
}
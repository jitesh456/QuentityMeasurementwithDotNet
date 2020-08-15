// <copyright file="Unit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
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
        /// hold value for unit.
        /// </summary>
        public readonly double Value;

        public readonly string UnitType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class.
        /// Initialize base unit here.
        /// </summary>
        /// <param name="value"> Contain base value of unit.</param>
        /// <param name="unitType"> Contain unit type.</param>
        public Unit(double value, string unitType)
        {
            this.Value = value;
            this.UnitType = unitType;

        }
    }
}

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
        /// This is for Length Feet Type.
        /// </summary>
        public static readonly Unit Feet = new Unit(12.0);

        /// <summary>
        /// This is for Length Inch Type.
        /// </summary>
        public static readonly Unit Inch = new Unit(1.0);

        /// <summary>
        /// This is for Length Yard Type.
        /// </summary>
        public static readonly Unit Yard = new Unit(36.0);

        /// <summary>
        /// This is for Length Centimeter Type.
        /// </summary>
        public static readonly Unit Centimeter = new Unit(2.5);

        /// <summary>
        /// hold value for unit.
        /// </summary>
        public readonly double Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class.
        /// Initialize base unit here.
        /// </summary>
        /// <param name="value"> Contain base value of unit</param>
        public Unit(double value)
        {
            this.Value = value;
        }
    }
}

// <copyright file="QuantityMeasurement.cs" company="BridgeLabz Solution">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class For QuantityMeasurment.
    /// </summary>
    public class QuantityMeasurement
    {
        private readonly int feet;
        private readonly int inch;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurement"/> class.
        /// This is for initializing quantity value.
        /// </summary>
        /// <param name="feet"> this store feet Value</param>
        public QuantityMeasurement(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }

        /// <summary>
        /// Gets function return feet value.
        /// </summary>
        public int Feet => this.feet;

        /// <summary>
        /// Gets function return inche value.
        /// </summary>
        public int Inch => this.inch;

        /// <summary>
        /// This method is used for checking Equality.
        /// </summary>
        /// <param name="obj"> referance of Quantity Measurment</param>
        /// <returns> true or false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return base.Equals(obj);
        }

        /// <summary>
        /// For checking hansh code.
        /// </summary>
        /// <returns>return int value</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.feet, this.Feet);
        }
    }
}

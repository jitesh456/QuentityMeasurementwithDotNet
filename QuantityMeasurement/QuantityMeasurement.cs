// <copyright file="QuantityMeasurement.cs" company="BridgeLabz Solution">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
{
    using System;

    /// <summary>
    /// Class For QuantityMeasurment.
    /// </summary>
    public class QuantityMeasurement
    {
        private readonly Unit unit;
        private int quantity;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurement"/> class.
        /// This is for initializing quantity value.
        /// </summary>
        /// <param name="unit"> this store type of unit.</param>
        /// /// <param name="quantity"> this store quantityValue.</param>
        public QuantityMeasurement(Unit unit, int quantity)
        {
            this.unit = unit;
            this.quantity = quantity;
        }

        /// <summary>
        /// Gets function return feet value.
        /// </summary>
        public int Quantity => this.quantity *= (int)this.unit;

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
            return HashCode.Combine(this.quantity, this.Quantity);
        }
    }
}

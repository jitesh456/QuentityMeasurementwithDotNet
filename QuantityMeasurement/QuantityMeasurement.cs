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
        /// <summary>
        /// This function add two quantity.
        /// </summary>
        /// <param name="quantity1">contain first quantity.</param>
        /// <param name="unit1">contain first unit.</param>
        /// <param name="quantity2">contain second quantity.</param>
        /// <param name="unit2">contain second unit.</param>
        /// <returns> addition of 2 quantity.</returns>
        public double AddQuantity(double quantity1, Unit unit1, double quantity2, Unit unit2)
        {
            return this.GetConvertUnit(unit1, quantity1) + this.GetConvertUnit(unit2, quantity2);
        }

        /// <summary>
        /// This function convert quantity.
        /// </summary>
        /// <param name="unit"> this param store unit.</param>
        /// <param name="quantity">this is for storing quantity.</param>
        /// <returns>convert quantity.</returns>
        public double GetConvertUnit(Unit unit, double quantity)
        {
            return quantity = Convert.ToInt32(quantity * unit.Value);
        }

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
        /// This mehod return hash code.
        /// </summary>
        /// <returns> hashcode.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

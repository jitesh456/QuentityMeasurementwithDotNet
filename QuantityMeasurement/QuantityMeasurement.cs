// <copyright file="QuantityMeasurement.cs" company="BridgeLabz Solution">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblemStatement
{
    using System;

    /// <summary>
    /// Class For QuantityMeasurment.
    /// </summary>
    public class QuantityMeasurement
    {
        private readonly Unit unit;

        private double value;

        /// <summary>
        /// Gets value for returning value.
        /// </summary>
        public double Value => this.value;

        /// <summary>
        /// This function add two quantity.
        /// </summary>
        /// <param name="quantity1">contain first quantity.</param>
        /// <param name="unit1">contain first unit.</param>
        /// <param name="quantity2">contain second quantity.</param>
        /// <param name="unit2">contain second unit.</param>
        /// <param name="outputUnit">contain output of unit.</param>
        /// <returns> addition of 2 quantity.</returns>
        public double AddQuantity(double quantity1, Unit unit1, double quantity2, Unit unit2 ,Unit outputUnit)
        {
            if (!unit1.UnitType.Equals(unit2.UnitType))
            {
                throw new QuantityMeasurementException(
                "Unit tye must be same for addition",
                QuantityMeasurementException.ExceptionType.UNIT_TYPE_MUST_BE_SAME);
            }

            double result = this.GetConvertUnit(unit1, quantity1) + this.GetConvertUnit(unit2, quantity2);
            if (outputUnit != null)
            {
                return result = result / outputUnit.Value;
            }

            return result;
        }

        /// <summary>
        /// This function convert quantity.
        /// </summary>
        /// <param name="unit"> this param store unit.</param>
        /// <param name="quantity">this is for storing quantity.</param>
        /// <returns>convert quantity.</returns>
        public double GetConvertUnit(Unit unit, double quantity)
        {
            quantity = Convert.ToInt32(quantity * unit.Value);
            this.value = quantity;
            return quantity;
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

            QuantityMeasurement objs = (QuantityMeasurement)obj;
            if (objs.value.CompareTo(this.value) == 0)
            {
                return true;
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

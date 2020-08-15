// <copyright file="QuantityMeasurementException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurementProblemStatement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for throwing QuantityMeasurement exception.
    /// </summary>
    public class QuantityMeasurementException : Exception
    {
        /// <summary>
        /// This class hould exception type.
        /// </summary>
        public enum ExceptionType
        {
            /// <summary>
            /// This is exception type whan unit type is not valid;
            /// </summary>
            UNIT_TYPE_MUST_BE_SAME,
        }

        public readonly ExceptionType exceptionType;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurementException"/> class.
        /// </summary>
        /// <param name="message"> hold exception message.</param>
        /// <param name="exceptionType"> hold exception type.</param>
        public QuantityMeasurementException(string message, ExceptionType exceptionType)
            : base(message)
       {
            this.exceptionType = exceptionType;
       }
    }
}

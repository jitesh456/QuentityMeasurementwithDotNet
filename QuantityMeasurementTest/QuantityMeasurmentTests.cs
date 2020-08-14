// <copyright file="QuantityMeasurmentTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurmentTest
{
    using NUnit.Framework;
    using QuantityMeasurement;

    /// <summary>
    /// This class is for testing  QuantityMeasurment.
    /// </summary>
    public class QuantityMeasurmentTests
    {
        /// <summary>
        /// Here we place common code required in each test method.
        /// </summary>
        private QuantityMeasurement quantityMeasurement;
        private QuantityMeasurement quantityMeasurement2;

        /// <summary>
        /// function for testing 0 feet equal to Zero.
        /// </summary>
        [Test]
        public void GivenFeetValueAsZero_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.FEET, 0);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 0);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testin if object is equal.
        /// </summary>
        [Test]
        public void GivenQuantityMeasurementObject_WhenEqual_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testin if object is equal.
        /// </summary>
        [Test]
        public void GivenQuantityMeasurementObject_WhenNotEqual_ShouldReturnFalse()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testin if object is null.
        /// </summary>
        [Test]
        public void GivenQuantityMeasurementObject_WhenNull_ShouldReturnFalse()
        {
            bool result = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testing if object is null.
        /// </summary>
        [Test]
        public void GivenQuantityMeasurementObject_WhenTypeNotEqual_ShouldReturnFalse()
        {
            QuantityMeasurmentTests quantityMeasurmentTests = new QuantityMeasurmentTests();
            bool result = this.quantityMeasurement.Equals(quantityMeasurmentTests);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testing if 0 inch is equal to 0 inch.
        /// </summary>
        [Test]
        public void GivenInchValueZero_WhenTypeNotEqual_ShouldReturnFalse()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.INCH, 0);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 0);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 1 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAs1AndInchAs1_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.FEET, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 1);
            Assert.AreNotEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAs1AndFeetAs1_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.INCH, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 1);
            Assert.AreNotEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 12 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAs12AndFeetAs1_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.INCH, 12);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 1);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 12 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAs1AndInchAs12_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.FEET, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 12);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }
    }
}
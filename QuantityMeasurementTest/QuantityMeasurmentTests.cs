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
            this.quantityMeasurement = new QuantityMeasurement(Unit.Feet, 0);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Feet, 0);
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
            this.quantityMeasurement = new QuantityMeasurement(Unit.Inch, 0);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Inch, 0);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 1 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndInchAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Feet, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Inch, 1);
            Assert.AreNotEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsOneAndFeetAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Inch, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Feet, 1);
            Assert.AreNotEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 12 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsTwelveAndFeetAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Inch, 12);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Feet, 1);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 12 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndInchAsTwelve_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Feet, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Inch, 12);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 3 feet is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeetValueAsThreeAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Feet, 3);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Yard, 1);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Feet, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Yard, 1);
            Assert.AreNotEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 inch is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValueAsOneAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Inch, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Yard, 1);
            Assert.AreNotEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 yard is equal to 36 Yard.
        /// </summary>
        [Test]
        public void GivenYardValueAsOneAndInchAsThirtySix_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Yard, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Inch, 36);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 36 Inch  is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValueAsThirtySixAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Inch, 36);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Yard, 1);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 Yard  is equal to 3 Feet.
        /// </summary>
        [Test]
        public void GivenYardValueAsOneAndFeetAsThree_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Yard, 1);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Feet, 3);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }

        /// <summary>
        /// Testing if 1 Yard  is equal to 3 Feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsTwoAndFeetCentimeterAsFive_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement(Unit.Inch, 5);
            this.quantityMeasurement2 = new QuantityMeasurement(Unit.Centimeter, 2);
            Assert.AreEqual(this.quantityMeasurement.Quantity, this.quantityMeasurement2.Quantity);
        }
    }
}
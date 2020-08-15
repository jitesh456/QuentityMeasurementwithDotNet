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
        /// Here we put common code that is need in each method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
            this.quantityMeasurement2 = new QuantityMeasurement();
        }

        /// <summary>
        /// function for testing 0 feet equal to Zero.
        /// </summary>
        [Test]
        public void GivenFeetValueAsZero_WhenEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 0);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 0);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if object is equal.
        /// </summary>
        [Test]
        public void GivenQuantityMeasurementObject_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement = new QuantityMeasurement();
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
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 0);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 0);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 1 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndInchAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 1);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 1);
            Assert.AreNotEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsOneAndFeetAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 1);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 1);
            Assert.AreNotEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 12 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsTwelveAndFeetAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 12);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 1);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 12 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndInchAsTwelve_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 1);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 12);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 3 feet is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeetValueAsThreeAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 3);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Yard, 1);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 feet is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 1);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Yard, 1);
            Assert.AreNotEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 inch is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValueAsOneAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 1);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Yard, 1);
            Assert.AreNotEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 yard is equal to 36 Yard.
        /// </summary>
        [Test]
        public void GivenYardValueAsOneAndInchAsThirtySix_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Yard, 1);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 36);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 36 Inch  is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValueAsThirtySixAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 36);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Yard, 1);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 Yard  is equal to 3 Feet.
        /// </summary>
        [Test]
        public void GivenYardValueAsOneAndFeetAsThree_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Yard, 1);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Feet, 3);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing if 1 Yard  is equal to 3 Feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsTwoAndFeetCentimeterAsFive_WhenNotEqual_ShouldReturnTrue()
        {
            double result1 = new QuantityMeasurement().GetConvertUnit(Unit.Inch, 5);
            double result2 = new QuantityMeasurement().GetConvertUnit(Unit.Centimeter, 2);
            Assert.AreEqual(result1, result2);
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoInch_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.AddQuantity(2, Unit.Inch, 2, Unit.Inch);
            Assert.AreEqual(4, expectedResult);
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInch_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.AddQuantity(1, Unit.Feet, 2, Unit.Inch);
            Assert.AreEqual(14, expectedResult);
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.AddQuantity(1, Unit.Feet, 1, Unit.Feet);
            Assert.AreEqual(24, expectedResult);
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoPointFiveCentimeter_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.AddQuantity(2, Unit.Inch, 2.5, Unit.Centimeter);
            Assert.AreEqual(8, expectedResult);
        }
    }
}
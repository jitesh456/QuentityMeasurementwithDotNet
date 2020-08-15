// <copyright file="QuantityMeasurmentTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurmentTest
{
    using NUnit.Framework;
    using QuantityMeasurementProblemStatement;

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
            this.quantityMeasurement.GetConvertUnit(Unit.Feet, 0);
            this.quantityMeasurement2.GetConvertUnit(Unit.Feet, 0);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
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
            this.quantityMeasurement2.GetConvertUnit(Unit.Feet, 12);
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
        public void GivenInchValueZero_WhenEqual_ShouldReturnFalse()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Inch, 0);
            this.quantityMeasurement2.GetConvertUnit(Unit.Inch, 0);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 feet is equal to 1 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndInchAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Feet, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.Inch, 1);
            Assert.IsFalse(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsOneAndFeetAsOne_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Inch, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.Feet, 1);
            Assert.False(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 12 Inch is equal to 1 feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsTwelveAndFeetAsOne_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Inch, 12);
            this.quantityMeasurement2.GetConvertUnit(Unit.Feet, 1);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 feet is equal to 12 inch.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndInchAsTwelve_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Feet, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.Inch, 12);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 3 feet is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeetValueAsThreeAndYardAsOne_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Feet, 3);
            this.quantityMeasurement2.GetConvertUnit(Unit.Yard, 1);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 feet is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeetValueAsOneAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Feet, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.Yard, 1);
            Assert.IsFalse(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 inch is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValueAsOneAndYardAsOne_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Inch, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.Yard, 1);
            Assert.IsFalse(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 yard is equal to 36 Yard.
        /// </summary>
        [Test]
        public void GivenYardValueAsOneAndInchAsThirtySix_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Yard, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.Inch, 36);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 36 Inch  is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValueAsThirtySixAndYardAsOne_WhenEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Inch, 36);
            this.quantityMeasurement2.GetConvertUnit(Unit.Yard, 1);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 Yard  is equal to 3 Feet.
        /// </summary>
        [Test]
        public void GivenYardValueAsOneAndFeetAsThree_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Yard, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.Feet, 3);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if 1 Yard  is equal to 3 Feet.
        /// </summary>
        [Test]
        public void GivenInchValueAsTwoAndFeetCentimeterAsFive_WhenNotEqual_ShouldReturnTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Inch, 5);
            this.quantityMeasurement2.GetConvertUnit(Unit.Centimeter, 2);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoInch_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.
                AddQuantity(2, Unit.Inch, 2, Unit.Inch, null);
            Assert.AreEqual(4, expectedResult);
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInch_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.
                AddQuantity(1, Unit.Feet, 2, Unit.Inch, null);
            Assert.AreEqual(14, expectedResult);
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.
                AddQuantity(1, Unit.Feet, 1, Unit.Feet, null);
            Assert.AreEqual(24, expectedResult);
        }

        /// <summary>
        /// Testing for adding quantity.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoPointFiveCentimeter_WhenCorrect_ShouldReturnAddition()
        {
            double expectedResult = this.quantityMeasurement.
                AddQuantity(2, Unit.Inch, 2.5, Unit.Centimeter, null);
            Assert.AreEqual(8, expectedResult);
        }

        /// <summary>
        /// Testing if 1000 ml is equal 1 liter .
        /// </summary>
        [Test]
        public void GivenOneLiterAndThousandMiliLiter_WhenEqual_ShouldTrue()
        {
            this.quantityMeasurement.GetConvertUnit(Unit.Liter, 1);
            this.quantityMeasurement2.GetConvertUnit(Unit.MiliLeter, 1000);
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement2));
        }

        /// <summary>
        /// Testing if one Gallon as 3.78 liter .
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreePointEighyLiter_WhenCorrect_ShouldReturnAddition()
        {
            double result = this.quantityMeasurement.
                AddQuantity(1, Unit.Gallon, 3.78, Unit.Liter, Unit.Liter);
            Assert.AreEqual(7.56, result);
        }

        /// <summary>
        /// Testing if 1 Liter as 1000 mililiter .
        /// </summary>
        [Test]
        public void GivenOneLiterAndThousandMiliLiter_WhenCorrect_ShouldReturnAddition()
        {
            double result = this.quantityMeasurement.
                AddQuantity(1, Unit.Liter, 1000, Unit.MiliLeter, null);
            Assert.AreEqual(2000, result);
        }

        /// <summary>
        /// Testing if 1 Liter as 1000 yard  .
        /// </summary>
        [Test]
        public void GivenOneLiterAndThousandYard_WhenUnitTypeDifferent_ShouldReturnProperException()
        {
            var exception = Assert.Throws<QuantityMeasurementException>(() => this.quantityMeasurement
            .AddQuantity(1, Unit.Liter, 1000, Unit.Yard, null));
            Assert.AreEqual(QuantityMeasurementException.ExceptionType.UNIT_TYPE_MUST_BE_SAME, exception.exceptionType);
        }
    }
}
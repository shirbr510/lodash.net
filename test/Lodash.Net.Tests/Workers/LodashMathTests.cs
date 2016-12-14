using System.Linq;
using Lodash.Net.Tests.Workers.Stubs;
using Lodash.Net.Workers;
using NUnit.Framework;

namespace Lodash.Net.Tests.Workers
{
    [TestFixture]
    public class LodashMathTests
    {
        #region Add

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        [TestCase(0, 17, 17)]
        [TestCase(0, -1, -1)]
        [TestCase(-5, -7, -12)]
        [TestCase(-5, 7, 2)]
        [TestCase(-300, 0, -300)]
        [TestCase(300, 0, 300)]
        [TestCase(0, 0, 0)]
        public void Add_Numbers_ReturnsExpectedResult(double num, double num2, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Add(num, num2);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Substract

        [Test]
        [TestCase(2, 3, -1)]
        [TestCase(-1, 1, -2)]
        [TestCase(0, 17, -17)]
        [TestCase(0, -1, 1)]
        [TestCase(-5, -7, 2)]
        [TestCase(-5, 7, -12)]
        [TestCase(-300, 0, -300)]
        [TestCase(300, 0, 300)]
        [TestCase(0, 0, 0)]
        public void Substract_Numbers_ReturnsExpectedResult(double num1, double num2, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Substract(num1, num2);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Multiply

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(-1, 1, -1)]
        [TestCase(0, 17, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(-5, -7, 35)]
        [TestCase(-5, 7, -35)]
        [TestCase(-300, 0, 0)]
        [TestCase(300, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_Numbers_ReturnsExpectedResult(double num1, double num2, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Multiply(num1, num2);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Divide

        [Test]
        [TestCase(3, 2, 1.5)]
        [TestCase(-1, 1, -1)]
        [TestCase(0, 17, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(-25, -5, 5)]
        [TestCase(-25, 5, -5)]
        [TestCase(-300, 0, double.NegativeInfinity)]
        [TestCase(300, 0, double.PositiveInfinity)]
        [TestCase(0, 0, double.NaN)]
        public void Divide_Numbers_ReturnsExpectedResult(double num1, double num2, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Divide(num1, num2);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Ceil

        [Test]
        [TestCase(1.2345, 3, 1.235)]
        [TestCase(54.321, 0, 55)]
        [TestCase(78, 0, 78)]
        [TestCase(56.78, 2, 56.78)]
        [TestCase(-1337.1337, 1, -1337.1)]
        [TestCase(1780.1, -1, 1790)]

        public void Ceil_NumberPrecision_ReturnsExpectedResult(double num, int precision, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Ceil(num, precision);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Floor

        [Test]
        [TestCase(1.2345, 3, 1.234)]
        [TestCase(54.321, 0, 54)]
        [TestCase(78, 0, 78)]
        [TestCase(56.78, 2, 56.78)]
        [TestCase(-1337.1337, 1, -1337.2)]
        [TestCase(1780.1, -1, 1780)]

        public void Floor_NumberPrecision_ReturnsExpectedResult(double num, int precision, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Floor(num, precision);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Round

        [Test]
        [TestCase(1.2345001, 3, 1.235)]
        [TestCase(54.321, 0, 54)]
        [TestCase(78, 0, 78)]
        [TestCase(56.78, 2, 56.78)]
        [TestCase(-1337.1337, 1, -1337.1)]
        [TestCase(1780.1, -1, 1780)]

        public void Round_NumberPrecision_ReturnsExpectedResult(double num, int precision, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Round(num, precision);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Max

        [Test]
        public void Max_RangeOneToFifty_ReturnsFifty()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper);
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Max(elements);

            //Assert
            Assert.That(result, Is.EqualTo(upper));
        }

        [Test]
        public void Max_RangeOneToFiftyDescending_ReturnsFifty()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Max(elements);

            //Assert
            Assert.That(result, Is.EqualTo(upper));
        }

        #endregion

        #region MaxBy

        [Test]
        public void MaxBy_RangeOneToFiftyWithPropertySelector_ReturnsObjectThatHasNumberFifty()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num));
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.MaxBy(elements, "Number");

            //Assert
            Assert.That(result.Number, Is.EqualTo(upper));
        }

        [Test]
        public void MaxBy_RangeOneToFiftyWithPropertySelectorDescending_ReturnsObjectThatHasNumberFifty()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num)).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.MaxBy(elements, "Number");

            //Assert
            Assert.That(result.Number, Is.EqualTo(upper));
        }

        #endregion

        #region Min

        [Test]
        public void Min_RangeOneToFifty_ReturnsOne()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper);
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Min(elements);

            //Assert
            Assert.That(result, Is.EqualTo(lower));
        }

        [Test]
        public void Min_RangeOneToFiftyDescending_ReturnsOne()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Min(elements);

            //Assert
            Assert.That(result, Is.EqualTo(lower));
        }

        #endregion

        #region MinBy

        [Test]
        public void MinBy_RangeOneToFiftyWithPropertySelector_ReturnsObjectThatHasNumberOne()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num));
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.MinBy(elements, "Number");

            //Assert
            Assert.That(result.Number, Is.EqualTo(lower));
        }

        [Test]
        public void MinBy_RangeOneToFiftyWithPropertySelectorDescending_ReturnsObjectThatHasNumberOne()
        {
            //Arrange
            const int lower = 1;
            const int upper = 50;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num)).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.MinBy(elements, "Number");

            //Assert
            Assert.That(result.Number, Is.EqualTo(lower));
        }

        #endregion

        #region Mean

        [Test]
        public void Mean_RangeOneToSeven_ReturnsFour()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 4;
            var elements = Enumerable.Range(lower, upper);
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Mean(elements);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Mean_RangeOneToSevenDescending_ReturnsFour()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 4;
            var elements = Enumerable.Range(lower, upper).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Mean(elements);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region MeanBy

        [Test]
        public void MeanBy_RangeOneToSevenWithPropertySelector_ReturnsFour()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 4;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num));
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.MeanBy(elements, "Number");

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void MeanBy_RangeOneToSevenWithPropertySelectorDescending_ReturnsFour()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 4;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num)).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.MeanBy(elements, "Number");

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region Sum

        [Test]
        public void Sum_RangeOneToSeven_ReturnsTwentyEight()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 28;
            var elements = Enumerable.Range(lower, upper);
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Sum(elements);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Sum_RangeOneToSevenDescending_ReturnsTwentyEight()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 28;
            var elements = Enumerable.Range(lower, upper).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Sum(elements);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion

        #region SumBy

        [Test]
        public void SumBy_RangeOneToSevenPropertySelector_ReturnsTwentyEight()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 28;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num));
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.SumBy(elements, "Number");

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SumBy_RangeOneToSevenPropertySelectorDescending_ReturnsTwentyEight()
        {
            //Arrange
            const int lower = 1;
            const int upper = 7;
            const int expectedResult = 28;
            var elements = Enumerable.Range(lower, upper).Select(num => new NumberStub(num)).Reverse();
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.SumBy(elements, "Number");

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #endregion
    }
}

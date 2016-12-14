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
        public void Add_Numbers_ReturnsExpectedResult(double num1, double num2, double expectedResult)
        {
            //Arrange
            var lodashMath = new LodashMath(new LodashUtil());

            //Act
            var result = lodashMath.Add(num1, num2);

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
    }
}

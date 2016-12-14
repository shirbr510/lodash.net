using System.Linq;
using Lodash.Net.Tests.Workers.Stubs;
using Lodash.Net.Workers;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Lodash.Net.Tests.Workers
{
    [TestFixture]
    public class LodashMathTests
    {
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

using System.Linq;
using Lodash.Net.Extensions;
using Lodash.Net.Logics.Cloners;
using Lodash.Net.Logics.Randomizers;
using Lodash.Net.Methods;
using NUnit.Framework;

namespace Lodash.Net.Tests.Methods
{
    [TestFixture]
    public class LodashNumberTests
    {
        #region Clamp

        [Test]
        public void Clamp_MinusTenMinusFiveFive_ShouldReturnMinusFive()
        {
            //Arrange
            const int lower = -5;
            const int upper = 5;
            const int number = -10;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.Clamp(number, lower, upper);

            //Assert
            Assert.That(result, Is.EqualTo(lower));
        }

        [Test]
        public void Clamp_TenMinusFiveFive_ShouldReturnFive()
        {
            //Arrange
            const int lower = -5;
            const int upper = 5;
            const int number = 10;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.Clamp(number, lower, upper);

            //Assert
            Assert.That(result, Is.EqualTo(upper));
        }

        [Test]
        public void Clamp_TwoMinusFiveFive_ShouldReturnTwo()
        {
            //Arrange
            const int lower = -5;
            const int upper = 5;
            const int number = 2;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.Clamp(number, lower, upper);

            //Assert
            Assert.That(result, Is.EqualTo(number));
        }

        [Test]
        public void Clamp_LowerIsSmallerThenUpper_ShouldReturnNormally()
        {
            //Arrange
            const int lower = 5;
            const int upper = -5;
            const int number = 2;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.Clamp(number, lower, upper);

            //Assert
            Assert.That(result, Is.EqualTo(number));
        }

        #endregion

        #region InRange

        [Test]
        public void InRange_MinusTenMinusFiveFive_ShouldReturnFalse()
        {
            //Arrange
            const int lower = -5;
            const int upper = 5;
            const int number = -10;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.InRange(number, lower, upper);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void InRange_TenMinusFiveFive_ShouldReturnFalse()
        {
            //Arrange
            const int lower = -5;
            const int upper = 5;
            const int number = 10;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.InRange(number, lower, upper);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void InRange_TwoMinusFiveFive_ShouldReturnTrue()
        {
            //Arrange
            const int lower = -5;
            const int upper = 5;
            const int number = 2;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.InRange(number, lower, upper);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void InRange_LowerIsSmallerThenUpper_ShouldReturnTrue()
        {
            //Arrange
            const int lower = 5;
            const int upper = -5;
            const int number = 2;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.InRange(number, lower, upper);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void InRange_MinusFiveTen_ShouldReturnFalse()
        {
            //Arrange
            const int upper = 10;
            const int number = -5;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.InRange(number, upper);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void InRange_FiveFive_ShouldReturnFalse()
        {
            //Arrange
            const int upper = 5;
            const int number = 5;
            var lodashNumber = LodashNumberProvider();

            //Act
            var result = lodashNumber.InRange(number, upper);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region Random

        [Test]
        public void Random_ZeroOneTrue_ShouldReturnNumberBetweenZeroAndOne()
        {
            //Arrange
            const int lower = 0;
            const int upper = 1;
            const bool floating = true;
            const int callCount = 1000000;
            var results = new double[callCount];
            var lodashNumber = LodashNumberProvider();

            //Act
            for (var i = 0; i < callCount; i++)
            {
                results[i] = lodashNumber.Random(lower, upper, floating);
            }

            //Assert
            Assert.That(results.Max(), Is.LessThan(upper));
            Assert.That(results.Max(), Is.GreaterThanOrEqualTo(lower));
        }

        [Test]
        public void Random_ZeroOneFalse_ShouldReturnFalse()
        {
            //Arrange
            const int lower = 0;
            const int upper = 1;
            const bool floating = false;
            const int callCount = 1000000;
            var results = new double[callCount];
            var lodashNumber = LodashNumberProvider();

            //Act
            for (var i = 0; i < callCount; i++)
            {
                results[i] = lodashNumber.Random(lower, upper, floating);
            }

            //Assert
            var distinctResults = results.Distinct().ToArray();
            Assert.That(distinctResults.Length, Is.EqualTo(1));
            Assert.That(distinctResults.First(), Is.EqualTo(0));
        }

        [Test]
        public void Random_SevenTrue_ShouldReturnNumberBetweenZeroAndSeven()
        {
            //Arrange
            const int upper = 7;
            const bool floating = true;
            const int callCount = 1000000;
            var results = new double[callCount];
            var lodashNumber = LodashNumberProvider();

            //Act
            for (var i = 0; i < callCount; i++)
            {
                results[i] = lodashNumber.Random(upper, floating);
            }

            //Assert
            Assert.That(results.Max(), Is.LessThan(upper));
            Assert.That(results.Max(), Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void Random_Seven_ShouldReturnNumberBetweenZeroAndSevenNonFloating()
        {
            //Arrange
            const int upper = 7;
            const int callCount = 1000000;
            var results = new double[callCount];
            var lodashNumber = LodashNumberProvider();

            //Act
            for (var i = 0; i < callCount; i++)
            {
                results[i] = lodashNumber.Random(upper);
            }

            //Assert
            Assert.That(results.Max(), Is.LessThan(upper));
            Assert.That(results.Max(), Is.GreaterThanOrEqualTo(0));
            Assert.That(results.Select(item => item).All(item => item.IsInteger()), Is.True);
        }

        [Test]
        public void Random_MinusSeven_ShouldReturnNumberBetweenZeroAndMinusSevenNonFloating()
        {
            //Arrange
            const int upper = -7;
            const int callCount = 1000000;
            var results = new double[callCount];
            var lodashNumber = LodashNumberProvider();

            //Act
            for (var i = 0; i < callCount; i++)
            {
                results[i] = lodashNumber.Random(upper);
            }

            //Assert
            Assert.That(results.Max(), Is.LessThan(0));
            Assert.That(results.Max(), Is.GreaterThanOrEqualTo(upper));
            Assert.That(results.Select(item => item).All(item => item.IsInteger()), Is.True);
        }

        #endregion

        private static LodashNumber LodashNumberProvider()
        {
            return new LodashNumber(new LodashMath(new LodashUtil()), new LodashLang(new ShallowObjectCloner(), new DeepObjectCloner()), new FloatingRandomizer());
        }
    }
}

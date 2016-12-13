using System.Linq;
using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.Static;
using NUnit.Framework;

namespace Lodash.Net.Tests.Static
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class _Tests
    {
        [Test]
        public void Instance_HundredTimes_ReturnsSameInstance()
        {
            //Arrange
            const int callCount = 100;
            var results = new ILodashInstance[callCount];

            //Act
            for (var i = 0; i < callCount; i++)
            {
                results[i] = _.Instance;
            }

            //Assert
            Assert.That(results.Distinct().Count(), Is.EqualTo(1));
        }

        [Test]
        public void Instance_Once_DoesNotReturnNull()
        {
            //Arrange + Act
            var result = _.Instance;

            //Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}

using System.Linq;
using Lodash.Net.Data.Instance.Abstract;
using NUnit.Framework;

namespace Lodash.Net.Tests.Static
{
    [TestFixture]
    public class LodashTests
    {
        [Test]
        public void Instance_HundredTimes_ReturnsSameInstance()
        {
            //Arrange
            var callCount = 100;
            var results = new ILodashInstance[callCount];

            //Act
            for (var i = 0; i < callCount; i++)
            {
                results[i] = Net.Static.Lodash.Instance;
            }

            //Assert
            Assert.That(results.Distinct().Count(), Is.EqualTo(1));
        }

        [Test]
        public void Instance_Once_DoesNotReturnNull()
        {
            //Arrange + Act
            var result = Net.Static.Lodash.Instance;

            //Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}

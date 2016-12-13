using System;
using System.Linq;
using System.Threading;
using Lodash.Net.Workers;
using NUnit.Framework;

namespace Lodash.Net.Tests.Workers
{
    [TestFixture]
    public class LodashDateTests
    {
        #region Now

        [Test]
        public void Now_RunFiftyTimes_NoResultEqual()
        {
            //Arrange
            const int runAmount = 50;
            var lodashDate = new LodashDate();
            var results = new double[runAmount];

            //Act
            for (var i = 0; i < runAmount; i++)
            {
                results[i] = lodashDate.Now();
                Thread.Sleep(1);
            }

            //Assert
            var distinctResults = results.Distinct();
            Assert.That(results.Length, Is.EqualTo(distinctResults.Count()));

        }

        [Test]
        public void Now_RunOnce_IsTodaysDate()
        {
            //Arrange
            var lodashDate = new LodashDate();
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            //Act
            var result = lodashDate.Now();
            var datetimeNow = DateTime.UtcNow;

            //Assert
            var epochNow = epoch.AddMilliseconds(result);
            Assert.That(epochNow.Date, Is.EqualTo(datetimeNow.Date));
            Assert.That(epochNow.Hour, Is.EqualTo(datetimeNow.Hour));
            Assert.That(epochNow.Minute, Is.EqualTo(datetimeNow.Minute));
            Assert.That(epochNow.Second, Is.EqualTo(datetimeNow.Second));
            Assert.That(epochNow.Millisecond, Is.EqualTo(datetimeNow.Millisecond));
            //Asserting up to milliseconds and not ticks because further then that is impossible
        }

        #endregion

    }
}

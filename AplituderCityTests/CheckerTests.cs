using NUnit.Framework;

namespace AmplituderCity.Tests
{
    public class CheckerTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            var checker = new CheckerInFile("Polska", "Pomorskie", "Gdynia");
            checker.AddGrade(52);

            var statistics = checker.GetStatistics();

            Assert.AreEqual(52, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            var checker = new CheckerInFile("Polska", "Pomorskie", "Gdynia");
            checker.AddGrade(14);

            var statistics = checker.GetStatistics();

            Assert.AreEqual(14, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var checker = new CheckerInFile("Polska", "Pomorskie", "Gdynia");
            checker.AddGrade(52);
            checker.AddGrade(24);
            checker.AddGrade(14);

            var statistics = checker.GetStatistics();

            Assert.AreEqual(30, statistics.Average);
        }
    }
}

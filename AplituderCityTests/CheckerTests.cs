using NUnit.Framework;

namespace AmplituderCity.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void AddGrade_WhenCalled_ShouldUpdateMinAndMax()
        {
            // Arrange
            var statistics = new Statistics();

            // Act
            statistics.AddGrade(80);
            statistics.AddGrade(70);
            statistics.AddGrade(90);

            // Assert
            Assert.AreEqual(70, statistics.Min);
            Assert.AreEqual(90, statistics.Max);
        }

        [Test]
        public void AddGrade_WhenCalled_ShouldUpdateCountAndSum()
        {
            // Arrange
            var statistics = new Statistics();

            // Act
            statistics.AddGrade(80);
            statistics.AddGrade(70);
            statistics.AddGrade(90);

            // Assert
            Assert.AreEqual(3, statistics.Count);
            Assert.AreEqual(240, statistics.Sum);
        }

        [Test]
        public void Average_WhenNoGradesAdded_ShouldReturnZero()
        {
            // Arrange
            var statistics = new Statistics();

            // Assert
            Assert.AreEqual(0, statistics.Average);
        }

        [Test]
        public void Average_WhenGradesAdded_ShouldReturnCorrectAverage()
        {
            // Arrange
            var statistics = new Statistics();

            // Act
            statistics.AddGrade(80);
            statistics.AddGrade(70);
            statistics.AddGrade(90);

            // Assert
            Assert.AreEqual(80, statistics.Average);
        }
    }
}

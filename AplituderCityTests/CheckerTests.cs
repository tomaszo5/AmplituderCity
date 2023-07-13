using NUnit.Framework;
using System.IO;
namespace AmplituderCity.Tests
{
    public class CheckerTests
    {
 [Test]
        public void AddGrade_WhenCalledWithValidByteGrade_ShouldWriteGradeToFile()
        {
            // Arrange
            var checker = new CheckerInFile("Country", "Land", "City");
            var grade = (byte)50;

            // Act
            checker.AddGrade(grade);

            // Assert
            var grades = File.ReadAllLines(checker.fileName);
            Assert.Contains(grade.ToString(), grades);
        }

        [Test]
        public void AddGrade_WhenCalledWithInvalidIntGrade_ShouldThrowException()
        {
            // Arrange
            var checker = new CheckerInFile("Country", "Land", "City");
            var invalidGrade = 200;

            // Act & Assert
            Assert.Throws<Exception>(() => checker.AddGrade(invalidGrade));
        }
    }
}

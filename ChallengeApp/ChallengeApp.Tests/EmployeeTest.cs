namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void MinGradeTest()
        {
            //arrange
            var employee = new Employee("Mateusz", "Kowalski");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade('A');
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(5f, result.Min);
        }
        [Test]
        public void MaxGradeTest()
        {
            //arrange
            var employee = new Employee("Monika", "Sek");
            employee.AddGrade("5");
            employee.AddGrade(7);
            employee.AddGrade(2);
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(7f, result.Max);
        }
        [Test]
        public void AverageGradeTest()
        {
            //arrange
            var employee = new Employee("Zuzia", "Graszka");
            employee.AddGrade(4);
            employee.AddGrade('A');
            employee.AddGrade(7);
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(37, result.Average);
        }

        [Test]
        public void AverageLetterTest()
        {
            var employee = new Employee("Marianna", "Kulesza");
            employee.AddGrade('A');
            employee.AddGrade('C');
            employee.AddGrade(50);

            var result = employee.GetStatistics();

            Assert.AreEqual('B', result.AverageLetter);

        }
    }
}

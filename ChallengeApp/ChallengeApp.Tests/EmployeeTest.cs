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
            employee.AddGrade(11);
            // act
            var result = employee.GetStatistics()   ;
            // assert
            Assert.AreEqual(5, result.Min); 
        }
        [Test]
        public void MaxGradeTest()
        {
            //arrange
            var employee = new Employee("Monika", "Sek");
            employee.AddGrade(3);
            employee.AddGrade(7);
            employee.AddGrade(2);
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(7, result.Max);
        }
        [Test]
        public void AvarageGradeTest()
        {
            //arrange
            var employee = new Employee("Zuzia", "Graszka");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(4, result.Avarage);
        }
    }

} 
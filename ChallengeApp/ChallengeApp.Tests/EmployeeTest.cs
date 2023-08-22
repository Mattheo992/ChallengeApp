namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectOnlyPositiveScores_ShouldCorrectResult()
        {
            //arrange
            var employee1 = new Employee("Mateusz", "Kowalski", 26);
            employee1.AddScore(5);
            employee1.AddScore(6);
            employee1.AddScore(11);
            // act
            var result = employee1.Result;
            // assert
            Assert.AreEqual(22, result); 
        }
        [Test]
        public void WhenUserCollectOnlyNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var employee2 = new Employee("Monika", "Sek", 31);
            employee2.AddScore(-2);
            employee2.AddScore(-4);
            employee2.AddScore(-6);
            // act
            var result = employee2.Result;
            // assert
            Assert.AreEqual(-12, result);
        }
        [Test]
        public void WhenUserCollectMixedScores_ShouldCorrectResult()
        {
            //arrange
            var employee3 = new Employee("Zuzia", "Graszka", 42);
            employee3.AddScore(-2);
            employee3.AddScore(7);
            employee3.AddScore(5);
            // act
            var result = employee3.Result;
            // assert
            Assert.AreEqual(10, result);
        }
    }

} 
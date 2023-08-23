using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestIntValue()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;
            // act

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TestFloatValue()
        {
            //arrange
            float number3 = 3;
            float number4 = 11;
            // act

            // assert
            Assert.AreNotEqual(number3, number4);
        }
        [Test]
        public void TestLetterValue()
        {

            char letter1 = 'c';
            char letter2 = 'd';


            // assert
            Assert.AreNotEqual(letter1, letter2);
        }

        [Test]
        public void TestNameValue()
        {
            //arrange
            string name1 = "Adam";
            string name2 = "Adam";
            // act

            // assert
            Assert.AreEqual(name1, name2);
        }
    }
}








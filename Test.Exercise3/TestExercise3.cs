using System;
using Xunit;

namespace Test.Exercise3
{
    public class TestExercise3
    {
        (int woman, double answerYes, double answerNo) woman =  (3, 2, 1);
        (int man, double answerYes, double answerNo) men = (2, 1, 1);

        [Fact]
        public void Should_Return_How_Many_People_Answered_Yes()
        {
            //Given
            var exercise3 = new Exercise3();

            //When
            var result = exercise3.PeopleAnsweredYes(men.answerYes, woman.answerYes);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Should_Return_How_Many_People_Answered_No()
        {
            var exercise3 = new Exercise3();

            //When
            var result = exercise3.PeopleAnsweredNo(men.answerNo, woman.answerNo);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Should_Return_Percentage_Of_Women_Who_Answered_Yes()
        {
            var exercise3 = new Exercise3();

            //When
            var result = exercise3.PercentageOfWomenAnsweredYes(woman.answerYes, woman.woman);

            Assert.Equal(66.67, result);
        }

        [Fact]
        public void Should_Return_Percentage_Of_Men_Who_Answered_No()
        {
            var exercise3 = new Exercise3();

            //When
            var result = exercise3.PercentageOfMenAnsweredNo(men.answerNo, men.man);

            Assert.Equal(50.00, result);
        }
    }
}

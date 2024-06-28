using Godot;

namespace Lesson_01_Tests
{
    public class vector_calculator_tests
    {
        [Fact]
        public void CalculatePointOnCircle_Test1()
        {
            var expectedX = 10;
            var expectedY = 0; 

            var startPosition = new Vector2(0, 0);
            var actual = vector_calculator.CalculatePointOnCircle(10, startPosition, 0); 

            Assert.Equal(expectedX, actual.X);
            Assert.Equal(expectedY, actual.Y);

        }

        [Fact]
        public void CalculatePointOnCircle_Test2()
        {
            var expectedX = 15;
            var expectedY = 5;

            var startPosition = new Vector2(5, 5);
            var actual = vector_calculator.CalculatePointOnCircle(10, startPosition, 0);

            Assert.Equal(expectedX, actual.X);
            Assert.Equal(expectedY, actual.Y);

        }

    }
}
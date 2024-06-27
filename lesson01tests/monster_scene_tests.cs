using Godot;

namespace Lesson_01_Tests
{
    public class monster_scene_tests
    {
        [Fact]
        public void CalculatePointOnCircle_Test1()
        {
            var expectedX = 10;
            var expectedY = 0; 

            var startPosition = new Vector2(0, 0);
            var actual = monster_scene.CalculatePointOnCircle(10, startPosition, 0); 

            Assert.Equal(expectedX, actual.X);
            Assert.Equal(expectedY, actual.Y);

        }
    }
}
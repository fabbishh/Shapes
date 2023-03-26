using ShapeLibrary;

namespace TestProject1
{
    public class ShapeTests  
    {
        [Fact]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            var firstTriangle = ShapeFactory.CreateShape(ShapeType.Triangle, 3, 4, 5);
            var secondTriangle = ShapeFactory.CreateShape(ShapeType.Triangle, 3, 4, 4);
            Assert.True(firstTriangle.IsRightAngled());
            Assert.False(secondTriangle.IsRightAngled());
        }

        [Fact]
        public void Triangle_GetArea_ReturnsCorrectArea()
        {
            var triangle = ShapeFactory.CreateShape(ShapeType.Triangle, 3, 4, 5);
            var triangleArea = triangle.GetArea();
            Assert.Equal(6, triangleArea);
        }

        [Fact]  
        public void Circle_GetArea_ReturnsCorrectArea()
        {
            var circle = ShapeFactory.CreateShape(ShapeType.Circle, 5);
            var circleArea = circle.GetArea();
            Assert.Equal(78.5, Math.Round(circleArea, 1));
        }

        [Fact]
        public void ShapeFactory_CreateShape_ThrowsNotSupportedException()
        {
            Assert.Throws<NotSupportedException>(() => ShapeFactory.CreateShape(ShapeType.Square, 5));
        }
    }
}
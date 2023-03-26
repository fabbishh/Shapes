using ShapeLibrary.Shapes.Base;

namespace ShapeLibrary.Shapes
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным");

            _radius = radius;
        }

        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

        public override bool IsRightAngled()
        {
            return false;
        }
    }
}

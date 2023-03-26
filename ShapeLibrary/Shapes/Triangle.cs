using ShapeLibrary.Shapes.Base;

namespace ShapeLibrary.Shapes
{
    public class Triangle : Shape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideA <= 0 || sideA <= 0)
            {
                throw new ArgumentException("Сторона должна быть положительной");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double GetArea()
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public override bool IsRightAngled()
        {
            var sideList = new List<double>() { _sideA, _sideB, _sideC };
            var maxSide = sideList.Max();
            var maxSqr = maxSide * maxSide;
            bool isRectangular = maxSqr + maxSqr == _sideA * _sideA + _sideB * _sideB + _sideC * _sideC;
            return isRectangular;
        }

    }
}
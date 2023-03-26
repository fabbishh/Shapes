using ShapeLibrary.Shapes;
using ShapeLibrary.Shapes.Base;

namespace ShapeLibrary
{
    public static class ShapeFactory
    {
        public static Shape CreateShape(ShapeType shapeType, params double[] parameters)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle(parameters[0]);
                case ShapeType.Triangle:
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                default:
                    throw new NotSupportedException($"Unsupported shape type: {shapeType.ToString()}");
            }
        }
    }
}

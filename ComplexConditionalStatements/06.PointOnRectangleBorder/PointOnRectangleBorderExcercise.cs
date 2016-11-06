using System;

namespace _06.PointOnRectangleBorder
{
    class PointOnRectangleBorderExcercise
    {
        static void Main(string[] args)
        {
            var upperLeftPointXCoordinate =
                double.Parse(Console.ReadLine());
            var upperLeftPointYCoordinate =
                double.Parse(Console.ReadLine());
            var lowerRightPointXCoordinate =
                double.Parse(Console.ReadLine());
            var lowerRightPointYCoordinate =
                double.Parse(Console.ReadLine());
            var pointToCheckXCoordinate =
                double.Parse(Console.ReadLine());
            var pointToCheckYCoordinate =
                double.Parse(Console.ReadLine());

            var isPointHorizontallyBetweenGivenRectanglePoints =
                upperLeftPointXCoordinate <=
                pointToCheckXCoordinate &&
                pointToCheckXCoordinate <=
                lowerRightPointXCoordinate;
            var isPointOnHorizontalSide =
                pointToCheckYCoordinate ==
                upperLeftPointYCoordinate ||
                pointToCheckYCoordinate ==
                lowerRightPointYCoordinate;

            var isPointVerticallyBetweenGivenRectanglePoints =
                upperLeftPointYCoordinate <=
                pointToCheckYCoordinate &&
                pointToCheckYCoordinate <=
                lowerRightPointYCoordinate;
            var isPointOnVerticalSide =
                pointToCheckXCoordinate ==
                upperLeftPointXCoordinate ||
                pointToCheckXCoordinate ==
                lowerRightPointXCoordinate;

            var isPointHorizontallyOnBorder =
                isPointHorizontallyBetweenGivenRectanglePoints &&
                isPointOnHorizontalSide;
            var isPointVerticallyOnBorder =
                isPointVerticallyBetweenGivenRectanglePoints &&
                isPointOnVerticalSide;

            var isPointOnBorder =
                isPointHorizontallyOnBorder ||
                isPointVerticallyOnBorder;

            if (isPointOnBorder)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}

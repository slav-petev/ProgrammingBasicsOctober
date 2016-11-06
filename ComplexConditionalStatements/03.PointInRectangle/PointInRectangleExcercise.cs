using System;

namespace _03.PointInRectangle
{
    class PointInRectangleExcercise
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

            bool isPointHorizontallyInside =
                upperLeftPointXCoordinate <=
                pointToCheckXCoordinate &&
                pointToCheckXCoordinate <=
                lowerRightPointXCoordinate;
            bool isPointVerticallyInside =
                upperLeftPointYCoordinate <=
                pointToCheckYCoordinate &&
                pointToCheckYCoordinate <=
                lowerRightPointYCoordinate;

            bool isPointInside =
                 isPointHorizontallyInside &&
                 isPointVerticallyInside;

            if (isPointInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}

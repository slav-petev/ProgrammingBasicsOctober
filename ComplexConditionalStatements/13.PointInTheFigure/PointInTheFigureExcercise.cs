using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class PointInTheFigureExcercise
    {
        static void Main(string[] args)
        {
            var blockSize = int.Parse(
                Console.ReadLine());
            var pointToCheckX = int.Parse(
                Console.ReadLine());
            var pointToCheckY = int.Parse(
                Console.ReadLine());

            var lowerRectangleLowerLeftPointX = 0;
            var lowerRectangleLowerLeftPointY = 0;

            var lowerRectangleLowerRightPointX = 
                3 * blockSize;

            var lowerRectangleUpperLeftPointY = 
                blockSize;

            var pointHorizontallyInsideLowerRectangle =
                lowerRectangleLowerLeftPointX < 
                pointToCheckX &&
                pointToCheckX < 
                lowerRectangleLowerRightPointX;
            var pointVerticallyInsideLowerRectangle =
                lowerRectangleLowerLeftPointY < 
                pointToCheckY &&
                pointToCheckY < 
                lowerRectangleUpperLeftPointY;
            var pointInsideLowerRectangle =
                pointHorizontallyInsideLowerRectangle && 
                pointVerticallyInsideLowerRectangle;

            var pointHorizontallyOutsideLowerRectangle =
                pointToCheckX < 
                lowerRectangleLowerLeftPointX ||
                lowerRectangleLowerRightPointX < 
                pointToCheckX;
            var pointVericallyOutsideLowerRectangle =
                pointToCheckY < 
                lowerRectangleLowerLeftPointY ||
                lowerRectangleUpperLeftPointY < 
                pointToCheckY;
            var pointOutsideLowerRectangle =
                pointHorizontallyOutsideLowerRectangle || 
                pointVericallyOutsideLowerRectangle;

            var pointOnBorderOfLowerRectangle =
                !pointInsideLowerRectangle && 
                !pointOutsideLowerRectangle;

            var upperRectangleLowerLeftPointX = 
                blockSize;
            var upperRectangleLowerLeftPointY = 
                blockSize;

            var upperRectangleLowerRightPointX = 
                2 * blockSize;

            var upperRectangleUpperLeftPointY = 
                4 * blockSize;

            var pointHorizontallyInsideupperRectangle =
                upperRectangleLowerLeftPointX < 
                pointToCheckX &&
                pointToCheckX < 
                upperRectangleLowerRightPointX;
            var pointVerticallyInsideUpperRectangle =
                upperRectangleLowerLeftPointY < 
                pointToCheckY &&
                pointToCheckY < 
                upperRectangleUpperLeftPointY;
            var pointInsideUpperRectangle =
                pointHorizontallyInsideupperRectangle && 
                pointVerticallyInsideUpperRectangle;

            var pointHorizontallyOutsideUpperRectangle =
                pointToCheckX < 
                upperRectangleLowerLeftPointX ||
                upperRectangleLowerRightPointX < 
                pointToCheckX;
            var pointVericallyOutsideUpperRectangle =
                pointToCheckY < 
                upperRectangleLowerLeftPointY ||
                upperRectangleUpperLeftPointY < 
                pointToCheckY;
            var pointOutsideUpperRectangle =
                pointHorizontallyOutsideUpperRectangle || 
                pointVericallyOutsideUpperRectangle;

            var pointOnBorderOfUpperRectangle =
                !pointInsideUpperRectangle && 
                !pointOutsideUpperRectangle;

            var pointOnCommonSideOfRectangles =
                pointOnBorderOfLowerRectangle && 
                pointOnBorderOfUpperRectangle &&
                blockSize < 
                pointToCheckX && 
                pointToCheckX < 2 * blockSize;

            var pointInsideFigure = 
                pointInsideLowerRectangle ||
                pointInsideUpperRectangle || 
                pointOnCommonSideOfRectangles;
            var pointOutsideFigure = 
                pointOutsideLowerRectangle && 
                pointOutsideUpperRectangle;
            var pointOnBorderOfFigure = 
                !pointInsideFigure && 
                !pointOutsideFigure;

            if (pointInsideFigure)
            {
                Console.WriteLine("inside");
            }
            else if (pointOnBorderOfFigure)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
